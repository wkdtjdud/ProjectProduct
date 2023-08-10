using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct
{
    internal class Product
    {
        public int Date { get; set; }
        public string Menu { get; set; }

        public override string ToString()
        {
            //13일: 로제떡볶이
            return Date + "일:" +  Menu;
        }
    }
}
