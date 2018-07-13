﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary; //***


namespace Entidades
{
    [Serializable]
    public class Votacion
    {
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        public delegate void Voto(string sen, Votacion.EVoto voto); //***

        [field: NonSerializedAttribute()]
        public event Voto EventoVotoEfectuado; //***

        private string nombreLey;

        public string NombreLey
        {
            get { return nombreLey; }
            set { nombreLey = value; }
        }
        private Dictionary<string, EVoto> senadores;

        private short contadorAfirmativo;

        public short ContadorAfirmativo
        {
            get { return contadorAfirmativo; }
            set { contadorAfirmativo = value; }
        }
        private short contadorNegativo;

        public short ContadorNegativo
        {
            get { return contadorNegativo; }
            set { contadorNegativo = value; }
        }
        private short contadorAbstencion;

        public short ContadorAbstencion
        {
            get { return contadorAbstencion; }
            set { contadorAbstencion = value; }
        }



        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(2134);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento pasandole parametro ****
                EventoVotoEfectuado(k.Key, this.senadores[k.Key]);

                // Incrementar contadores

            }
        }
    }
}
