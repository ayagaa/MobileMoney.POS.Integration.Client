using Newtonsoft.Json;
using System;

namespace MobileMoney.POS.Integration.Client.Utils
{
    public static class Json
    {
        private static JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        public static RootObject ParseApiData<RootObject>(string ApiResult)
        {
            RootObject _rootObject;
            try
            {
                _rootObject = JsonConvert.DeserializeObject<RootObject>(ApiResult, _jsonSerializerSettings);
                return _rootObject;
            }
            catch (Exception)
            {
            }
            return default(RootObject);
        }

        public static string SerializeResults<RootObject>(RootObject DataObject)
        {
            return JsonConvert.SerializeObject(DataObject, _jsonSerializerSettings);
        }

        //public static void JsonStringToCSV<RootObject>(string jsonContent)
        //{
        //    //used NewtonSoft json nuget package
        //    XmlNode xml = JsonConvert.DeserializeXmlNode("{records:{record:" + jsonContent + "}}");
        //    XmlDocument xmldoc = new XmlDocument();
        //    xmldoc.LoadXml(xml.InnerXml);
        //    XmlReader xmlReader = new XmlNodeReader(xml);

        //    DataSet dataSet = new DataSet();
        //    dataSet.ReadXml(xmlReader);
        //    Console.WriteLine(dataSet.Tables.Count);
        //    var dataTable = dataSet.Tables[0];

        //    //Datatable to CSV
        //    var lines = new List<string>();
        //    string[] columnNames = dataTable.Columns.Cast<DataColumn>().
        //                                      Select(column => column.ColumnName).
        //                                      ToArray();
        //    var header = string.Join(",", columnNames);

        //    lines.Add(header);

        //    var valueLines = dataTable.AsEnumerable<RootObject>(columnNames)
        //                              .Select((row, index) => string.Join(",", row.ToArray(columnNames, dataTable.Rows[index])));

        //    lines.AddRange(valueLines);
        //    File.WriteAllLines(@"D:/Kenya-2021-September.csv", lines);
        //}
    }
}
