namespace EMG
{
  partial class EMGdebugConsole
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

    #region Kod wygenerowany przez Projektanta składników

    /// <summary>
    /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
    /// zawartość tej metody z edytorem kodu.
    /// </summary>
    private void InitializeComponent()
    {
      this.consoleTextBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // consoleTextBox
      // 
      this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top 
            | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.consoleTextBox.BackColor = System.Drawing.SystemColors.WindowText;
      this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.consoleTextBox.Font = new System.Drawing.Font("Consolas", 8F);
      this.consoleTextBox.ForeColor = System.Drawing.Color.Lime;
      this.consoleTextBox.Location = new System.Drawing.Point(3, 3);
      this.consoleTextBox.Name = "consoleTextBox";
      this.consoleTextBox.Size = new System.Drawing.Size(309, 210);
      this.consoleTextBox.TabIndex = 0;
      this.consoleTextBox.Text = "";
      this.consoleTextBox.TextChanged += new System.EventHandler(this.consoleTextBox_AnyEvent);
      this.consoleTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.consoleTextBox_AnyMouseEvent);
      this.consoleTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.consoleTextBox_AnyMouseEvent);
      this.consoleTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.consoleTextBox_AnyMouseEvent);
      this.consoleTextBox.Click += new System.EventHandler(this.consoleTextBox_AnyEvent);
      this.consoleTextBox.CursorChanged += new System.EventHandler(this.consoleTextBox_AnyEvent);
      this.consoleTextBox.Enter += new System.EventHandler(this.consoleTextBox_AnyEvent);
      this.consoleTextBox.GotFocus += new System.EventHandler(this.consoleTextBox_AnyEvent);
      this.consoleTextBox.Resize += new System.EventHandler(this.consoleTextBox_AnyEvent);
      // 
      // EMGdebugConsole
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlText;
      this.Controls.Add(this.consoleTextBox);
      this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.ForeColor = System.Drawing.Color.Lime;
      this.Name = "EMGdebugConsole";
      this.Size = new System.Drawing.Size(315, 216);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox consoleTextBox;
  }
}
