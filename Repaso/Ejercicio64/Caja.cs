using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    public class Caja
    {

        private List<String> filaClientes;

        public List<String> FilaClientes
        {
            get { return this.filaClientes; }
            
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach(string cliente in this.filaClientes)
            {
                Console.WriteLine("Cliente {0}, atendido por {1}", cliente, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
            this.filaClientes.RemoveRange(0, this.filaClientes.Count);

            
        }




    }
}
