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
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.buttonRemowe = new System.Windows.Forms.Button();
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
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(12, 376);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 1;
      this.buttonAdd.Text = "Dodaj";
      this.buttonAdd.UseVisualStyleBackColor = true;
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(143, 376);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(75, 23);
      this.buttonEdit.TabIndex = 2;
      this.buttonEdit.Text = "Edytuj";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.button1_Click);
      // 
      // buttonRemowe
      // 
      this.buttonRemowe.Location = new System.Drawing.Point(273, 376);
      this.buttonRemowe.Name = "buttonRemowe";
      this.buttonRemowe.Size = new System.Drawing.Size(75, 23);
      this.buttonRemowe.TabIndex = 3;
      this.buttonRemowe.Text = "Usuń";
      this.buttonRemowe.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(998, 566);
      this.Controls.Add(this.buttonRemowe);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.dataGridViewCars);
      this.Name = "MainForm";
      this.Text = "TUTAJ MASZ WPISAC NAZWE PROGRAMU";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewCars;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonRemowe;
  }
}