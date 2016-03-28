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
    //Public class used for serialization and deserialization
    public class FileIO
    {//Function used to serialize data (string - variable used to for naming the save file, T - passed in any arguement)
        public void Serialize<T>(string s, T t)
        { 
            //Use the filestream to create a folder at the given directory(s - with the passed in file name and xml extension)
            using (FileStream fs = File.Create(@"..\Saved Parties\" + s + ".xml"))
            { //Create instance of serializer object
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //Call serialize function
                serializer.Serialize(fs, t);
                //Close the file
                fs.Close();
            }
        }

        //This function will be used for saving data to a different directory
        //Function used to serialize data (string - variable used to for naming the save file, T - passed in any arguement)
        public void SerializeToSave<T>(string s, T t)
        { //Use the filestream to create a folder at the given directory(s - with the passed in file name and xml extension)
            using (FileStream fs = File.Create(@"..\Game Saves\" + s + ".xml"))
            {
                //Create instance of an Xml serializer object
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //Call serialize function
                serializer.Serialize(fs, t);
                //Close the filestream
                fs.Close();
            }

        }

        //Function will be used for deserialization of data
        public T Deserialize<T>(string s)
        {//Create an instance of an xml serializer object
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            //Generic type variable used for storing the read in data
            T item;
            //Open the file stream and read in from the passed in s variable 
            using (FileStream fs = File.OpenRead(s))
            {//Store the deserialized read in data into variable 
                item = (T)deserializer.Deserialize(fs);
                //Close the filestream
                fs.Close();
            }

            return item;
        }
    }
}
