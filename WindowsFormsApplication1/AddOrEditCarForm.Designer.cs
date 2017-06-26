namespace WindowsFormsApplication1
{
  partial class AddOrEditCarForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxInfo = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.isWorking = new System.Windows.Forms.CheckBox();
      this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.button1.Location = new System.Drawing.Point(49, 109);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(118, 13);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(100, 20);
      this.textBoxName.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nazwa";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Rok produkcji";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Działa";
      // 
      // textBoxInfo
      // 
      this.textBoxInfo.Location = new System.Drawing.Point(7, 153);
      this.textBoxInfo.Multiline = true;
      this.textBoxInfo.Name = "textBoxInfo";
      this.textBoxInfo.Size = new System.Drawing.Size(265, 96);
      this.textBoxInfo.TabIndex = 7;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(168, 109);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 8;
      this.button2.Text = "Wyczyść";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // isWorking
      // 
      this.isWorking.AutoSize = true;
      this.isWorking.Location = new System.Drawing.Point(118, 72);
      this.isWorking.Name = "isWorking";
      this.isWorking.Size = new System.Drawing.Size(15, 14);
      this.isWorking.TabIndex = 9;
      this.isWorking.UseVisualStyleBackColor = true;
      // 
      // numericUpDownYear
      // 
      this.numericUpDownYear.Location = new System.Drawing.Point(118, 46);
      this.numericUpDownYear.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
      this.numericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
      this.numericUpDownYear.Name = "numericUpDownYear";
      this.numericUpDownYear.Size = new System.Drawing.Size(120, 20);
      this.numericUpDownYear.TabIndex = 10;
      this.numericUpDownYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.numericUpDownYear);
      this.Controls.Add(this.isWorking);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.textBoxInfo);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxInfo;
    private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox isWorking;
    private System.Windows.Forms.NumericUpDown numericUpDownYear;
  }
}

