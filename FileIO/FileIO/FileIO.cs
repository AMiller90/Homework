 using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace FileIO
{
    //Public class used for serialization and deserialization
    public class FileIOS
    {//Function used to serialize data (string - variable used to for naming the save file, T - passed in any arguement)
        public void Serialize<T>(string a_sS, T a_tT)
        {
            //Use the filestream to create a folder at the given directory(s - with the passed in file name)
            using (FileStream fs = File.Create(@"..\Party\" + a_sS))
            { //Create instance of serializer object
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //Call serialize function
                serializer.Serialize(fs, a_tT);
                //Close the file
                fs.Close();
            }
        }

        //This function will be used for saving data to a different directory
        //Function used to serialize data (string - variable used to for naming the save file, T - passed in any arguement)
        public void SerializeToSave<T>(string a_sS, T a_tT)
        { //Use the filestream to create a folder at the given directory(s - with the passed in file name and xml extension)
            using (FileStream fs = File.Create(@"..\Game Saves\" + a_sS + ".xml"))
            {
                //Create instance of an Xml serializer object
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //Call serialize function
                serializer.Serialize(fs, a_tT);
                //Close the filestream
                fs.Close();
            }

        }

        //Function will be used for deserialization of data
        public T Deserialize<T>(string a_sS)
        {//Create an instance of an xml serializer object
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            //Generic type variable used for storing the read in data
            T item;
            //Open the file stream and read in from the passed in s variable 
            using (FileStream fs = File.OpenRead(a_sS))
            {//Store the deserialized read in data into variable 
                item = (T)deserializer.Deserialize(fs);
                //Close the filestream
                fs.Close();
            }

            return item;
        }
    }
}
