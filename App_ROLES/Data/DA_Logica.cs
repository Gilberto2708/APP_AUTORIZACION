using App_ROLES.Models;

namespace App_ROLES.Data
{
    public class DA_Logica
    {

        public List<Usuario> ListaUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario { Id = 1, Nombre = "Jose", Correo = "admin@gmail.com", Clave = "123", Roles = new string[] { "Administrador"}},
                new Usuario { Id = 2, Nombre = "Maria", Correo = "supervisor@gmail.com", Clave = "123", Roles = new string[] { "Supervisor"}},
                new Usuario { Id = 3, Nombre = "Juan", Correo = "empleado@gmail.com", Clave = "123", Roles = new string[] { "Empleado"}},
                new Usuario { Id = 4, Nombre = "Oscar", Correo = "superempleado@gmail.com", Clave = "123", Roles = new string[] { "Empleado","Supervisor"}}
            };
                                          
        }


        public Usuario ValidarUsuario (string _correo, String _clave)
        {
            return ListaUsuarios().Where(x => x.Correo == _correo && x.Clave == _clave).FirstOrDefault();
        }



    }
}
