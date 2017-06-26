namespace WindowsFormsApplication1
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataGridViewCars = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewCars
      // 
      this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCars.Location = new System.Drawing.Point(12, 12);
      this.dataGridViewCars.Name = "dataGridViewCars";
      this.dataGridViewCars.Size = new System.Drawing.Size(974, 315);
      this.dataGridViewCars.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(998, 566);
      this.Controls.Add(this.dataGridViewCars);
      this.Name = "MainForm";
      this.Text = "TUTAJ MASZ WPISAC NAZWE PROGRAMU";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewCars;
  }
}