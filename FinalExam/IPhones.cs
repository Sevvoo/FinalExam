using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    interface IPhones : IAllCataloge
    {
        public string Phone_Model { get; set; }
        public string Phone_Brand { get; set; }
        public double Phone_Size { get; set; }
        public int Phone_YearMade { get; set; } 
        public double Price { get; set; }
        public string Print();

    }
}
