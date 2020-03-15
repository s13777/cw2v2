using System.Xml.Serialization;

namespace cw2v2
{
    public class Student
    {
        [XmlElement(elementName: "IndexNumber")]
        public string IndexNumber { get; set; }

        [XmlElement(elementName: "FirstName")]
        public string FirstName { get; set; }

        [XmlElement(elementName: "LastName")]
        public string LastName { get; set; }

        [XmlElement(elementName: "BirthDate")]
        public string BirthDate { get; set; }

        [XmlElement(elementName: "Mail")]
        public string Mail { get; set; }

        [XmlElement(elementName: "MothersName")]
        public string MothersName { get; set; }

        [XmlElement(elementName: "FathersName")]
        public string FathersName { get; set; }

        [XmlElement(elementName: "StudiesName")]
        public string StudiesName { get; set; }

        [XmlElement(elementName: "StudiesMode")]
        public string StudiesMode { get; set; }
    }
}