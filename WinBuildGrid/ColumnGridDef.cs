using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBuildGrid
{
    class ColumnGridDef
    {
        public string IdColumn { get; set; }
        public string Caption { get; set; }
        public int Length { get; set; }

        public string Type { get; set; }

        public bool IsVisible { get; set; }

        public bool IsEditable { get; set; }

        public string FormatString { get; set; }


    }
}
