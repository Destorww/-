using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject23123
{
    public class ComponentItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Socket { get; set; } // Только для процессоров и материнок

        public override string ToString()
        {
            return $"{Name} — {Price:N0} ₽";
        }
    }

    public static class ComponentCatalog
    {
        public static readonly Dictionary<string, List<ComponentItem>> Items = new Dictionary<string, List<ComponentItem>>
        {
            // === Обязательные ===
            { "cpu", new List<ComponentItem> {
                new ComponentItem { Name = "AMD Ryzen 7 9800X3D", Price = 55000m, Socket = "AM5" },
                new ComponentItem { Name = "AMD Ryzen 7 9850X3D", Price = 62000m, Socket = "AM5" },
                new ComponentItem { Name = "Intel Core Ultra 9 285K", Price = 68000m, Socket = "LGA1851" },
                new ComponentItem { Name = "AMD Ryzen 5 9600X", Price = 25000m, Socket = "AM5" },
                new ComponentItem { Name = "Intel Core Ultra 5 245K", Price = 32000m, Socket = "LGA1851" }
            }},
            { "mb", new List<ComponentItem> {
                new ComponentItem { Name = "ASUS ROG STRIX X870E-E", Price = 45000m, Socket = "AM5" },
                new ComponentItem { Name = "MSI MAG B850 TOMAHAWK", Price = 28000m, Socket = "AM5" },
                new ComponentItem { Name = "Gigabyte X870 AORUS ELITE", Price = 35000m, Socket = "AM5" },
                new ComponentItem { Name = "ASUS ROG MAXIMUS Z890 HERO", Price = 58000m, Socket = "LGA1851" },
                new ComponentItem { Name = "MSI MPG Z890 CARBON", Price = 42000m, Socket = "LGA1851" }
            }},
            { "psu", new List<ComponentItem> {
                new ComponentItem { Name = "Corsair RM750e 750W Gold", Price = 12500m },
                new ComponentItem { Name = "Seasonic Focus GX-850 850W Gold", Price = 16000m },
                new ComponentItem { Name = "Corsair RM1000x Shift 1000W Gold", Price = 22000m },
                new ComponentItem { Name = "MSI MAG A650GLS 650W Gold", Price = 9500m },
                new ComponentItem { Name = "Seasonic PRIME TX-1000 1000W Titanium", Price = 35000m }
            }},
            { "gpu", new List<ComponentItem> {
                new ComponentItem { Name = "NVIDIA GeForce RTX 5090", Price = 280000m },
                new ComponentItem { Name = "NVIDIA GeForce RTX 5080", Price = 130000m },
                new ComponentItem { Name = "NVIDIA GeForce RTX 5070 Ti", Price = 90000m },
                new ComponentItem { Name = "NVIDIA GeForce RTX 5070", Price = 65000m },
                new ComponentItem { Name = "NVIDIA GeForce RTX 5060 Ti", Price = 45000m }
            }},
            { "cool", new List<ComponentItem> {
                new ComponentItem { Name = "Noctua NH-D15", Price = 11000m },
                new ComponentItem { Name = "be quiet! Dark Rock Pro 5", Price = 10500m },
                new ComponentItem { Name = "Arctic Liquid Freezer III 360", Price = 14000m },
                new ComponentItem { Name = "NZXT Kraken Elite 360", Price = 28000m },
                new ComponentItem { Name = "Thermalright Peerless Assassin 120", Price = 4500m }
            }},
            { "ram", new List<ComponentItem> {
                new ComponentItem { Name = "Corsair Vengeance 32GB DDR5-6000", Price = 12000m },
                new ComponentItem { Name = "G.Skill Trident Z5 RGB 32GB DDR5-6000", Price = 15000m },
                new ComponentItem { Name = "Kingston Fury Beast 16GB DDR5-5600", Price = 7000m },
                new ComponentItem { Name = "TeamGroup T-Force Delta 32GB DDR5-6400", Price = 14000m },
                new ComponentItem { Name = "Crucial Pro 32GB DDR5-5600", Price = 11000m }
            }},
            { "storage", new List<ComponentItem> {
                new ComponentItem { Name = "Samsung 990 Pro 2TB NVMe", Price = 22000m },
                new ComponentItem { Name = "WD Black SN850X 2TB NVMe", Price = 19000m },
                new ComponentItem { Name = "Crucial T700 1TB NVMe Gen5", Price = 15000m },
                new ComponentItem { Name = "Seagate FireCuda 530 1TB NVMe", Price = 12000m },
                new ComponentItem { Name = "Kingston Fury Renegade 1TB", Price = 10000m }
            }},
            { "case", new List<ComponentItem> {
                new ComponentItem { Name = "Fractal Design North", Price = 14000m },
                new ComponentItem { Name = "Corsair 4000D Airflow", Price = 9000m },
                new ComponentItem { Name = "Lian Li O11 Dynamic EVO", Price = 16000m },
                new ComponentItem { Name = "NZXT H7 Flow", Price = 12000m },
                new ComponentItem { Name = "be quiet! Pure Base 500DX", Price = 11000m }
            }},

            // === Опциональные ===
            { "sound", new List<ComponentItem> {
                new ComponentItem { Name = "Creative Sound Blaster AE-9", Price = 25000m },
                new ComponentItem { Name = "ASUS Xonar AE", Price = 7000m },
                new ComponentItem { Name = "Creative Sound BlasterX G6 (внешняя)", Price = 10000m }
            }},
            { "extra", new List<ComponentItem> {
                new ComponentItem { Name = "Кабель-удлинитель Lian Li Strimer Plus", Price = 6000m },
                new ComponentItem { Name = "Контроллер вентиляторов Corsair Commander", Price = 5000m },
                new ComponentItem { Name = "Термопаста Arctic MX-6", Price = 800m }
            }},
            { "peripheral", new List<ComponentItem> {
                new ComponentItem { Name = "Logitech G Pro X Superlight 2", Price = 15000m },
                new ComponentItem { Name = "Razer BlackWidow V4 Pro", Price = 20000m },
                new ComponentItem { Name = "HyperX Cloud III Wireless", Price = 13000m }
            }},
            { "software", new List<ComponentItem> {
                new ComponentItem { Name = "Windows 11 Pro OEM", Price = 15000m },
                new ComponentItem { Name = "Microsoft Office 2024 Home", Price = 9000m },
                new ComponentItem { Name = "Антивирус Kaspersky Plus (1 год)", Price = 2500m }
            }}
        };
    }
}