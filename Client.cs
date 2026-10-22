using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject23123
{
        public class Client
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string DeliveryType { get; set; }   // "Доставка" или "Самовывоз"
            public string City { get; set; }
            public string Street { get; set; }
            public string Entrance { get; set; }
            public string Flat { get; set; }
        }
    }