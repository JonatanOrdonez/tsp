using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class WorkFuerzaBrutaTodos
    {
        private FormSolucionarTodo principal;

        public WorkFuerzaBrutaTodos(FormSolucionarTodo principal)
        {
            this.principal = principal;
        }

        public void DoWork()
        {
            principal.Principal.Aerolinea.refrescarSolucionTotalFuerzaBruta(principal.TablaViajeros, principal.BarraProgreso, principal.EtiquetaPorcentaje, 1);
        }
    }
}
