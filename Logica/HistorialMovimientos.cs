using System;
using System.Collections.Generic;
using System.Text;

namespace MiniATM.Logica
{
    internal class HistorialMovimientos
    {
        public static void RegistrarMovimientos(List<string> movimientos, string tipo, decimal monto, decimal saldoResultante)
        {
            movimientos.Add($"{tipo,-10} | {monto,8:F2} | {saldoResultante,10:F2}");
        }
    }
}
