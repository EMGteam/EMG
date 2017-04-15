namespace EMG
{
  partial class EMGchart
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
      this.components = new System.ComponentModel.Container();
      this.redrawTimer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // redrawTimer
      // 
      this.redrawTimer.Interval = 50;
      this.redrawTimer.Tick += new System.EventHandler(this.redrawTimer_Tick);
      // 
      // EMGchart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "EMGchart";
      this.Size = new System.Drawing.Size(257, 64);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer redrawTimer;
  }
}
