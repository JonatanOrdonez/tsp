using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class workInsercionTodo
    {
        private FormSolucionarTodo principal;

        public workInsercionTodo(FormSolucionarTodo principal)
        {
            this.principal = principal;
        }

        public void DoWork()
        {
            principal.Principal.Aerolinea.refrescarSolucionTotalInsercion(principal.TablaViajeros, principal.BarraProgreso, principal.EtiquetaPorcentaje, 1);
        }
    }
}
