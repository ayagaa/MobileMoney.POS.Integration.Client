using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MobileMoney.POS.Integration.Client.Utils
{
    public static class Extensions
    {
        public static void CopyPropertiesTo<T, TU>(this T source, TU dest)
        {
            var sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).ToList();
            var destProps = typeof(TU).GetProperties()
                    .Where(x => x.CanWrite)
                    .ToList();

            foreach (var prop in sourceProps)
            {
                var bestMatchProp = destProps.FirstOrDefault(d => d.Name == prop.Name);
                if (bestMatchProp != null && destProps.Any(d => d.Name == bestMatchProp.Name))
                {
                    var p = destProps.First(x => x.Name == bestMatchProp.Name);
                    if (p.CanWrite)
                    { // check if the property can be set or no.
                        p.SetValue(dest, prop.GetValue(source, null), null);
                    }
                }
            }
        }

        public static object[] ToArray<RootObject>(this RootObject source, string[] columnNames, DataRow dataRow)
        {
            int propCount = typeof(RootObject).GetProperties().Count();

            object[] result = new object[propCount];

            for (int j = 0; j < columnNames.Length; j++)
            {
                try
                {
                    result[j] = dataRow[columnNames[j]];
                }
                catch (Exception)
                {

                }
            }

            return result;
        }

        public static List<RootObject> AsEnumerable<RootObject>(this DataTable source, string[] columnNames)
        {
            var result = new List<RootObject>();

            var propInfos = typeof(RootObject).GetProperties().OrderBy(p =>
                p.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                .Cast<DisplayNameAttribute>()
                .Select(a => a.DisplayName).FirstOrDefault()).ToArray();
            for (int i = 0; i < source.Rows.Count; i++)
            {
                var row = source.Rows[i];
                var resultType = typeof(RootObject);
                var resulRow = Activator.CreateInstance(resultType);

                for (int j = 0; j < columnNames.Length; j++)
                {
                    try
                    {
                        row.CopyPropertiesTo(resulRow);
                        result.Add((RootObject)resulRow);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(string.Format("Exception Column: {0}", propInfos[j].Name));
                    }
                }
            }

            return result;
        }
    }
}
