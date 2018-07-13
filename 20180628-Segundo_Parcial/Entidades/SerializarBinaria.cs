using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///*** AGREGAR ESTOS 3 PARA SERIALIZAR
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Entidades
{
    public class SerializarBinaria: IArchivos<Votacion>
    {

        public SerializarBinaria() { }

        public Votacion Leer(string nombre)
        {
            Votacion vot;
            FileStream fs = new FileStream(nombre, FileMode.Open);
            
           try{
              BinaryFormatter ser = new BinaryFormatter();
              vot = (Votacion)ser.Deserialize(fs);
               
            }
            catch
            {
                throw new ErrorArchivoExpcepcion("No se pudo Leer el archivo");
            }
            finally
            {
                fs.Close();
            }
                
            return vot;
        }

        public bool Guardar(string nombre, Votacion obj)
        {
            bool flag = false;
            FileStream fs = new FileStream(nombre, FileMode.Create);
            try
            {
                
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(fs, obj);

                flag = true ;
            }
            catch
            {
                throw new ErrorArchivoExpcepcion("No se pudo Guardar el archivo");
                
            }
            finally
            {
                fs.Close();
            }

            return flag;
        }



    }
}
