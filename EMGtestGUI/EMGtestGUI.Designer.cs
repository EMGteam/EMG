namespace EMG
{
  partial class EMGtestGUI
  {
    /// <summary>
    /// Wymagana zmienna projektanta.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Wyczyść wszystkie używane zasoby.
    /// </summary>
    /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Kod generowany przez Projektanta formularzy systemu Windows

    /// <summary>
    /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
    /// zawartość tej metody z edytorem kodu.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMGtestGUI));
      this.timerTEST = new System.Windows.Forms.Timer(this.components);
      this.emgChart16 = new EMG.EMGchart();
      this.emgChart15 = new EMG.EMGchart();
      this.emgChart14 = new EMG.EMGchart();
      this.emgChart13 = new EMG.EMGchart();
      this.emgChart12 = new EMG.EMGchart();
      this.emgChart11 = new EMG.EMGchart();
      this.emgChart10 = new EMG.EMGchart();
      this.emgChart9 = new EMG.EMGchart();
      this.emgChart8 = new EMG.EMGchart();
      this.emgChart7 = new EMG.EMGchart();
      this.emgChart6 = new EMG.EMGchart();
      this.emgChart5 = new EMG.EMGchart();
      this.emgChart4 = new EMG.EMGchart();
      this.emgChart3 = new EMG.EMGchart();
      this.emgChart2 = new EMG.EMGchart();
      this.emgChart1 = new EMG.EMGchart();
      this.sensorThumb = new EMG.EMGforceSensor();
      this.sensorIndex = new EMG.EMGforceSensor();
      this.sensorMiddle = new EMG.EMGforceSensor();
      this.sensorRing = new EMG.EMGforceSensor();
      this.sensorPinky = new EMG.EMGforceSensor();
      this.buttonScreenshot = new System.Windows.Forms.Button();
      this.panelDebugConsole = new System.Windows.Forms.Panel();
      this.emgConsole = new EMG.EMGdebugConsole();
      this.panelCharts = new System.Windows.Forms.Panel();
      this.panelSensors = new System.Windows.Forms.Panel();
      this.panelButtons = new System.Windows.Forms.Panel();
      this.progressBarPauza = new System.Windows.Forms.ProgressBar();
      this.progressBarPomiar = new System.Windows.Forms.ProgressBar();
      this.stripMenu = new System.Windows.Forms.MenuStrip();
      this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemRejestruj = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemWyczysc = new System.Windows.Forms.ToolStripMenuItem();
      this.menuOpcje = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemUstawienia = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemSensory = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPomoc = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.instantAiCtrl1 = new Automation.BDaq.InstantAiCtrl(this.components);
      this.panelDebugConsole.SuspendLayout();
      this.panelCharts.SuspendLayout();
      this.panelSensors.SuspendLayout();
      this.panelButtons.SuspendLayout();
      this.stripMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // timerTEST
      // 
      this.timerTEST.Enabled = true;
      this.timerTEST.Interval = 500;
      this.timerTEST.Tick += new System.EventHandler(this.timerTEST_Tick);
      // 
      // emgChart16
      // 
      this.emgChart16.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart16.Location = new System.Drawing.Point(263, 472);
      this.emgChart16.Name = "emgChart16";
      this.emgChart16.Size = new System.Drawing.Size(257, 64);
      this.emgChart16.TabIndex = 16;
      // 
      // emgChart15
      // 
      this.emgChart15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart15.Location = new System.Drawing.Point(3, 472);
      this.emgChart15.Name = "emgChart15";
      this.emgChart15.Size = new System.Drawing.Size(257, 64);
      this.emgChart15.TabIndex = 15;
      // 
      // emgChart14
      // 
      this.emgChart14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart14.Location = new System.Drawing.Point(263, 405);
      this.emgChart14.Name = "emgChart14";
      this.emgChart14.Size = new System.Drawing.Size(257, 64);
      this.emgChart14.TabIndex = 14;
      // 
      // emgChart13
      // 
      this.emgChart13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart13.Location = new System.Drawing.Point(3, 405);
      this.emgChart13.Name = "emgChart13";
      this.emgChart13.Size = new System.Drawing.Size(257, 64);
      this.emgChart13.TabIndex = 13;
      // 
      // emgChart12
      // 
      this.emgChart12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart12.Location = new System.Drawing.Point(263, 338);
      this.emgChart12.Name = "emgChart12";
      this.emgChart12.Size = new System.Drawing.Size(257, 64);
      this.emgChart12.TabIndex = 12;
      // 
      // emgChart11
      // 
      this.emgChart11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart11.Location = new System.Drawing.Point(3, 338);
      this.emgChart11.Name = "emgChart11";
      this.emgChart11.Size = new System.Drawing.Size(257, 64);
      this.emgChart11.TabIndex = 11;
      // 
      // emgChart10
      // 
      this.emgChart10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart10.Location = new System.Drawing.Point(263, 271);
      this.emgChart10.Name = "emgChart10";
      this.emgChart10.Size = new System.Drawing.Size(257, 64);
      this.emgChart10.TabIndex = 10;
      // 
      // emgChart9
      // 
      this.emgChart9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart9.Location = new System.Drawing.Point(3, 271);
      this.emgChart9.Name = "emgChart9";
      this.emgChart9.Size = new System.Drawing.Size(257, 64);
      this.emgChart9.TabIndex = 9;
      // 
      // emgChart8
      // 
      this.emgChart8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart8.Location = new System.Drawing.Point(263, 204);
      this.emgChart8.Name = "emgChart8";
      this.emgChart8.Size = new System.Drawing.Size(257, 64);
      this.emgChart8.TabIndex = 8;
      // 
      // emgChart7
      // 
      this.emgChart7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart7.Location = new System.Drawing.Point(3, 204);
      this.emgChart7.Name = "emgChart7";
      this.emgChart7.Size = new System.Drawing.Size(257, 64);
      this.emgChart7.TabIndex = 7;
      // 
      // emgChart6
      // 
      this.emgChart6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart6.Location = new System.Drawing.Point(263, 137);
      this.emgChart6.Name = "emgChart6";
      this.emgChart6.Size = new System.Drawing.Size(257, 64);
      this.emgChart6.TabIndex = 6;
      // 
      // emgChart5
      // 
      this.emgChart5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart5.Location = new System.Drawing.Point(3, 137);
      this.emgChart5.Name = "emgChart5";
      this.emgChart5.Size = new System.Drawing.Size(257, 64);
      this.emgChart5.TabIndex = 5;
      // 
      // emgChart4
      // 
      this.emgChart4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart4.Location = new System.Drawing.Point(263, 70);
      this.emgChart4.Name = "emgChart4";
      this.emgChart4.Size = new System.Drawing.Size(257, 64);
      this.emgChart4.TabIndex = 4;
      // 
      // emgChart3
      // 
      this.emgChart3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart3.Location = new System.Drawing.Point(3, 70);
      this.emgChart3.Name = "emgChart3";
      this.emgChart3.Size = new System.Drawing.Size(257, 64);
      this.emgChart3.TabIndex = 3;
      // 
      // emgChart2
      // 
      this.emgChart2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart2.Location = new System.Drawing.Point(263, 3);
      this.emgChart2.Name = "emgChart2";
      this.emgChart2.Size = new System.Drawing.Size(257, 64);
      this.emgChart2.TabIndex = 2;
      // 
      // emgChart1
      // 
      this.emgChart1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart1.Location = new System.Drawing.Point(3, 3);
      this.emgChart1.Name = "emgChart1";
      this.emgChart1.Size = new System.Drawing.Size(257, 64);
      this.emgChart1.TabIndex = 0;
      // 
      // sensorThumb
      // 
      this.sensorThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sensorThumb.Location = new System.Drawing.Point(349, 204);
      this.sensorThumb.Name = "sensorThumb";
      this.sensorThumb.Size = new System.Drawing.Size(25, 25);
      this.sensorThumb.TabIndex = 17;
      // 
      // sensorIndex
      // 
      this.sensorIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sensorIndex.Location = new System.Drawing.Point(257, 42);
      this.sensorIndex.Name = "sensorIndex";
      this.sensorIndex.Size = new System.Drawing.Size(25, 25);
      this.sensorIndex.TabIndex = 18;
      // 
      // sensorMiddle
      // 
      this.sensorMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sensorMiddle.Location = new System.Drawing.Point(158, 16);
      this.sensorMiddle.Name = "sensorMiddle";
      this.sensorMiddle.Size = new System.Drawing.Size(25, 25);
      this.sensorMiddle.TabIndex = 19;
      // 
      // sensorRing
      // 
      this.sensorRing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sensorRing.Location = new System.Drawing.Point(77, 51);
      this.sensorRing.Name = "sensorRing";
      this.sensorRing.Size = new System.Drawing.Size(25, 25);
      this.sensorRing.TabIndex = 20;
      // 
      // sensorPinky
      // 
      this.sensorPinky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sensorPinky.Location = new System.Drawing.Point(24, 124);
      this.sensorPinky.Name = "sensorPinky";
      this.sensorPinky.Size = new System.Drawing.Size(25, 25);
      this.sensorPinky.TabIndex = 21;
      // 
      // buttonScreenshot
      // 
      this.buttonScreenshot.Location = new System.Drawing.Point(322, 119);
      this.buttonScreenshot.Name = "buttonScreenshot";
      this.buttonScreenshot.Size = new System.Drawing.Size(75, 23);
      this.buttonScreenshot.TabIndex = 22;
      this.buttonScreenshot.Text = "Zrzut ekranu";
      this.buttonScreenshot.UseVisualStyleBackColor = true;
      this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
      // 
      // panelDebugConsole
      // 
      this.panelDebugConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelDebugConsole.Controls.Add(this.emgConsole);
      this.panelDebugConsole.Location = new System.Drawing.Point(6, 567);
      this.panelDebugConsole.Margin = new System.Windows.Forms.Padding(0);
      this.panelDebugConsole.Name = "panelDebugConsole";
      this.panelDebugConsole.Size = new System.Drawing.Size(930, 122);
      this.panelDebugConsole.TabIndex = 24;
      // 
      // emgConsole
      // 
      this.emgConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.emgConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.emgConsole.BackColor = System.Drawing.SystemColors.ControlText;
      this.emgConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.emgConsole.ForeColor = System.Drawing.Color.Lime;
      this.emgConsole.Location = new System.Drawing.Point(3, 3);
      this.emgConsole.Margin = new System.Windows.Forms.Padding(0);
      this.emgConsole.Name = "emgConsole";
      this.emgConsole.Size = new System.Drawing.Size(924, 116);
      this.emgConsole.TabIndex = 23;
      // 
      // panelCharts
      // 
      this.panelCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelCharts.AutoSize = true;
      this.panelCharts.Controls.Add(this.emgChart1);
      this.panelCharts.Controls.Add(this.emgChart2);
      this.panelCharts.Controls.Add(this.emgChart3);
      this.panelCharts.Controls.Add(this.emgChart4);
      this.panelCharts.Controls.Add(this.emgChart5);
      this.panelCharts.Controls.Add(this.emgChart6);
      this.panelCharts.Controls.Add(this.emgChart7);
      this.panelCharts.Controls.Add(this.emgChart8);
      this.panelCharts.Controls.Add(this.emgChart9);
      this.panelCharts.Controls.Add(this.emgChart10);
      this.panelCharts.Controls.Add(this.emgChart11);
      this.panelCharts.Controls.Add(this.emgChart12);
      this.panelCharts.Controls.Add(this.emgChart13);
      this.panelCharts.Controls.Add(this.emgChart14);
      this.panelCharts.Controls.Add(this.emgChart15);
      this.panelCharts.Controls.Add(this.emgChart16);
      this.panelCharts.Location = new System.Drawing.Point(6, 25);
      this.panelCharts.Name = "panelCharts";
      this.panelCharts.Size = new System.Drawing.Size(523, 539);
      this.panelCharts.TabIndex = 25;
      // 
      // panelSensors
      // 
      this.panelSensors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panelSensors.BackColor = System.Drawing.Color.Transparent;
      this.panelSensors.BackgroundImage = global::EMGtestGUI.Properties.Resources.EMGhandTemplateInvertedNoWrist;
      this.panelSensors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.panelSensors.Controls.Add(this.sensorThumb);
      this.panelSensors.Controls.Add(this.sensorIndex);
      this.panelSensors.Controls.Add(this.sensorMiddle);
      this.panelSensors.Controls.Add(this.sensorRing);
      this.panelSensors.Controls.Add(this.sensorPinky);
      this.panelSensors.Location = new System.Drawing.Point(536, 25);
      this.panelSensors.Name = "panelSensors";
      this.panelSensors.Size = new System.Drawing.Size(400, 373);
      this.panelSensors.TabIndex = 26;
      // 
      // panelButtons
      // 
      this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelButtons.Controls.Add(this.progressBarPauza);
      this.panelButtons.Controls.Add(this.progressBarPomiar);
      this.panelButtons.Controls.Add(this.buttonScreenshot);
      this.panelButtons.Location = new System.Drawing.Point(536, 404);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(400, 160);
      this.panelButtons.TabIndex = 27;
      // 
      // progressBarPauza
      // 
      this.progressBarPauza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarPauza.ForeColor = System.Drawing.Color.Lime;
      this.progressBarPauza.Location = new System.Drawing.Point(15, 81);
      this.progressBarPauza.Maximum = 250;
      this.progressBarPauza.Name = "progressBarPauza";
      this.progressBarPauza.Size = new System.Drawing.Size(371, 23);
      this.progressBarPauza.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBarPauza.TabIndex = 24;
      // 
      // progressBarPomiar
      // 
      this.progressBarPomiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarPomiar.ForeColor = System.Drawing.Color.Red;
      this.progressBarPomiar.Location = new System.Drawing.Point(15, 52);
      this.progressBarPomiar.Name = "progressBarPomiar";
      this.progressBarPomiar.Size = new System.Drawing.Size(371, 23);
      this.progressBarPomiar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBarPomiar.TabIndex = 23;
      // 
      // stripMenu
      // 
      this.stripMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.stripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.menuOpcje,
            this.menuPomoc});
      this.stripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
      this.stripMenu.Location = new System.Drawing.Point(0, 0);
      this.stripMenu.Name = "stripMenu";
      this.stripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.stripMenu.Size = new System.Drawing.Size(944, 21);
      this.stripMenu.TabIndex = 28;
      this.stripMenu.Text = "Menu";
      // 
      // menuMenu
      // 
      this.menuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemRejestruj,
            this.stripItemWyczysc});
      this.menuMenu.Name = "menuMenu";
      this.menuMenu.Size = new System.Drawing.Size(45, 17);
      this.menuMenu.Text = "Menu";
      // 
      // stripItemRejestruj
      // 
      this.stripItemRejestruj.Name = "stripItemRejestruj";
      this.stripItemRejestruj.Size = new System.Drawing.Size(118, 22);
      this.stripItemRejestruj.Text = "Rejestruj";
      // 
      // stripItemWyczysc
      // 
      this.stripItemWyczysc.Name = "stripItemWyczysc";
      this.stripItemWyczysc.Size = new System.Drawing.Size(118, 22);
      this.stripItemWyczysc.Text = "Wyczyść";
      this.stripItemWyczysc.Click += new System.EventHandler(this.stripItemWyczysc_Click);
      // 
      // menuOpcje
      // 
      this.menuOpcje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemUstawienia,
            this.stripItemSensory});
      this.menuOpcje.Name = "menuOpcje";
      this.menuOpcje.Size = new System.Drawing.Size(47, 17);
      this.menuOpcje.Text = "Opcje";
      // 
      // stripItemUstawienia
      // 
      this.stripItemUstawienia.Name = "stripItemUstawienia";
      this.stripItemUstawienia.Size = new System.Drawing.Size(152, 22);
      this.stripItemUstawienia.Text = "Ustawienia";
      // 
      // stripItemSensory
      // 
      this.stripItemSensory.Checked = true;
      this.stripItemSensory.CheckOnClick = true;
      this.stripItemSensory.CheckState = System.Windows.Forms.CheckState.Checked;
      this.stripItemSensory.Name = "stripItemSensory";
      this.stripItemSensory.Size = new System.Drawing.Size(152, 22);
      this.stripItemSensory.Text = "Sensory Nacisku";
      this.stripItemSensory.CheckedChanged += new System.EventHandler(this.stripItemSensory_CheckedChanged);
      // 
      // menuPomoc
      // 
      this.menuPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemHelp,
            this.stripItemAbout});
      this.menuPomoc.Name = "menuPomoc";
      this.menuPomoc.Size = new System.Drawing.Size(50, 17);
      this.menuPomoc.Text = "Pomoc";
      // 
      // stripItemHelp
      // 
      this.stripItemHelp.Name = "stripItemHelp";
      this.stripItemHelp.Size = new System.Drawing.Size(103, 22);
      this.stripItemHelp.Text = "Help";
      // 
      // stripItemAbout
      // 
      this.stripItemAbout.Name = "stripItemAbout";
      this.stripItemAbout.Size = new System.Drawing.Size(103, 22);
      this.stripItemAbout.Text = "About";
      // 
      // instantAiCtrl1
      // 
      this.instantAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl1._StateStream")));
      // 
      // EMGtestGUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(944, 696);
      this.Controls.Add(this.panelButtons);
      this.Controls.Add(this.panelSensors);
      this.Controls.Add(this.panelCharts);
      this.Controls.Add(this.panelDebugConsole);
      this.Controls.Add(this.stripMenu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.stripMenu;
      this.Name = "EMGtestGUI";
      this.Text = "EMGtestGUI";
      this.panelDebugConsole.ResumeLayout(false);
      this.panelCharts.ResumeLayout(false);
      this.panelSensors.ResumeLayout(false);
      this.panelButtons.ResumeLayout(false);
      this.stripMenu.ResumeLayout(false);
      this.stripMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timerTEST;
    private EMGchart emgChart1;
    private EMGchart emgChart2;
    private EMGchart emgChart3;
    private EMGchart emgChart4;
    private EMGchart emgChart5;
    private EMGchart emgChart6;
    private EMGchart emgChart7;
    private EMGchart emgChart8;
    private EMGchart emgChart9;
    private EMGchart emgChart10;
    private EMGchart emgChart11;
    private EMGchart emgChart12;
    private EMGchart emgChart13;
    private EMGchart emgChart14;
    private EMGchart emgChart15;
    private EMGchart emgChart16;
    private EMGforceSensor sensorThumb;
    private EMGforceSensor sensorIndex;
    private EMGforceSensor sensorMiddle;
    private EMGforceSensor sensorRing;
    private EMGforceSensor sensorPinky;
    private System.Windows.Forms.Button buttonScreenshot;
    private EMGdebugConsole emgConsole;
    private System.Windows.Forms.Panel panelDebugConsole;
    private System.Windows.Forms.Panel panelCharts;
    private System.Windows.Forms.Panel panelSensors;
    private System.Windows.Forms.Panel panelButtons;
    private System.Windows.Forms.ProgressBar progressBarPomiar;
    private System.Windows.Forms.ProgressBar progressBarPauza;
    private System.Windows.Forms.MenuStrip stripMenu;
    private System.Windows.Forms.ToolStripMenuItem menuMenu;
    private System.Windows.Forms.ToolStripMenuItem menuPomoc;
    private System.Windows.Forms.ToolStripMenuItem stripItemRejestruj;
    private System.Windows.Forms.ToolStripMenuItem menuOpcje;
    private System.Windows.Forms.ToolStripMenuItem stripItemHelp;
    private System.Windows.Forms.ToolStripMenuItem stripItemAbout;
    private System.Windows.Forms.ToolStripMenuItem stripItemUstawienia;
    private System.Windows.Forms.ToolStripMenuItem stripItemWyczysc;
    private System.Windows.Forms.ToolStripMenuItem stripItemSensory;

    // private Automation.BDaq.BufferedAiCtrl bufferedAiCtrl1;
    private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
  }
}