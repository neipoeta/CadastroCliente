using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente.Utils
{
    class HoverStyle
    {
        public static void Hover(DataGridView grid, int rowIndex, Color backColor, Color foreColor)
        {
            if (rowIndex > -1)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle
                {
                    BackColor = backColor,
                    ForeColor = foreColor
                };
                grid.Rows[rowIndex].DefaultCellStyle = style;
            }
        }
    }
}