using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public partial class MainFormRegistryOfCarInspections : Form
  {
    private BindingList<Car> _cars = new BindingList<Car>();
    
    public MainFormRegistryOfCarInspections()
    {
      InitializeComponent();
      dataGridViewCars.DataSource = _cars;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddOrEditCarForm addCar = new AddOrEditCarForm();
		  System.Windows.Forms.DialogResult dialogResult = addCar.ShowDialog();
		  if (dialogResult == DialogResult.OK)
		  {
		    _cars.Add(addCar.Car);
		  }
		  
		}
	}
}
