using System.Text;
using System.Collections;
using System.Reflection;

namespace SingleResponsability;

public class ExportHelper<T>
{
    public void ExportToCSV(IEnumerable<T> items)
    {
        var sb = new StringBuilder();
        var header = GetHeader();
        sb.AppendLine(header);
        
        foreach (var item in items)
        {
            var dataRow = GetDataRow(item);
            sb.AppendLine(dataRow);
        }
        
        var filePath = GetFilePath();
        File.WriteAllText(filePath, sb.ToString(), Encoding.Unicode);
    }

    private string GetHeader()
    {
        var properties = typeof(T).GetProperties();
        var header = string.Join(";", properties.Select(prop => prop.Name));
        return header;
    }

    private string GetDataRow(T item)
    {
        var properties = typeof(T).GetProperties();
        var dataRow = string.Join(";", properties.Select(prop => GetPropertyValue(prop, item)));
        return dataRow;
    }

    private string GetPropertyValue(PropertyInfo prop, T item)
    {
        var propValue = prop.GetValue(item);
        var propType = prop.PropertyType;

        if (propType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(propType))
        {
            var enumerable = (IEnumerable)propValue;
            var values = enumerable.Cast<object>().Select(x => x.ToString());
            return string.Join("|", values);
        }

        return propValue.ToString();
    }

    private string GetFilePath()
    {
        var typeName = typeof(T).Name;
        var fileName = $"Export_{typeName}.csv";
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        return filePath;
    }
}