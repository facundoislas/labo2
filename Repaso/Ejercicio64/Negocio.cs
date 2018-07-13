using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    public class Negocio
    {

        private List<String> clientes;

        public List<String> Clientes
        {
            get { return clientes; }
            
        }
        private Caja caja1;

        public Caja Caja1
        {
            get { return caja1; }
            
        }
        private Caja caja2;

        public Caja Caja2
        {
            get { return caja2; }
            
        }


        public Negocio(Caja caj1, Caja caj2)
        {
            this.caja1 = caj1;
            this.caja2 = caj2;
            this.clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas...");

            foreach(string cliente in this.clientes)
            {
                if (caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                    caja1.FilaClientes.Add(cliente);
                else
                    caja2.FilaClientes.Add(cliente);

                

            }

            Thread.Sleep(1000);
            
        }



    }
}
