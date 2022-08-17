using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class Shop
    {
        public List<Filters> Filters { get; set; }
        public Shop()
        {
            Filters = new List<Filters>();

            Filters phones = new Filters();
            phones.Title = "Телефоны";
            phones.Categories = new List<Categories>();

            Categories samsung = new Categories();
            samsung.Title = "Samsung";
            phones.Categories.Add(samsung);

            Categories iphone = new Categories();
            iphone.Title = "IPhone";
            phones.Categories.Add(iphone); 
            
            Categories huawei = new Categories();
            huawei.Title = "Huawei";
            phones.Categories.Add(huawei);


            Filters laptops = new Filters();
            laptops.Title = "Ноутбуки";
            laptops.Categories = new List<Categories>();

            Categories hp = new Categories();
            hp.Title = "HP";
            laptops.Categories.Add(hp);

            Categories asus = new Categories();
            asus.Title = "ASUS";
            laptops.Categories.Add(asus);

            Categories lenovo = new Categories();
            lenovo.Title = "Lenovo";
            laptops.Categories.Add(lenovo);



            Filters.Add(phones);
            Filters.Add(laptops);
        }

    }
}
