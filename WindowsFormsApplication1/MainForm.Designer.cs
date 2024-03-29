﻿namespace WindowsFormsApplication1
{
  partial class MainFormRegistryOfCarInspections
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
      this.buttonRemove = new System.Windows.Forms.Button();
      this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ManufacturingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewCars
      // 
      this.dataGridViewCars.AllowUserToAddRows = false;
      this.dataGridViewCars.AllowUserToDeleteRows = false;
      this.dataGridViewCars.AllowUserToResizeRows = false;
      this.dataGridViewCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.ManufacturingYear});
      this.dataGridViewCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.dataGridViewCars.Location = new System.Drawing.Point(12, 26);
      this.dataGridViewCars.MultiSelect = false;
      this.dataGridViewCars.Name = "dataGridViewCars";
      this.dataGridViewCars.ReadOnly = true;
      this.dataGridViewCars.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.dataGridViewCars.RowHeadersVisible = false;
      this.dataGridViewCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewCars.ShowCellToolTips = false;
      this.dataGridViewCars.Size = new System.Drawing.Size(974, 315);
      this.dataGridViewCars.TabIndex = 0;
      this.dataGridViewCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellContentClick);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(12, 376);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 1;
      this.buttonAdd.Text = "Dodaj";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(143, 376);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(75, 23);
      this.buttonEdit.TabIndex = 2;
      this.buttonEdit.Text = "Edytuj";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // buttonRemove
      // 
      this.buttonRemove.Location = new System.Drawing.Point(273, 376);
      this.buttonRemove.Name = "buttonRemove";
      this.buttonRemove.Size = new System.Drawing.Size(75, 23);
      this.buttonRemove.TabIndex = 3;
      this.buttonRemove.Text = "Usuń";
      this.buttonRemove.UseVisualStyleBackColor = true;
      this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
      // 
      // Model
      // 
      this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Model.DataPropertyName = "Model";
      this.Model.HeaderText = "Model";
      this.Model.Name = "Model";
      this.Model.ReadOnly = true;
      this.Model.Width = 61;
      // 
      // ManufacturingYear
      // 
      this.ManufacturingYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ManufacturingYear.DataPropertyName = "ManufacturingYear";
      this.ManufacturingYear.HeaderText = "Rok produkcji";
      this.ManufacturingYear.Name = "ManufacturingYear";
      this.ManufacturingYear.ReadOnly = true;
      this.ManufacturingYear.Width = 98;
      // 
      // MainFormRegistryOfCarInspections
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(998, 426);
      this.Controls.Add(this.buttonRemove);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.dataGridViewCars);
      this.Name = "MainFormRegistryOfCarInspections";
      this.ShowInTaskbar = false;
      this.Text = "Rejestr wykonanych przeglądów samochodowych";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonRemove;
		protected System.Windows.Forms.DataGridView dataGridViewCars;
    private System.Windows.Forms.DataGridViewTextBoxColumn Model;
    private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturingYear;
  }
}