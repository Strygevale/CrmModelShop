using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
   public class Check
    {
        public int CheckId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; } //хранится идентефикатор число
        public virtual Seller Seller { get; set; } //хранится объект и все его свойства
        public DateTime Created { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public override string ToString()
        {
            return $"№{CheckId} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }

    }
}
