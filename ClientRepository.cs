using MyProject23123;
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
        public static class ClientRepository
        {
            public static List<Client> Clients { get; } = new List<Client>();

            public static void Add(Client client)
            {
                if (client != null)
                    Clients.Add(client);
            }
        }
    }