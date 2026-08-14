using SolucionCapas.Datos;

namespace SolucionCapas.Negocio
{
    public class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
    }

    public class PersonaNegocio
    {
        private PersonaDatos _datos = new PersonaDatos();

        public Persona ObtenerPersona(string dni)
        {
            if (string.IsNullOrEmpty(dni))
                return null;

            // Pide los datos a la capa de Datos
            var resultado = _datos.BuscarPorDni(dni);

            if (resultado == null)
                return null;

            // Transforma los datos encontrados en un objeto Persona
            return new Persona
            {
                Dni = resultado.Value.Dni,
                Nombre = resultado.Value.Nombre,
                Telefono = resultado.Value.Telefono,
                Direccion = resultado.Value.Direccion,
                Ciudad = resultado.Value.Ciudad
            };
        }
    }
}