using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    interface IAllCataloge
    {
        public string Phones { set; }
        public string Laptops { get; set; }
        public string PC { get; set; }
        public string Devices { get; set; }
        public string TV { get; set; }
        public string Audio { get; set; }
        public string Print();

    }
}
