using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public class WorkKruskalTodo
    {
        private FormSolucionarTodo principal;

        public WorkKruskalTodo(FormSolucionarTodo principal)
        {
            this.principal = principal;
        }

        public void DoWork()
        {
            principal.Principal.Aerolinea.refrescarSolucionTotalKruskal(principal.TablaViajeros, principal.BarraProgreso, principal.EtiquetaPorcentaje, 1);
        }
    }
}
