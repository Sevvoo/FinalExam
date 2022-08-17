using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class HP : IProduct, ILaptop
    {
        public string Name { get { return this.Laptop_Model + " - " + this.Laptop_Brand; } }

        public double Price { get ; set ; }
        public string Laptop_Model { get; set; }
        public string Laptop_Brand { get ; set ; }
        public double Laptop_Screen_Size { get ; set; }
    }
}
