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

    private void buttonEdit_Click(object sender, EventArgs e)
    {
      AddOrEditCarForm editCar = new AddOrEditCarForm();
      Car car = _cars[dataGridViewCars.SelectedRows[0].Index];
      System.Windows.Forms.DialogResult dialogResult = editCar.ShowDialog();
      if (dialogResult == DialogResult.OK)
      {
       
      }
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

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			//foreach (DataGridView row in dataGridViewCars.SelectedRows)
			//{
				//if (row.SelectAll)
				//{
					dataGridViewCars.Rows.RemoveAt(dataGridViewCars.SelectedRows[0].Index);
				//}

			//}

		}
	}
}
