using LinqToExcel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Repository.Excel
{
    public class Leitor<T> where T : class
    {
        public List<T> ImportarFromExecel(string string64File, string extesion, string planilha = "Planilha1")
        {
            byte[] blob = Convert.FromBase64String(string64File);
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\TempExcel\";
            return ImportarFromExecel(blob, extesion, planilha);
        }

        public List<T> ImportarFromExecel(byte[] blob, string extesion, string planilha = "Planilha1")
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\TempExcel\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var fileName = path + Guid.NewGuid() + "." + extesion;
            File.WriteAllBytes(fileName, blob);
            var excel = new ExcelQueryFactory(fileName);
            return (from c in excel.Worksheet<T>(planilha) select c).ToList();
        }
    }
}
