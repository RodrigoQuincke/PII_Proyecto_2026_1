namespace Proyecto2026
{
    // Clase base abstracta para todos los tipos de usuario del sistema.
    // Encapsula la contraseña para proteger los datos del usuario.
    public abstract class GenericUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        private string HashedPassword { get; set; }

        protected GenericUser(string username, string email, string hashedPassword)
        {
            Username = username;
            Email = email;
            HashedPassword = hashedPassword;
        }

        // Verifica si el nombre de usuario coincide con el de esta instancia.
        public bool UserExists(string username)
        {
            return Username == username;
        }

        // Valida datos de inicio de sesión.
        // Compara el hash de la contraseña ingresada con el almacenado.
        public bool LoginUser(string username, string password)
        {
            return Username == username && HashedPassword == password;
        }
    }
}