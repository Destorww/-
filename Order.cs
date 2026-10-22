using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject23123
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Данные клиента (на случай, если заказ создаётся без него — будут пустые)
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }

        // Список комплектующих (ключ — категория, значение — выбранный item)
        public Dictionary<string, ComponentItem> Items { get; set; } = new Dictionary<string, ComponentItem>();

        public int TotalItems { get; set; }
        public decimal TotalSum { get; set; }

        // Удобный текст для отображения в таблице
        public string Summary => $"Заказ №{Id} — {ClientName ?? "без клиента"} — {TotalItems} поз. — {TotalSum:N0} ₽";
    }
}