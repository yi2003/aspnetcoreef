using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCo
{
    public class Order 
    {
        [Key]
        public int Id { get; set; }
        public string OrderNo { get; set; }
    }
}
