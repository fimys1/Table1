using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.LogicFolder
{
    public class Customer
    {
        public int Id { get; set; }

        //[MaxLength(30)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[MinLength(0)]
        //[MaxLength(100)]
        public string Email { get; set; }

        public int Age { get; set; }
        // public byte[] Photo { get; set; }

        // Ссылка на заказы
        //public virtual List<Order> Orders { get; set; }        
    }
}
