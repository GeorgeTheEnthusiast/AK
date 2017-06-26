using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public class Car
  {
    public string Model { get; set; }

    public int ManufacturingYear { get; set; }

    public decimal EngineCapacity { get; set; }

    public string Brand { get; set; }

    public DateTime ReceivedDate { get; set; }

    public DateTime LastTechnicalReviewDate { get; set; }

    public string WhatToDo { get; set; }
  }
}
