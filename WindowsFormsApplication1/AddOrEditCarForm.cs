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


      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
//DataGridView
//Dodaj, Edytuj, Usuń