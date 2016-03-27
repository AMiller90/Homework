using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adgp_125_Assessment_WinForm
{
    public class FileIO
    {
        //Serialize<T>(string s , T t)
        //then your new xmlserializer(typeof T)
        public void Serialize<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\Saved Parties\" + s + ".xml"))
            { 
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(fs, t);


                fs.Close();
            }

        }

        public void SerializeToSave<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\Game Saves\" + s + ".xml"))
            {

                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(fs, t);


                fs.Close();
            }

        }

        public T Deserialize<T>(string s)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));

            T item;

            using (FileStream fs = File.OpenRead(s))
            {
                item = (T)deserializer.Deserialize(fs);
                fs.Close();
            }

            return item;
        }
    }
}
