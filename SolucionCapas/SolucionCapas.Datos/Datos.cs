using System.Collections.Generic;
using System.Linq;

namespace SolucionCapas.Datos
{
    public class PersonaDatos
    {
        // Simulamos la BD con una lista de datos
        private List<(string Dni, string Nombre, string Ciudad, string Telefono, string Direccion)> _tablaPersonas =
            new List<(string, string, string, string, string)>
        {
            ("23269431", "Alberto", "Mexico", "1234567", "Av. Gutierrez 23"),
            ("27576691", "Noemi", "Buenos Aires", "98382938", "Av. Libertador 234")
        };

        // Busca todos los datos de la persona por DNI
        public (string Dni, string Nombre, string Ciudad, string Telefono, string Direccion)? BuscarPorDni(string dni)
        {
            var resultado = _tablaPersonas.FirstOrDefault(p => p.Dni == dni);

            if (resultado.Dni == null)
                return null;

            return resultado;
        }
    }
}