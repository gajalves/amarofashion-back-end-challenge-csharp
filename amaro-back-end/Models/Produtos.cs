using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amaro_back_end.Models
{
    public class Produtos
    {
        public int Id { get; set; }

        public int ControleExterno { get; set; }

        public String Nome { get; set; }
        
        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }
}
