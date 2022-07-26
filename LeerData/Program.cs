using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Linq;
namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaLibrosContext())
                {
                    var Autor = db.Autor.Single(x => x.AutorId == 7);
                    if (Autor != null){
                        db.Remove(Autor);
                        var estado = db.SaveChanges();
                        Console.WriteLine("El estado de la transacción es: " + estado);
                    }
                }    
            }
    }
}