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
      dataGridViewCars.AutoGenerateColumns = false;
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
		AddOrEditCarForm editCar = new AddOrEditCarForm();
		Car car = _cars[dataGridViewCars.SelectedRows[0].Index];
		System.Windows.Forms.DialogResult dialogResult = editCar.ShowDialog(car);
		if (dialogResult == DialogResult.OK)
		{
				//editCar.Tag = Convert.ToString(car);
				//_cars.Add(_cars[dataGridViewCars.SelectedRows[0].Index]);

		  _cars[dataGridViewCars.SelectedRows[0].Index] = editCar.Car;

		  //_cars.Add(car);
		  //car = _cars.Add(editCar.Car);
		  //_cars.Add(editCar.Car);
		  //car.Equals(editCar.Car);	
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
			dataGridViewCars.Rows.RemoveAt(dataGridViewCars.SelectedRows[0].Index);
		}

		private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
