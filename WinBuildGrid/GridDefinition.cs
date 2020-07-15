using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBuildGrid
{
    class GridDefinition
    {
        List<ColumnGridDef> lstColDef;
        DataGridView dgrView;
        string strGrdDef;

        public GridDefinition(string pStrGridDef, DataGridView pDgr)
        {
            this.dgrView = pDgr;
            this.strGrdDef = pStrGridDef;
        }

        private void BuildList()
        {
            ColumnGridDef cdef;
            try
            {
                string[] filas = strGrdDef.Split('*');
                for (int i = 0; i < filas.Length; i++)
                {
                    string[] cols = filas[i].Split('|');
                    cdef = new ColumnGridDef();
                    cdef.IdColumn = cols[0];
                    cdef.Caption = cols[1];
                    cdef.Length = Convert.ToInt32(cols[2]);
                    cdef.Type = cols[3];
                    cdef.IsVisible = bool.Parse(cols[4]);
                    cdef.IsEditable = bool.Parse(cols[5]);
                    cdef.FormatString = cols[6];
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
