﻿using System;
using System.IO.Ports;
using System.Collections.Generic;
using Gtk;
using RobotInterface;

public partial class MainWindow : Gtk.Window
{

    #region FIELDS

    private Timeline timeline;
    private Robot robot = new Robot(
            new Servo(10, 170, 90),
            new Servo(10, 170, 170),
            new Servo(10, 170, 35),
            new Servo(10, 170, 90),
            new Servo(10, 170, 90),
            new Servo(10, 170, 90),
            new Servo(0, 180, 0)
        );
    private List<Gtk.HScale> actuatorScales = new List<Gtk.HScale>();

    #endregion


    #region CONSTRUCTORS/DESCTRUCTORS

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        //Init actuator scales.
        this.InitActuatorScales();

        //Load available serial ports.
        this.LoadAvailableSerialPorts();

        //Update baud rate and serial port.
        this.OnBaudRateDropdownChanged(this.BaudRateDropdown, null);
        this.OnSerialPortDropdownChanged(this.SerialPortDropdown, null);

        //Init timeline.
        this.timeline = new Timeline(ref this.FrameTreeView);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    #endregion


    #region METHODS

    private void InitActuatorScales()
    {
        //Clear actuator scales list.
        this.actuatorScales.Clear();

        //Add actuators to actuator scales list.
        this.actuatorScales.Add(this.FrameActuatorScale);
        this.actuatorScales.Add(this.FrameActuatorScale1);
        this.actuatorScales.Add(this.FrameActuatorScale2);
        this.actuatorScales.Add(this.FrameActuatorScale3);
        this.actuatorScales.Add(this.FrameActuatorScale4);
        this.actuatorScales.Add(this.FrameActuatorScale5);
        this.actuatorScales.Add(this.FrameActuatorScale6);

        //Set values of scales.
        for(int i = 0; i < actuatorScales.Count; i++) 
        {
            this.actuatorScales[i].Adjustment.Lower = this.robot.Servos[i].MinAngle;
            this.actuatorScales[i].Adjustment.Upper = this.robot.Servos[i].MaxAngle;
            this.actuatorScales[i].Adjustment.Value = this.robot.Servos[i].Angle;
        }
    }

    private void LoadAvailableSerialPorts()
    {

        //Add serial ports to dropdown.
        foreach (string portName in Serial.Instance.GetPortNames())
        {
            this.SerialPortDropdown.AppendText(portName); 
        }

        //Set active serial port.
        this.SerialPortDropdown.Active = 0;

    }

    private void AddToSerialTerminal(string text)
    {
        //Add time to text.
        DateTime dateTime = DateTime.Now;
        text = string.Format(
                "[{0}:{1}:{2}.{3}] {4}",
                dateTime.Hour.ToString().PadLeft(2, '0'),
                dateTime.Minute.ToString().PadLeft(2, '0'),
                dateTime.Second.ToString().PadLeft(2, '0'),
                dateTime.Millisecond.ToString().PadLeft(3, '0'),
                text
            );

        //Add text.
        var iter = this.SerialTerminal.Buffer.GetIterAtLine(this.SerialTerminal.Buffer.LineCount);
        this.SerialTerminal.Buffer.Insert(ref iter, text + "\n");
    }

    public float[] GetActuatorScaleValues()
    {
        float[] values = new float[this.actuatorScales.Count];

        for (int i = 0; i < values.Length; i++)
            values[i] = (float)this.actuatorScales[i].Adjustment.Value;

        return values;
    }

    public void SetSelectedFrame(Keyframe frame)
    {
        this.FramePropertiesPanel.Sensitive = true;
        this.FrameNameEntry.Text = frame.name;
        this.FrameTimeEntry.Text = frame.time.ToString();

        for(int i = 0; i < this.actuatorScales.Count; i++)
        {
            this.actuatorScales[i].Value = frame.actuatorValues[i];
        }
    }

    #endregion


    #region EVENTS

    private void OnConnectSerial()
    {
        this.AddToSerialTerminal("Device connected successfully.");

        //Set connect serial action icon.
        this.connectSerialAction.StockId = Stock.Connect;

        //Disable baudrate and port dropdowns.
        this.BaudRateDropdown.Sensitive = false;
        this.SerialPortDropdown.Sensitive = false;

        //Delay
        System.Threading.Thread.Sleep(3000);

        //Init servo angles.
        this.robot.InitializeServoAngles();

    }

    private void OnDisconnectSerial()
    {
        this.AddToSerialTerminal("Device disconnected successfully.");

        //Set connect serial action icon.
        this.connectSerialAction.StockId = Stock.Disconnect;

        //Enable baudrate and port dropdowns.
        this.BaudRateDropdown.Sensitive = true;
        this.SerialPortDropdown.Sensitive = true;

    }

    protected void OnSerialPortDropdownChanged(object sender, EventArgs e)
    {

        //Set serial port.
        Serial.Instance.SetSerialPort(((ComboBox)sender).ActiveText);

    }

    protected void OnBaudRateDropdownChanged(object sender, EventArgs e)
    {

        int baudRate = 0;

        try
        {
            baudRate = Convert.ToInt32(((ComboBox)sender).ActiveText);
        }
        catch(Exception)
        {
            Console.WriteLine("Could not convert dropdown baud rate to int.");
        }

        //Set baud rate.
        Serial.Instance.SetBaudRate(baudRate);

    }

    protected void OnConnectSerialActivated(object sender, EventArgs e)
    {

        if (!Serial.Instance.IsOpen())
        {
            if (Serial.Instance.Open()) this.OnConnectSerial();
            else 
            {
                MessageDialog dialog = new MessageDialog(
                        null,
                        DialogFlags.Modal,
                        MessageType.Info,
                        ButtonsType.Ok,
                        "Could not open serial port."
                    );
                dialog.Run();
                dialog.Destroy();
            }
        }
        else
        {
            if (Serial.Instance.Close()) this.OnDisconnectSerial();
            else
            {
                MessageDialog dialog = new MessageDialog(
                            null,
                            DialogFlags.Modal,
                            MessageType.Info,
                            ButtonsType.Ok,
                            "Could not close serial port."
                        );
                dialog.Run();
                dialog.Destroy();
            }
        }

    }

    protected void OnActuatorScaleChanged(object sender, EventArgs e)
    {
        //Get sender name.
        string senderName = ((Gtk.Widget)sender).Name;

        //Check what scale to update.
        for(int i = 0; i < this.actuatorScales.Count; i++) 
        {
            Gtk.HScale actuatorScale  = this.actuatorScales[i];

            //If actuator name not sender name, continue.
            if (actuatorScale.Name != senderName) continue;

            //Update servo connected to actuator.
            this.robot.SetServoAngle(i, (float)actuatorScale.Adjustment.Value);

            break;
        }
    }

    protected void OnAddFrameActivated(object sender, EventArgs e)
    {
        this.timeline.AddKeyframe(null, null, this.GetActuatorScaleValues());
    }

    protected void OnRemoveFrameActivated(object sender, EventArgs e)
    {

    }

    protected void OnFrameTreeViewRowActivated(object o, RowActivatedArgs args)
    {
        //Set selected frame to the last selected frame.
        this.SetSelectedFrame(this.timeline.Keyframes[args.Path.Indices[args.Path.Indices.Length - 1]]);
    }

    #endregion
}
