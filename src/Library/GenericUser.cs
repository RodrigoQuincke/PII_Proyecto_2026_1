namespace Proyecto2026
{
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
    }
}