
namespace Adapter.Features
{
    // Adapter
    public class XmlToJsonAdapter : IJsonDataProvider
    {
        private readonly XmlDataProvider _xmlDataProvider;

        public XmlToJsonAdapter(XmlDataProvider xmlDataProvider)
        {
            _xmlDataProvider = xmlDataProvider;
        }
        public string GetJsonData()
        {
            // Fetch XML data from the adaptee
            string xmlData = _xmlDataProvider.GetXmlData();

            // Convert XML to JSON (simplified for this example)
            var xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(xmlData);
            var json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(xmlDoc);

            return json;
        }
    }
}
