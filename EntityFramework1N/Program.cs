using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1N
{
    class Program
    {
		static void Main(string[] args)
		{
			LojaContext db = new LojaContext();

			db.Produtos.ToList().ForEach(p => Console.WriteLine(p));
		}
	}
}
