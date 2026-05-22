namespace Proyecto2026
{
    public class Admin : GenericUser
    {
        public Admin(string username, string email, string hashedPassword)
            : base(username, email, hashedPassword)
        {
        }
    }
}
