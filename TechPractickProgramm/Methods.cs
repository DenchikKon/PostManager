using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechPractickProgramm
{
    internal class Methods
    {
        public static void SearchData(DataGridView dataGrid, TextBox searchBox)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                int count = 0;
                for (int j = 1; j < dataGrid.ColumnCount; j++)
                {
                    if (dataGrid[j, i].Value.ToString().IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        count++;
                }
                if (count > 0)
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(91, 227, 150);
                else
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            if (searchBox.Text == "")
                for (int i = 0; i < dataGrid.RowCount; i++)
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }
    }
}
