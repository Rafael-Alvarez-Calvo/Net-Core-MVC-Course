using System.ComponentModel.DataAnnotations;

namespace Turnos.Models{
    public class Especialidad{
        // Primary key de la tabla
        [Key] //Con esto especificamos a entity frameworks que esta es la primary key
        public int IdEspecialidad { get; set;}
        public string Description { get; set;}
    }

    //Despues de escribir esto compilaremos el proyecto en la terminal con el comando "dotnet run"
    //Se debe eliminar la conexion https y la redirección automática de .Net
    //Properties --> launchSettings editamos url
    //Startup.cs desactivamos la funcion de redirection();
}