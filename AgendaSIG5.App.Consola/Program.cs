using System;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello patient, welcome to AgendaSIG5!!!!");
            Console.WriteLine("hugo commit");
            AddPaciente();
            BuscarPaciente(1);
        }
        private static void AddPaciente()
        {
            var paciente =new Paciente
            {
                Nombre="Jairo H",
                Apellidos="Ramirez",
                NumeroTelefono="3112234561",
                Genero=Genero.Masculino,
                Direccion="Calle 18 11-15",
                Ciudad="Mosquera"
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellidos+"  Género: "+paciente.Genero);
        }  

    }
}
