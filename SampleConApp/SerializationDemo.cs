using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SampleConApp
{
    [Serializable]
    public class Temp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Name}\t{Date.ToLongDateString()}";
        }
    }

    class SerializationDemo
    {
        static void Main(string[] args)
        {
            //saveBinary();
            //loadBinary();
            //saveXml();
            loadXml();
        }

        private static void loadXml()
        {
            FileStream fs = new FileStream("MyData.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(Temp));//Should pass the Type info of the class whose object U R Trying to Serialize....
            var temp = serializer.Deserialize(fs) as Temp;
            fs.Close();
            Console.WriteLine(temp);
        }

        private static void saveXml()
        {
            Temp temp = new Temp { ID = 123, Name = "TempName", Date = DateTime.Now.AddHours(-23455) };
            FileStream fs = new FileStream("MyData.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(Temp));//Should pass the Type info of the class whose object U R Trying to Serialize....
            serializer.Serialize(fs, temp);
            fs.Close();
        }

        private static void loadBinary()
        {
            BinaryFormatter fm = new BinaryFormatter();
            FileStream fs = new FileStream("MyData.Bin", FileMode.Open, FileAccess.Read);
            Temp temp = fm.Deserialize(fs) as Temp;
            Console.WriteLine(temp);
        }

        private static void saveBinary()
        {
            Temp temp = new Temp { Date = DateTime.Now.AddDays(-234), ID = 111, Name = "Phaniraj" };
            FileStream fs = new FileStream("MyData.Bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, temp);
            fs.Close();
        }
    }
}
