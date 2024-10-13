using System.Xml;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter
{
    public class XmlToJsonAdapter : ITarget
    {
        private readonly XmlDataSource _dataSource;

        public XmlToJsonAdapter(XmlDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public string GetJson()
        {
            string xml = _dataSource.GetXMLDataSource();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string jsonData = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            return jsonData;
        }
    }
}
