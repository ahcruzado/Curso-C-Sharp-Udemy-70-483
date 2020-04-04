using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace AyncAwait
{
    public class Archivos
    {
        public Task<List<string>> ListarInformacion()
        {
            return Task.Run(() =>
            {
                var files = from file in Directory.GetFiles(@"C:\Windows\System32")
                            select file;

                Thread.Sleep(5000);
                return files.ToList();
            });            
        }
    }
}
