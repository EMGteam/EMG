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
      this.buttonScreenshot = new System.Windows.Forms.Button();
      this.panelDebugConsole = new System.Windows.Forms.Panel();
      this.emgConsole = new EMG.EMGdebugConsole();
      this.panelCharts = new System.Windows.Forms.Panel();
      this.panelSensors = new System.Windows.Forms.Panel();
      this.emGforceSensor24 = new EMG.EMGforceSensor();
      this.emGforceSensor23 = new EMG.EMGforceSensor();
      this.emGforceSensor22 = new EMG.EMGforceSensor();
      this.emGforceSensor21 = new EMG.EMGforceSensor();
      this.emGforceSensor20 = new EMG.EMGforceSensor();
      this.emGforceSensor19 = new EMG.EMGforceSensor();
      this.emGforceSensor18 = new EMG.EMGforceSensor();
      this.emGforceSensor17 = new EMG.EMGforceSensor();
      this.emGforceSensor16 = new EMG.EMGforceSensor();
      this.emGforceSensor15 = new EMG.EMGforceSensor();
      this.emGforceSensor14 = new EMG.EMGforceSensor();
      this.emGforceSensor13 = new EMG.EMGforceSensor();
      this.emGforceSensor12 = new EMG.EMGforceSensor();
      this.emGforceSensor11 = new EMG.EMGforceSensor();
      this.emGforceSensor10 = new EMG.EMGforceSensor();
      this.emGforceSensor9 = new EMG.EMGforceSensor();
      this.emGforceSensor8 = new EMG.EMGforceSensor();
      this.emGforceSensor7 = new EMG.EMGforceSensor();
      this.emGforceSensor6 = new EMG.EMGforceSensor();
      this.emGforceSensor5 = new EMG.EMGforceSensor();
      this.emGforceSensor4 = new EMG.EMGforceSensor();
      this.emGforceSensor3 = new EMG.EMGforceSensor();
      this.emGforceSensor2 = new EMG.EMGforceSensor();
      this.emGforceSensor1 = new EMG.EMGforceSensor();
      this.panelButtons = new System.Windows.Forms.Panel();
      this.StartButton = new System.Windows.Forms.Button();
      this.folderNameLabel = new System.Windows.Forms.Label();
      this.PauseTimeLabel = new System.Windows.Forms.Label();
      this.dataPerMeasurmentLabel = new System.Windows.Forms.Label();
      this.PauseTimeTextBox = new System.Windows.Forms.TextBox();
      this.dataPerMeasurmentTextBox = new System.Windows.Forms.TextBox();
      this.folderNameTextBox = new System.Windows.Forms.TextBox();
      this.progressBarPauza = new System.Windows.Forms.ProgressBar();
      this.progressBarPomiar = new System.Windows.Forms.ProgressBar();
      this.stripMenu = new System.Windows.Forms.MenuStrip();
      this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemRejestruj = new System.Windows.Forms.ToolStripMenuItem();
      this.stripItemWyczysc = new System.Windows.Forms.ToolStripMenuItem();
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
      this.emgChart16.CurrentMaxValue = 6F;
      this.emgChart16.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart16.Location = new System.Drawing.Point(263, 472);
      this.emgChart16.Name = "emgChart16";
      this.emgChart16.Size = new System.Drawing.Size(257, 64);
      this.emgChart16.TabIndex = 16;
      // 
      // emgChart15
      // 
      this.emgChart15.CurrentMaxValue = 6F;
      this.emgChart15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart15.Location = new System.Drawing.Point(3, 472);
      this.emgChart15.Name = "emgChart15";
      this.emgChart15.Size = new System.Drawing.Size(257, 64);
      this.emgChart15.TabIndex = 15;
      // 
      // emgChart14
      // 
      this.emgChart14.CurrentMaxValue = 6F;
      this.emgChart14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart14.Location = new System.Drawing.Point(263, 405);
      this.emgChart14.Name = "emgChart14";
      this.emgChart14.Size = new System.Drawing.Size(257, 64);
      this.emgChart14.TabIndex = 14;
      // 
      // emgChart13
      // 
      this.emgChart13.CurrentMaxValue = 6F;
      this.emgChart13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart13.Location = new System.Drawing.Point(3, 405);
      this.emgChart13.Name = "emgChart13";
      this.emgChart13.Size = new System.Drawing.Size(257, 64);
      this.emgChart13.TabIndex = 13;
      // 
      // emgChart12
      // 
      this.emgChart12.CurrentMaxValue = 6F;
      this.emgChart12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart12.Location = new System.Drawing.Point(263, 338);
      this.emgChart12.Name = "emgChart12";
      this.emgChart12.Size = new System.Drawing.Size(257, 64);
      this.emgChart12.TabIndex = 12;
      // 
      // emgChart11
      // 
      this.emgChart11.CurrentMaxValue = 6F;
      this.emgChart11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart11.Location = new System.Drawing.Point(3, 338);
      this.emgChart11.Name = "emgChart11";
      this.emgChart11.Size = new System.Drawing.Size(257, 64);
      this.emgChart11.TabIndex = 11;
      // 
      // emgChart10
      // 
      this.emgChart10.CurrentMaxValue = 6F;
      this.emgChart10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart10.Location = new System.Drawing.Point(263, 271);
      this.emgChart10.Name = "emgChart10";
      this.emgChart10.Size = new System.Drawing.Size(257, 64);
      this.emgChart10.TabIndex = 10;
      // 
      // emgChart9
      // 
      this.emgChart9.CurrentMaxValue = 6F;
      this.emgChart9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart9.Location = new System.Drawing.Point(3, 271);
      this.emgChart9.Name = "emgChart9";
      this.emgChart9.Size = new System.Drawing.Size(257, 64);
      this.emgChart9.TabIndex = 9;
      // 
      // emgChart8
      // 
      this.emgChart8.CurrentMaxValue = 6F;
      this.emgChart8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart8.Location = new System.Drawing.Point(263, 204);
      this.emgChart8.Name = "emgChart8";
      this.emgChart8.Size = new System.Drawing.Size(257, 64);
      this.emgChart8.TabIndex = 8;
      // 
      // emgChart7
      // 
      this.emgChart7.CurrentMaxValue = 6F;
      this.emgChart7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart7.Location = new System.Drawing.Point(3, 204);
      this.emgChart7.Name = "emgChart7";
      this.emgChart7.Size = new System.Drawing.Size(257, 64);
      this.emgChart7.TabIndex = 7;
      // 
      // emgChart6
      // 
      this.emgChart6.CurrentMaxValue = 6F;
      this.emgChart6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart6.Location = new System.Drawing.Point(263, 137);
      this.emgChart6.Name = "emgChart6";
      this.emgChart6.Size = new System.Drawing.Size(257, 64);
      this.emgChart6.TabIndex = 6;
      // 
      // emgChart5
      // 
      this.emgChart5.CurrentMaxValue = 6F;
      this.emgChart5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart5.Location = new System.Drawing.Point(3, 137);
      this.emgChart5.Name = "emgChart5";
      this.emgChart5.Size = new System.Drawing.Size(257, 64);
      this.emgChart5.TabIndex = 5;
      // 
      // emgChart4
      // 
      this.emgChart4.CurrentMaxValue = 6F;
      this.emgChart4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart4.Location = new System.Drawing.Point(263, 70);
      this.emgChart4.Name = "emgChart4";
      this.emgChart4.Size = new System.Drawing.Size(257, 64);
      this.emgChart4.TabIndex = 4;
      // 
      // emgChart3
      // 
      this.emgChart3.CurrentMaxValue = 6F;
      this.emgChart3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart3.Location = new System.Drawing.Point(3, 70);
      this.emgChart3.Name = "emgChart3";
      this.emgChart3.Size = new System.Drawing.Size(257, 64);
      this.emgChart3.TabIndex = 3;
      // 
      // emgChart2
      // 
      this.emgChart2.CurrentMaxValue = 6F;
      this.emgChart2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart2.Location = new System.Drawing.Point(263, 3);
      this.emgChart2.Name = "emgChart2";
      this.emgChart2.Size = new System.Drawing.Size(257, 64);
      this.emgChart2.TabIndex = 2;
      // 
      // emgChart1
      // 
      this.emgChart1.CurrentMaxValue = 6F;
      this.emgChart1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.emgChart1.Location = new System.Drawing.Point(3, 3);
      this.emgChart1.Name = "emgChart1";
      this.emgChart1.Size = new System.Drawing.Size(257, 64);
      this.emgChart1.TabIndex = 0;
      // 
      // buttonScreenshot
      // 
      this.buttonScreenshot.Location = new System.Drawing.Point(311, 119);
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
      this.panelSensors.Controls.Add(this.emGforceSensor24);
      this.panelSensors.Controls.Add(this.emGforceSensor23);
      this.panelSensors.Controls.Add(this.emGforceSensor22);
      this.panelSensors.Controls.Add(this.emGforceSensor21);
      this.panelSensors.Controls.Add(this.emGforceSensor20);
      this.panelSensors.Controls.Add(this.emGforceSensor19);
      this.panelSensors.Controls.Add(this.emGforceSensor18);
      this.panelSensors.Controls.Add(this.emGforceSensor17);
      this.panelSensors.Controls.Add(this.emGforceSensor16);
      this.panelSensors.Controls.Add(this.emGforceSensor15);
      this.panelSensors.Controls.Add(this.emGforceSensor14);
      this.panelSensors.Controls.Add(this.emGforceSensor13);
      this.panelSensors.Controls.Add(this.emGforceSensor12);
      this.panelSensors.Controls.Add(this.emGforceSensor11);
      this.panelSensors.Controls.Add(this.emGforceSensor10);
      this.panelSensors.Controls.Add(this.emGforceSensor9);
      this.panelSensors.Controls.Add(this.emGforceSensor8);
      this.panelSensors.Controls.Add(this.emGforceSensor7);
      this.panelSensors.Controls.Add(this.emGforceSensor6);
      this.panelSensors.Controls.Add(this.emGforceSensor5);
      this.panelSensors.Controls.Add(this.emGforceSensor4);
      this.panelSensors.Controls.Add(this.emGforceSensor3);
      this.panelSensors.Controls.Add(this.emGforceSensor2);
      this.panelSensors.Controls.Add(this.emGforceSensor1);
      this.panelSensors.Location = new System.Drawing.Point(536, 25);
      this.panelSensors.Name = "panelSensors";
      this.panelSensors.Size = new System.Drawing.Size(400, 373);
      this.panelSensors.TabIndex = 26;
      // 
      // emGforceSensor24
      // 
      this.emGforceSensor24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor24.Location = new System.Drawing.Point(15, 121);
      this.emGforceSensor24.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor24.Name = "emGforceSensor24";
      this.emGforceSensor24.Size = new System.Drawing.Size(38, 39);
      this.emGforceSensor24.TabIndex = 26;
      // 
      // emGforceSensor23
      // 
      this.emGforceSensor23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor23.Location = new System.Drawing.Point(58, 194);
      this.emGforceSensor23.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor23.Name = "emGforceSensor23";
      this.emGforceSensor23.Size = new System.Drawing.Size(30, 34);
      this.emGforceSensor23.TabIndex = 25;
      // 
      // emGforceSensor22
      // 
      this.emGforceSensor22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor22.Location = new System.Drawing.Point(15, 102);
      this.emGforceSensor22.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor22.Name = "emGforceSensor22";
      this.emGforceSensor22.Size = new System.Drawing.Size(10, 153);
      this.emGforceSensor22.TabIndex = 24;
      // 
      // emGforceSensor21
      // 
      this.emGforceSensor21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor21.Location = new System.Drawing.Point(277, 70);
      this.emGforceSensor21.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor21.Name = "emGforceSensor21";
      this.emGforceSensor21.Size = new System.Drawing.Size(20, 43);
      this.emGforceSensor21.TabIndex = 23;
      // 
      // emGforceSensor20
      // 
      this.emGforceSensor20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor20.Location = new System.Drawing.Point(277, 34);
      this.emGforceSensor20.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor20.Name = "emGforceSensor20";
      this.emGforceSensor20.Size = new System.Drawing.Size(19, 34);
      this.emGforceSensor20.TabIndex = 22;
      // 
      // emGforceSensor19
      // 
      this.emGforceSensor19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor19.Location = new System.Drawing.Point(240, 26);
      this.emGforceSensor19.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor19.Name = "emGforceSensor19";
      this.emGforceSensor19.Size = new System.Drawing.Size(38, 35);
      this.emGforceSensor19.TabIndex = 21;
      // 
      // emGforceSensor18
      // 
      this.emGforceSensor18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor18.Location = new System.Drawing.Point(240, 204);
      this.emGforceSensor18.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor18.Name = "emGforceSensor18";
      this.emGforceSensor18.Size = new System.Drawing.Size(38, 35);
      this.emGforceSensor18.TabIndex = 20;
      // 
      // emGforceSensor17
      // 
      this.emGforceSensor17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor17.Location = new System.Drawing.Point(240, 138);
      this.emGforceSensor17.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor17.Name = "emGforceSensor17";
      this.emGforceSensor17.Size = new System.Drawing.Size(38, 38);
      this.emGforceSensor17.TabIndex = 19;
      // 
      // emGforceSensor16
      // 
      this.emGforceSensor16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor16.Location = new System.Drawing.Point(227, 26);
      this.emGforceSensor16.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor16.Name = "emGforceSensor16";
      this.emGforceSensor16.Size = new System.Drawing.Size(11, 150);
      this.emGforceSensor16.TabIndex = 18;
      // 
      // emGforceSensor15
      // 
      this.emGforceSensor15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor15.Location = new System.Drawing.Point(256, 281);
      this.emGforceSensor15.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor15.Name = "emGforceSensor15";
      this.emGforceSensor15.Size = new System.Drawing.Size(41, 38);
      this.emGforceSensor15.TabIndex = 17;
      // 
      // emGforceSensor14
      // 
      this.emGforceSensor14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor14.Location = new System.Drawing.Point(240, 321);
      this.emGforceSensor14.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor14.Name = "emGforceSensor14";
      this.emGforceSensor14.Size = new System.Drawing.Size(36, 34);
      this.emGforceSensor14.TabIndex = 16;
      // 
      // emGforceSensor13
      // 
      this.emGforceSensor13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor13.Location = new System.Drawing.Point(204, 257);
      this.emGforceSensor13.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor13.Name = "emGforceSensor13";
      this.emGforceSensor13.Size = new System.Drawing.Size(182, 11);
      this.emGforceSensor13.TabIndex = 15;
      // 
      // emGforceSensor12
      // 
      this.emGforceSensor12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor12.Location = new System.Drawing.Point(110, 157);
      this.emGforceSensor12.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor12.Name = "emGforceSensor12";
      this.emGforceSensor12.Size = new System.Drawing.Size(43, 31);
      this.emGforceSensor12.TabIndex = 14;
      // 
      // emGforceSensor11
      // 
      this.emGforceSensor11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor11.Location = new System.Drawing.Point(68, 48);
      this.emGforceSensor11.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor11.Name = "emGforceSensor11";
      this.emGforceSensor11.Size = new System.Drawing.Size(40, 35);
      this.emGforceSensor11.TabIndex = 13;
      // 
      // emGforceSensor10
      // 
      this.emGforceSensor10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor10.Location = new System.Drawing.Point(110, 48);
      this.emGforceSensor10.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor10.Name = "emGforceSensor10";
      this.emGforceSensor10.Size = new System.Drawing.Size(10, 153);
      this.emGforceSensor10.TabIndex = 12;
      // 
      // emGforceSensor9
      // 
      this.emGforceSensor9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor9.Location = new System.Drawing.Point(155, 3);
      this.emGforceSensor9.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor9.Name = "emGforceSensor9";
      this.emGforceSensor9.Size = new System.Drawing.Size(35, 31);
      this.emGforceSensor9.TabIndex = 11;
      // 
      // emGforceSensor8
      // 
      this.emGforceSensor8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor8.Location = new System.Drawing.Point(168, 126);
      this.emGforceSensor8.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor8.Name = "emGforceSensor8";
      this.emGforceSensor8.Size = new System.Drawing.Size(36, 34);
      this.emGforceSensor8.TabIndex = 10;
      // 
      // emGforceSensor7
      // 
      this.emGforceSensor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor7.Location = new System.Drawing.Point(155, 3);
      this.emGforceSensor7.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor7.Name = "emGforceSensor7";
      this.emGforceSensor7.Size = new System.Drawing.Size(11, 173);
      this.emGforceSensor7.TabIndex = 9;
      // 
      // emGforceSensor6
      // 
      this.emGforceSensor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor6.Location = new System.Drawing.Point(312, 285);
      this.emGforceSensor6.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor6.Name = "emGforceSensor6";
      this.emGforceSensor6.Size = new System.Drawing.Size(11, 62);
      this.emGforceSensor6.TabIndex = 8;
      // 
      // emGforceSensor5
      // 
      this.emGforceSensor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor5.Location = new System.Drawing.Point(312, 230);
      this.emGforceSensor5.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor5.Name = "emGforceSensor5";
      this.emGforceSensor5.Size = new System.Drawing.Size(45, 25);
      this.emGforceSensor5.TabIndex = 7;
      // 
      // emGforceSensor4
      // 
      this.emGforceSensor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor4.Location = new System.Drawing.Point(346, 204);
      this.emGforceSensor4.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor4.Name = "emGforceSensor4";
      this.emGforceSensor4.Size = new System.Drawing.Size(40, 24);
      this.emGforceSensor4.TabIndex = 6;
      // 
      // emGforceSensor3
      // 
      this.emGforceSensor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor3.Location = new System.Drawing.Point(110, 321);
      this.emGforceSensor3.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor3.Name = "emGforceSensor3";
      this.emGforceSensor3.Size = new System.Drawing.Size(43, 36);
      this.emGforceSensor3.TabIndex = 5;
      // 
      // emGforceSensor2
      // 
      this.emGforceSensor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor2.Location = new System.Drawing.Point(99, 285);
      this.emGforceSensor2.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor2.Name = "emGforceSensor2";
      this.emGforceSensor2.Size = new System.Drawing.Size(43, 34);
      this.emGforceSensor2.TabIndex = 4;
      // 
      // emGforceSensor1
      // 
      this.emGforceSensor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emGforceSensor1.Location = new System.Drawing.Point(78, 230);
      this.emGforceSensor1.Margin = new System.Windows.Forms.Padding(1);
      this.emGforceSensor1.Name = "emGforceSensor1";
      this.emGforceSensor1.Size = new System.Drawing.Size(160, 24);
      this.emGforceSensor1.TabIndex = 3;
      // 
      // panelButtons
      // 
      this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelButtons.Controls.Add(this.StartButton);
      this.panelButtons.Controls.Add(this.folderNameLabel);
      this.panelButtons.Controls.Add(this.PauseTimeLabel);
      this.panelButtons.Controls.Add(this.dataPerMeasurmentLabel);
      this.panelButtons.Controls.Add(this.PauseTimeTextBox);
      this.panelButtons.Controls.Add(this.dataPerMeasurmentTextBox);
      this.panelButtons.Controls.Add(this.folderNameTextBox);
      this.panelButtons.Controls.Add(this.progressBarPauza);
      this.panelButtons.Controls.Add(this.progressBarPomiar);
      this.panelButtons.Controls.Add(this.buttonScreenshot);
      this.panelButtons.Location = new System.Drawing.Point(536, 404);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(400, 160);
      this.panelButtons.TabIndex = 27;
      // 
      // StartButton
      // 
      this.StartButton.Location = new System.Drawing.Point(13, 119);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(116, 23);
      this.StartButton.TabIndex = 31;
      this.StartButton.Text = "Rozpocznij pomiar";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // folderNameLabel
      // 
      this.folderNameLabel.AutoSize = true;
      this.folderNameLabel.Location = new System.Drawing.Point(201, 74);
      this.folderNameLabel.Name = "folderNameLabel";
      this.folderNameLabel.Size = new System.Drawing.Size(78, 13);
      this.folderNameLabel.TabIndex = 30;
      this.folderNameLabel.Text = "Ścieżka zapisu";
      // 
      // PauseTimeLabel
      // 
      this.PauseTimeLabel.AutoSize = true;
      this.PauseTimeLabel.Location = new System.Drawing.Point(112, 74);
      this.PauseTimeLabel.Name = "PauseTimeLabel";
      this.PauseTimeLabel.Size = new System.Drawing.Size(83, 13);
      this.PauseTimeLabel.TabIndex = 29;
      this.PauseTimeLabel.Text = "Czas pauzy (ms)";
      // 
      // dataPerMeasurmentLabel
      // 
      this.dataPerMeasurmentLabel.AutoSize = true;
      this.dataPerMeasurmentLabel.Location = new System.Drawing.Point(15, 74);
      this.dataPerMeasurmentLabel.Name = "dataPerMeasurmentLabel";
      this.dataPerMeasurmentLabel.Size = new System.Drawing.Size(92, 13);
      this.dataPerMeasurmentLabel.TabIndex = 28;
      this.dataPerMeasurmentLabel.Text = "Czas pomiaru (ms)";
      // 
      // PauseTimeTextBox
      // 
      this.PauseTimeTextBox.Location = new System.Drawing.Point(113, 93);
      this.PauseTimeTextBox.Name = "PauseTimeTextBox";
      this.PauseTimeTextBox.Size = new System.Drawing.Size(82, 20);
      this.PauseTimeTextBox.TabIndex = 27;
      // 
      // dataPerMeasurmentTextBox
      // 
      this.dataPerMeasurmentTextBox.Location = new System.Drawing.Point(15, 93);
      this.dataPerMeasurmentTextBox.Name = "dataPerMeasurmentTextBox";
      this.dataPerMeasurmentTextBox.Size = new System.Drawing.Size(92, 20);
      this.dataPerMeasurmentTextBox.TabIndex = 26;
      // 
      // folderNameTextBox
      // 
      this.folderNameTextBox.Location = new System.Drawing.Point(204, 93);
      this.folderNameTextBox.Name = "folderNameTextBox";
      this.folderNameTextBox.Size = new System.Drawing.Size(182, 20);
      this.folderNameTextBox.TabIndex = 25;
      // 
      // progressBarPauza
      // 
      this.progressBarPauza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarPauza.ForeColor = System.Drawing.Color.Lime;
      this.progressBarPauza.Location = new System.Drawing.Point(15, 44);
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
      this.progressBarPomiar.Location = new System.Drawing.Point(15, 15);
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
      this.panelButtons.PerformLayout();
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
    private System.Windows.Forms.ToolStripMenuItem stripItemHelp;
    private System.Windows.Forms.ToolStripMenuItem stripItemAbout;
    private System.Windows.Forms.ToolStripMenuItem stripItemWyczysc;

    // private Automation.BDaq.BufferedAiCtrl bufferedAiCtrl1;
    private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
    private EMGforceSensor emGforceSensor24;
    private EMGforceSensor emGforceSensor23;
    private EMGforceSensor emGforceSensor22;
    private EMGforceSensor emGforceSensor21;
    private EMGforceSensor emGforceSensor20;
    private EMGforceSensor emGforceSensor19;
    private EMGforceSensor emGforceSensor18;
    private EMGforceSensor emGforceSensor17;
    private EMGforceSensor emGforceSensor16;
    private EMGforceSensor emGforceSensor15;
    private EMGforceSensor emGforceSensor14;
    private EMGforceSensor emGforceSensor13;
    private EMGforceSensor emGforceSensor12;
    private EMGforceSensor emGforceSensor11;
    private EMGforceSensor emGforceSensor10;
    private EMGforceSensor emGforceSensor9;
    private EMGforceSensor emGforceSensor8;
    private EMGforceSensor emGforceSensor7;
    private EMGforceSensor emGforceSensor6;
    private EMGforceSensor emGforceSensor5;
    private EMGforceSensor emGforceSensor4;
    private EMGforceSensor emGforceSensor3;
    private EMGforceSensor emGforceSensor2;
    private EMGforceSensor emGforceSensor1;
    private System.Windows.Forms.Label folderNameLabel;
    private System.Windows.Forms.Label PauseTimeLabel;
    private System.Windows.Forms.Label dataPerMeasurmentLabel;
    private System.Windows.Forms.TextBox PauseTimeTextBox;
    private System.Windows.Forms.TextBox dataPerMeasurmentTextBox;
    private System.Windows.Forms.TextBox folderNameTextBox;
    private System.Windows.Forms.Button StartButton;
  }
}