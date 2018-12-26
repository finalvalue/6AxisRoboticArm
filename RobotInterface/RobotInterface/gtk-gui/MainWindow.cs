
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action mediaPreviousAction;

	private global::Gtk.Action mediaStopAction;

	private global::Gtk.Action mediaPlayAction;

	private global::Gtk.Action mediaNextAction;

	private global::Gtk.Action newAction;

	private global::Gtk.Action openAction;

	private global::Gtk.Action floppyAction;

	private global::Gtk.Action revertToSavedAction;

	private global::Gtk.Action connectSerialAction;

	private global::Gtk.Action addAction;

	private global::Gtk.Action removeAction;

	private global::Gtk.VBox VPanel1;

	private global::Gtk.HBox MenuBar;

	private global::Gtk.Toolbar MenuTools;

	private global::Gtk.ComboBox SerialPortDropdown;

	private global::Gtk.ComboBox BaudRateDropdown;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry TimeEntry;

	private global::Gtk.Label label2;

	private global::Gtk.Toolbar MediaControls;

	private global::Gtk.HPaned HPanel1;

	private global::Gtk.VPaned vpaned1;

	private global::Gtk.VBox vbox8;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Label label16;

	private global::Gtk.Fixed fixed2;

	private global::Gtk.Toolbar FrameToolbar;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView FrameTreeView;

	private global::Gtk.VBox TerminalPanel;

	private global::Gtk.HBox TerminalHeader;

	private global::Gtk.Label label1;

	private global::Gtk.ScrolledWindow TerminalScrollWindow;

	private global::Gtk.TextView SerialTerminal;

	private global::Gtk.VBox vbox7;

	private global::Gtk.HBox hbox7;

	private global::Gtk.Label label15;

	private global::Gtk.ScrolledWindow scrolledwindow1;

	private global::Gtk.VBox FramePropertiesPanel;

	private global::Gtk.VBox PropertyContainer1;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.VBox PropertyContent1;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label label13;

	private global::Gtk.Entry FrameNameEntry;

	private global::Gtk.HBox hbox6;

	private global::Gtk.Label label14;

	private global::Gtk.Entry FrameTimeEntry;

	private global::Gtk.VBox PropertyContainer;

	private global::Gtk.HSeparator hseparator2;

	private global::Gtk.HBox PropertyHeader;

	private global::Gtk.Label label4;

	private global::Gtk.VBox PropertyContent;

	private global::Gtk.HScale FrameActuatorScale;

	private global::Gtk.HScale FrameActuatorScale1;

	private global::Gtk.HScale FrameActuatorScale2;

	private global::Gtk.HScale FrameActuatorScale3;

	private global::Gtk.HScale FrameActuatorScale4;

	private global::Gtk.HScale FrameActuatorScale5;

	private global::Gtk.HScale FrameActuatorScale6;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.mediaPreviousAction = new global::Gtk.Action("mediaPreviousAction", null, null, "gtk-media-previous");
		w1.Add(this.mediaPreviousAction, null);
		this.mediaStopAction = new global::Gtk.Action("mediaStopAction", null, null, "gtk-media-stop");
		w1.Add(this.mediaStopAction, null);
		this.mediaPlayAction = new global::Gtk.Action("mediaPlayAction", null, null, "gtk-media-play");
		w1.Add(this.mediaPlayAction, null);
		this.mediaNextAction = new global::Gtk.Action("mediaNextAction", null, null, "gtk-media-next");
		w1.Add(this.mediaNextAction, null);
		this.newAction = new global::Gtk.Action("newAction", null, null, "gtk-new");
		w1.Add(this.newAction, null);
		this.openAction = new global::Gtk.Action("openAction", null, null, "gtk-open");
		w1.Add(this.openAction, null);
		this.floppyAction = new global::Gtk.Action("floppyAction", null, null, "gtk-floppy");
		w1.Add(this.floppyAction, null);
		this.revertToSavedAction = new global::Gtk.Action("revertToSavedAction", null, null, "gtk-revert-to-saved");
		w1.Add(this.revertToSavedAction, null);
		this.connectSerialAction = new global::Gtk.Action("connectSerialAction", null, null, "gtk-disconnect");
		w1.Add(this.connectSerialAction, null);
		this.addAction = new global::Gtk.Action("addAction", null, null, "gtk-add");
		w1.Add(this.addAction, null);
		this.removeAction = new global::Gtk.Action("removeAction", null, null, "gtk-remove");
		w1.Add(this.removeAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("RobotInterface");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.VPanel1 = new global::Gtk.VBox();
		this.VPanel1.Name = "VPanel1";
		this.VPanel1.Spacing = 6;
		// Container child VPanel1.Gtk.Box+BoxChild
		this.MenuBar = new global::Gtk.HBox();
		this.MenuBar.Name = "MenuBar";
		this.MenuBar.Spacing = 6;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><toolbar name='MenuTools'><toolitem name='newAction' action='newAction'/><separator/><toolitem name='openAction' action='openAction'/><separator/><toolitem name='floppyAction' action='floppyAction'/><toolitem name='revertToSavedAction' action='revertToSavedAction'/><separator/><toolitem name='connectSerialAction' action='connectSerialAction'/></toolbar></ui>");
		this.MenuTools = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/MenuTools")));
		this.MenuTools.Name = "MenuTools";
		this.MenuTools.ShowArrow = false;
		this.MenuTools.IconSize = ((global::Gtk.IconSize)(2));
		this.MenuBar.Add(this.MenuTools);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.MenuTools]));
		w2.Position = 0;
		w2.Expand = false;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.SerialPortDropdown = global::Gtk.ComboBox.NewText();
		this.SerialPortDropdown.Name = "SerialPortDropdown";
		this.MenuBar.Add(this.SerialPortDropdown);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.SerialPortDropdown]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.BaudRateDropdown = global::Gtk.ComboBox.NewText();
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("110"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("300"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("600"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("1200"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("2400"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("4800"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("9600"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("14400"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("19200"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("38400"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("57600"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("115200"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("128000"));
		this.BaudRateDropdown.AppendText(global::Mono.Unix.Catalog.GetString("256000"));
		this.BaudRateDropdown.Name = "BaudRateDropdown";
		this.BaudRateDropdown.Active = 11;
		this.MenuBar.Add(this.BaudRateDropdown);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.BaudRateDropdown]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.MenuBar.Add(this.fixed1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.fixed1]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 3;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.TimeEntry = new global::Gtk.Entry();
		this.TimeEntry.WidthRequest = 160;
		this.TimeEntry.CanFocus = true;
		this.TimeEntry.Name = "TimeEntry";
		this.TimeEntry.Text = global::Mono.Unix.Catalog.GetString("0");
		this.TimeEntry.IsEditable = true;
		this.TimeEntry.InvisibleChar = '•';
		this.MenuBar.Add(this.TimeEntry);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.TimeEntry]));
		w6.PackType = ((global::Gtk.PackType)(1));
		w6.Position = 4;
		w6.Expand = false;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Time (Milliseconds):");
		this.MenuBar.Add(this.label2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.label2]));
		w7.PackType = ((global::Gtk.PackType)(1));
		w7.Position = 5;
		w7.Expand = false;
		w7.Fill = false;
		// Container child MenuBar.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><toolbar name='MediaControls'><toolitem name='mediaPreviousAction' action='mediaPreviousAction'/><toolitem name='mediaStopAction' action='mediaStopAction'/><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='mediaNextAction' action='mediaNextAction'/></toolbar></ui>");
		this.MediaControls = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/MediaControls")));
		this.MediaControls.Name = "MediaControls";
		this.MediaControls.ShowArrow = false;
		this.MediaControls.IconSize = ((global::Gtk.IconSize)(2));
		this.MenuBar.Add(this.MediaControls);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.MenuBar[this.MediaControls]));
		w8.PackType = ((global::Gtk.PackType)(1));
		w8.Position = 6;
		w8.Expand = false;
		this.VPanel1.Add(this.MenuBar);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.VPanel1[this.MenuBar]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child VPanel1.Gtk.Box+BoxChild
		this.HPanel1 = new global::Gtk.HPaned();
		this.HPanel1.CanFocus = true;
		this.HPanel1.Name = "HPanel1";
		this.HPanel1.Position = 935;
		// Container child HPanel1.Gtk.Paned+PanedChild
		this.vpaned1 = new global::Gtk.VPaned();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 406;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label16 = new global::Gtk.Label();
		this.label16.Name = "label16";
		this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("Frames");
		this.hbox8.Add(this.label16);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label16]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.fixed2 = new global::Gtk.Fixed();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		this.hbox8.Add(this.fixed2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.fixed2]));
		w11.Position = 1;
		// Container child hbox8.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><toolbar name=\'FrameToolbar\'><toolitem name=\'addAction\' action=\'addAction\'/><" +
				"toolitem name=\'removeAction\' action=\'removeAction\'/></toolbar></ui>");
		this.FrameToolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/FrameToolbar")));
		this.FrameToolbar.Name = "FrameToolbar";
		this.FrameToolbar.ShowArrow = false;
		this.FrameToolbar.IconSize = ((global::Gtk.IconSize)(2));
		this.hbox8.Add(this.FrameToolbar);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.FrameToolbar]));
		w12.Position = 2;
		w12.Expand = false;
		this.vbox8.Add(this.hbox8);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox8]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.FrameTreeView = new global::Gtk.TreeView();
		this.FrameTreeView.CanFocus = true;
		this.FrameTreeView.Name = "FrameTreeView";
		this.GtkScrolledWindow.Add(this.FrameTreeView);
		this.vbox8.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.GtkScrolledWindow]));
		w15.Position = 1;
		this.vpaned1.Add(this.vbox8);
		global::Gtk.Paned.PanedChild w16 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.vbox8]));
		w16.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.TerminalPanel = new global::Gtk.VBox();
		this.TerminalPanel.Name = "TerminalPanel";
		this.TerminalPanel.Spacing = 6;
		// Container child TerminalPanel.Gtk.Box+BoxChild
		this.TerminalHeader = new global::Gtk.HBox();
		this.TerminalHeader.Name = "TerminalHeader";
		this.TerminalHeader.Spacing = 6;
		// Container child TerminalHeader.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Terminal");
		this.TerminalHeader.Add(this.label1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.TerminalHeader[this.label1]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		this.TerminalPanel.Add(this.TerminalHeader);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.TerminalPanel[this.TerminalHeader]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child TerminalPanel.Gtk.Box+BoxChild
		this.TerminalScrollWindow = new global::Gtk.ScrolledWindow();
		this.TerminalScrollWindow.Name = "TerminalScrollWindow";
		this.TerminalScrollWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child TerminalScrollWindow.Gtk.Container+ContainerChild
		this.SerialTerminal = new global::Gtk.TextView();
		this.SerialTerminal.CanFocus = true;
		this.SerialTerminal.Name = "SerialTerminal";
		this.SerialTerminal.Editable = false;
		this.SerialTerminal.CursorVisible = false;
		this.TerminalScrollWindow.Add(this.SerialTerminal);
		this.TerminalPanel.Add(this.TerminalScrollWindow);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.TerminalPanel[this.TerminalScrollWindow]));
		w20.Position = 1;
		this.vpaned1.Add(this.TerminalPanel);
		global::Gtk.Paned.PanedChild w21 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.TerminalPanel]));
		w21.Resize = false;
		w21.Shrink = false;
		this.HPanel1.Add(this.vpaned1);
		global::Gtk.Paned.PanedChild w22 = ((global::Gtk.Paned.PanedChild)(this.HPanel1[this.vpaned1]));
		w22.Resize = false;
		// Container child HPanel1.Gtk.Paned+PanedChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label15 = new global::Gtk.Label();
		this.label15.Name = "label15";
		this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Frame Properties");
		this.hbox7.Add(this.label15);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label15]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		this.vbox7.Add(this.hbox7);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox7]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		global::Gtk.Viewport w25 = new global::Gtk.Viewport();
		w25.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.FramePropertiesPanel = new global::Gtk.VBox();
		this.FramePropertiesPanel.Sensitive = false;
		this.FramePropertiesPanel.Name = "FramePropertiesPanel";
		this.FramePropertiesPanel.Spacing = 6;
		// Container child FramePropertiesPanel.Gtk.Box+BoxChild
		this.PropertyContainer1 = new global::Gtk.VBox();
		this.PropertyContainer1.Name = "PropertyContainer1";
		this.PropertyContainer1.Spacing = 6;
		// Container child PropertyContainer1.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.Name = "hseparator1";
		this.PropertyContainer1.Add(this.hseparator1);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.PropertyContainer1[this.hseparator1]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child PropertyContainer1.Gtk.Box+BoxChild
		this.PropertyContent1 = new global::Gtk.VBox();
		this.PropertyContent1.Name = "PropertyContent1";
		this.PropertyContent1.Spacing = 6;
		// Container child PropertyContent1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label13 = new global::Gtk.Label();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Name");
		this.hbox5.Add(this.label13);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label13]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		this.PropertyContent1.Add(this.hbox5);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.PropertyContent1[this.hbox5]));
		w28.Position = 0;
		w28.Expand = false;
		w28.Fill = false;
		// Container child PropertyContent1.Gtk.Box+BoxChild
		this.FrameNameEntry = new global::Gtk.Entry();
		this.FrameNameEntry.CanFocus = true;
		this.FrameNameEntry.Name = "FrameNameEntry";
		this.FrameNameEntry.IsEditable = true;
		this.FrameNameEntry.InvisibleChar = '•';
		this.PropertyContent1.Add(this.FrameNameEntry);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.PropertyContent1[this.FrameNameEntry]));
		w29.Position = 1;
		w29.Expand = false;
		w29.Fill = false;
		// Container child PropertyContent1.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label14 = new global::Gtk.Label();
		this.label14.Name = "label14";
		this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Time (Milliseconds)");
		this.hbox6.Add(this.label14);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label14]));
		w30.Position = 0;
		w30.Expand = false;
		w30.Fill = false;
		this.PropertyContent1.Add(this.hbox6);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.PropertyContent1[this.hbox6]));
		w31.Position = 2;
		w31.Expand = false;
		w31.Fill = false;
		// Container child PropertyContent1.Gtk.Box+BoxChild
		this.FrameTimeEntry = new global::Gtk.Entry();
		this.FrameTimeEntry.CanFocus = true;
		this.FrameTimeEntry.Name = "FrameTimeEntry";
		this.FrameTimeEntry.IsEditable = true;
		this.FrameTimeEntry.InvisibleChar = '•';
		this.PropertyContent1.Add(this.FrameTimeEntry);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.PropertyContent1[this.FrameTimeEntry]));
		w32.Position = 3;
		w32.Expand = false;
		w32.Fill = false;
		this.PropertyContainer1.Add(this.PropertyContent1);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.PropertyContainer1[this.PropertyContent1]));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		this.FramePropertiesPanel.Add(this.PropertyContainer1);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.FramePropertiesPanel[this.PropertyContainer1]));
		w34.Position = 0;
		w34.Expand = false;
		w34.Fill = false;
		// Container child FramePropertiesPanel.Gtk.Box+BoxChild
		this.PropertyContainer = new global::Gtk.VBox();
		this.PropertyContainer.Name = "PropertyContainer";
		this.PropertyContainer.Spacing = 6;
		// Container child PropertyContainer.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator();
		this.hseparator2.Name = "hseparator2";
		this.PropertyContainer.Add(this.hseparator2);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.PropertyContainer[this.hseparator2]));
		w35.Position = 0;
		w35.Expand = false;
		w35.Fill = false;
		// Container child PropertyContainer.Gtk.Box+BoxChild
		this.PropertyHeader = new global::Gtk.HBox();
		this.PropertyHeader.Name = "PropertyHeader";
		this.PropertyHeader.Spacing = 6;
		// Container child PropertyHeader.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Actuators");
		this.PropertyHeader.Add(this.label4);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.PropertyHeader[this.label4]));
		w36.Position = 0;
		w36.Expand = false;
		w36.Fill = false;
		this.PropertyContainer.Add(this.PropertyHeader);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.PropertyContainer[this.PropertyHeader]));
		w37.Position = 1;
		w37.Expand = false;
		w37.Fill = false;
		// Container child PropertyContainer.Gtk.Box+BoxChild
		this.PropertyContent = new global::Gtk.VBox();
		this.PropertyContent.Name = "PropertyContent";
		this.PropertyContent.Spacing = 6;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale = new global::Gtk.HScale(null);
		this.FrameActuatorScale.CanFocus = true;
		this.FrameActuatorScale.Name = "FrameActuatorScale";
		this.FrameActuatorScale.Adjustment.Upper = 180D;
		this.FrameActuatorScale.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale.DrawValue = true;
		this.FrameActuatorScale.Digits = 0;
		this.FrameActuatorScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale]));
		w38.Position = 0;
		w38.Expand = false;
		w38.Fill = false;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale1 = new global::Gtk.HScale(null);
		this.FrameActuatorScale1.CanFocus = true;
		this.FrameActuatorScale1.Name = "FrameActuatorScale1";
		this.FrameActuatorScale1.Adjustment.Upper = 180D;
		this.FrameActuatorScale1.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale1.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale1.DrawValue = true;
		this.FrameActuatorScale1.Digits = 0;
		this.FrameActuatorScale1.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale1);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale1]));
		w39.Position = 1;
		w39.Expand = false;
		w39.Fill = false;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale2 = new global::Gtk.HScale(null);
		this.FrameActuatorScale2.CanFocus = true;
		this.FrameActuatorScale2.Name = "FrameActuatorScale2";
		this.FrameActuatorScale2.Adjustment.Upper = 180D;
		this.FrameActuatorScale2.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale2.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale2.DrawValue = true;
		this.FrameActuatorScale2.Digits = 0;
		this.FrameActuatorScale2.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale2);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale2]));
		w40.Position = 2;
		w40.Expand = false;
		w40.Fill = false;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale3 = new global::Gtk.HScale(null);
		this.FrameActuatorScale3.CanFocus = true;
		this.FrameActuatorScale3.Name = "FrameActuatorScale3";
		this.FrameActuatorScale3.Adjustment.Upper = 180D;
		this.FrameActuatorScale3.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale3.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale3.DrawValue = true;
		this.FrameActuatorScale3.Digits = 0;
		this.FrameActuatorScale3.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale3);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale3]));
		w41.Position = 3;
		w41.Expand = false;
		w41.Fill = false;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale4 = new global::Gtk.HScale(null);
		this.FrameActuatorScale4.CanFocus = true;
		this.FrameActuatorScale4.Name = "FrameActuatorScale4";
		this.FrameActuatorScale4.Adjustment.Upper = 180D;
		this.FrameActuatorScale4.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale4.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale4.DrawValue = true;
		this.FrameActuatorScale4.Digits = 0;
		this.FrameActuatorScale4.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale4);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale4]));
		w42.Position = 4;
		w42.Expand = false;
		w42.Fill = false;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale5 = new global::Gtk.HScale(null);
		this.FrameActuatorScale5.CanFocus = true;
		this.FrameActuatorScale5.Name = "FrameActuatorScale5";
		this.FrameActuatorScale5.Adjustment.Upper = 180D;
		this.FrameActuatorScale5.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale5.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale5.DrawValue = true;
		this.FrameActuatorScale5.Digits = 0;
		this.FrameActuatorScale5.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale5);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale5]));
		w43.Position = 5;
		w43.Expand = false;
		w43.Fill = false;
		// Container child PropertyContent.Gtk.Box+BoxChild
		this.FrameActuatorScale6 = new global::Gtk.HScale(null);
		this.FrameActuatorScale6.CanFocus = true;
		this.FrameActuatorScale6.Name = "FrameActuatorScale6";
		this.FrameActuatorScale6.Adjustment.Upper = 180D;
		this.FrameActuatorScale6.Adjustment.PageIncrement = 10D;
		this.FrameActuatorScale6.Adjustment.StepIncrement = 1D;
		this.FrameActuatorScale6.DrawValue = true;
		this.FrameActuatorScale6.Digits = 0;
		this.FrameActuatorScale6.ValuePos = ((global::Gtk.PositionType)(2));
		this.PropertyContent.Add(this.FrameActuatorScale6);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.PropertyContent[this.FrameActuatorScale6]));
		w44.Position = 6;
		w44.Expand = false;
		w44.Fill = false;
		this.PropertyContainer.Add(this.PropertyContent);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.PropertyContainer[this.PropertyContent]));
		w45.Position = 2;
		w45.Expand = false;
		w45.Fill = false;
		this.FramePropertiesPanel.Add(this.PropertyContainer);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.FramePropertiesPanel[this.PropertyContainer]));
		w46.Position = 1;
		w46.Expand = false;
		w46.Fill = false;
		w25.Add(this.FramePropertiesPanel);
		this.scrolledwindow1.Add(w25);
		this.vbox7.Add(this.scrolledwindow1);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.scrolledwindow1]));
		w49.Position = 1;
		this.HPanel1.Add(this.vbox7);
		global::Gtk.Paned.PanedChild w50 = ((global::Gtk.Paned.PanedChild)(this.HPanel1[this.vbox7]));
		w50.Resize = false;
		w50.Shrink = false;
		this.VPanel1.Add(this.HPanel1);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.VPanel1[this.HPanel1]));
		w51.Position = 1;
		this.Add(this.VPanel1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1209;
		this.DefaultHeight = 648;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.connectSerialAction.Activated += new global::System.EventHandler(this.OnConnectSerialActivated);
		this.addAction.Activated += new global::System.EventHandler(this.OnAddFrameActivated);
		this.removeAction.Activated += new global::System.EventHandler(this.OnRemoveFrameActivated);
		this.SerialPortDropdown.Changed += new global::System.EventHandler(this.OnSerialPortDropdownChanged);
		this.BaudRateDropdown.Changed += new global::System.EventHandler(this.OnBaudRateDropdownChanged);
		this.FrameTreeView.RowActivated += new global::Gtk.RowActivatedHandler(this.OnFrameTreeViewRowActivated);
		this.FrameActuatorScale.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
		this.FrameActuatorScale1.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
		this.FrameActuatorScale2.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
		this.FrameActuatorScale3.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
		this.FrameActuatorScale4.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
		this.FrameActuatorScale5.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
		this.FrameActuatorScale6.ValueChanged += new global::System.EventHandler(this.OnActuatorScaleChanged);
	}
}
