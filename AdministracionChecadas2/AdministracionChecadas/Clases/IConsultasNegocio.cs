
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescargarChecadas.Negocio
{
    public interface IConsultasNegocio
    {
        void pruebaConn();

        DateTime obtUltimaFecha(int numChec);

        void insertaRegistro(DescargarChecadas.Modelos.AttLogs res);

        bool conectaBase();

        void insertaNuevo(int idInterno);
    }
}
