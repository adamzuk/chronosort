using System;
using System.IO;
using System.Xml.Serialization;
using UI.Models;

namespace ChronoSortCore.Utils
{
    public class SerializationHelper
    {
        public static ItemsCollection Deserialize(string path)
        {
            ItemsCollection collection = null;

            using (var reader = new StreamReader(path))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(ItemsCollection));
                collection = (ItemsCollection)deserializer.Deserialize(reader);
            }

            return collection;
        }
    }
}
