using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {

            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio local = new Negocio(caja1, caja2);

            local.Clientes.Add("Roberto");
            local.Clientes.Add("Barbara");
            local.Clientes.Add("Facundo");
            local.Clientes.Add("Patricia");
            local.Clientes.Add("Nicolas");
            local.Clientes.Add("Demian");
            local.Clientes.Add("Silvia");

            Thread t1 = new Thread(local.AsignarCaja);
            t1.Name = "Asignar Caja";

            Thread t2 = new Thread(caja1.AtenderClientes);
            t2.Name = "Caja 1";

            Thread t3 = new Thread(caja2.AtenderClientes);
            t3.Name = "Caja 2";

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            t2.Join();
            t3.Join();
            

            Console.ReadLine();
            

        }
    }
}
