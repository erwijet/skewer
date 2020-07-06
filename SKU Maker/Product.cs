using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace SKU_Maker
{
    [XmlRoot("Product")]
    public class Product
    {
        [XmlAttribute("title")]
        public string Name { get; set; }
        public string Comment { get; set; }
        public List<ProductProperty> Properties { get; set; }
        public List<SkuComponent> SkuSchema { get; set; }

        public Product()
        {
        }

        public Product(string name)
        {
            Name = name;
            Comment = "";
            Properties = new List<ProductProperty>();
        }

        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(Product));
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public static Product Load(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(Product));
            Product prod = serializer.Deserialize(reader) as Product;
            reader.Close();
            return prod;
        }
    }
}
