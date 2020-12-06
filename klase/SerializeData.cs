using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.klase
{
    class SerializeData
    {
        private static int flag = 0;
        Stream stream;
        BinaryFormatter bformatter;
        String txtFileName="";
        public SerializeData(String filename)
        {
           
            txtFileName = filename;
   
            bformatter = new BinaryFormatter();
 
            
        }
        public void SerializeDeleteFolder()
        {
            File.Delete(txtFileName);
            closeStream();
        }

        public void SerializeObject(Knjiga knjiga)
        {
            if (!File.Exists(txtFileName))
            {
                stream = File.Open(txtFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); //if file doesnt exist make new file
            }
            else
            {
                stream = File.Open(txtFileName, FileMode.Append, FileAccess.Write, FileShare.None);//if exist append the new object
            }

           
            bformatter.Serialize(stream, knjiga);

            closeStream();

        }

        public Skladiste DeserializeObject()
        {
            Object objectToDeserialize = null;
            Knjiga k = null;
            Skladiste skladiste = new Skladiste();
            if (File.Exists(txtFileName))
            {
                stream = File.Open(txtFileName, FileMode.Open);
                try
                {


                    while (stream.CanSeek)
                    {

                        objectToDeserialize = (Object)bformatter.Deserialize(stream);

                        k = (Knjiga)objectToDeserialize;
                        skladiste.dodajKnjiguUlistu(k);
                        //ovde ubacujes sta bi hteo sa objktom da radis itd id

                    }


                }
                catch (SerializationException e)
                {

                    //ovo mora da se desi
                }
                closeStream();
            }
                return skladiste;
            
        }

        public void closeStream()
        {
            stream.Close();
        }
    }
}
