using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_SimpleFactory
{
    interface ICar
    {
        string GetCarPrice();
    }
  

    class Volvo : ICar
    {
        public string GetCarPrice()
        {
            return "$100";
        }
    }

    class Benz : ICar
    {
        public string GetCarPrice()
        {
            return "$200";
        }
    }
}
