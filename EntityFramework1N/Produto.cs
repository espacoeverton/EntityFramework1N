using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1N
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //public decimal Preco { get; set; }

        public virtual Marca Marca { get; set; }
    }
}