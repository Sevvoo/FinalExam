using System;
namespace FinalExam
{
	public class Samsung : IProduct, IPhone
	{
		public string Name { get { this.Phone_Model + " - " + this.Phone_Brand } }

        public double Price { get; set; }

        public string Phone_Model { get; set; }
        public string Phone_Brand { get; set; }
        public double Phone_Size { get; set; }
    }
}

