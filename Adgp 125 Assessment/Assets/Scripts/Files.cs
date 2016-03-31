using UnityEngine;
using System.IO;
using System.Collections;
using System.Xml.Serialization;

public class Files : MonoBehaviour
{

    public void Serialize<T>(string s, T t)
    {
        //Use the filestream to create a folder at the given directory(s - with the passed in file name and xml extension)
        using (var fs = new FileStream(s, FileMode.Create))
        { //Create instance of serializer object
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //Call serialize function
            serializer.Serialize(fs, t);
            //Close the file
            fs.Close();
        }
    }
}