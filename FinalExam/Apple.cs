using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    public class Apple : IProduct, IPhone
    {
        public string Name { get { return this.Phone_Model + " - " + this.Phone_Brand; } }

        public double Price { get; set; }

        public string Phone_Model { get; set; }
        public string Phone_Brand { get; set; }
        public double Phone_Size { get; set; }
    }
}
