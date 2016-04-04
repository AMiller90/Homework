using System;
using System.Collections.Generic;
//Namespace for using xml serilizer and deserilaizer
using System.Xml.Serialization;

namespace Adgp_125_Assessment_WinForm
{
    [Serializable]
    [XmlRoot("Party")]
    //Public class used for containing units
    public class Party
    {//Public constructor
        public Party()
        {//Initialize a unit list with each instance of a party object
            _units = new List<Unit>();

        }
        //Private list of units variable
        private List<Unit> _units;

        //Sets the name of the Array to party, Sets the items in the array as Unit type and gives the element name as Unit
        [XmlArray("Party"), XmlArrayItem(typeof(Unit), ElementName = "Unit")]
        //Public List<Unit> property
        public List<Unit> units
        {
            get
            {//return units variable
                return _units;
            }

            set
            {//give the units variable a value
                _units = value;
            }
        }

    }
}
