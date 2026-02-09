namespace Spin.AppInfra.ExcelHelper;

public interface IExcelExporter
{
    byte[] ExportToExcel<T>(IEnumerable<T> data);

}
