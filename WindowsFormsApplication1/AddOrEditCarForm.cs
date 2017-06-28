using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public partial class AddOrEditCarForm : Form
  {
    public AddOrEditCarForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var car1 = new Car();
      // bool isWorking = false;
      car1.Model = textBoxName.Text;
      car1.ManufacturingYear = (int)numericUpDownYear.Value;
      

      /* if (bool.TryParse(textBoxIsWorking.Text, out isWorking) == false)
      {
        MessageBox.Show("Wpisz prawidłową wartość dla ostatniego pola!");

        return;
      }
      car1.IsWorking = isWorking;
	  */

      textBoxInfo.Text = "Nazwa: " + car1.Model + ", Rok produkcji: " + car1.ManufacturingYear;
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
  }
}
//DataGridView
//Dodaj, Edytuj, Usuń