using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Buoi51.Database
{
    internal class FileFactory<T>
    {
        public bool Ghi(DataGridView dgvSanPham, string path)
        {
           
                using StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (DataGridViewRow row in dgvSanPham.Rows)
                if (row.Cells.Count > 0)
                {
                    string rowData="";
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowData += cell.Value.ToString() + ";";
                        }
                        else
                        {
                            rowData += ";";
                        }    
                    }
                   sw.WriteLine(rowData);
                }
            sw.Close();
            return true;
        }

    }
}
