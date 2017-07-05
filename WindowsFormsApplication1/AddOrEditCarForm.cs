using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public partial class AddOrEditCarForm : Form
  {
    public Car Car { get; set; }

    public AddOrEditCarForm()
    {
      InitializeComponent();
      Car = new Car();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBoxInfo.Clear();
    }

    private void AddOrEditCarForm_Load(object sender, EventArgs e)
    {

    }

    private void LabelBrand_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
		  Car.Model = textBoxName.Text;
		  Car.Brand = textBoxBrand.Text;
		  Car.EngineCapacity = numericUpDownEngine.Value;
		  Car.ManufacturingYear = (int)numericUpDownYear.Value;
		  Car.LastTechnicalReviewDate = dateTimePicker1.Value.Date;
		  Car.ReceivedDate = DateTime.Today;
		  Car.WhatToDo = textBoxInfo.Text;

		  DialogResult = DialogResult.OK;
		  Close();
    }

    public DialogResult ShowDialog(Car car)
    {
      textBoxName.Text = car.Model;
      textBoxBrand.Text = car.Brand;
      numericUpDownEngine.Value = car.EngineCapacity;
      numericUpDownYear.Value = car.ManufacturingYear;
	  dateTimePicker1.Value = car.LastTechnicalReviewDate;
      textBoxInfo.Text = car.WhatToDo;

      return base.ShowDialog();
    }
  }
}
