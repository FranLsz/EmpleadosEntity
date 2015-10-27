using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityEmpleados.Model;

namespace EntityEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new EmpleadosEntities();
            var p = new Puesto()
            {
                nombre = "Tecnico IT",
                salarioBase = 30000

            };

            ctx.Puesto.Add(p);
            ctx.SaveChanges();
        }
    }
}
