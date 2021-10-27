using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1N
{
	public class LojaContext : DbContext
	{
		public LojaContext():base("Loja")
		{
		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Marca> Marcas { get; set; }
	}
}
