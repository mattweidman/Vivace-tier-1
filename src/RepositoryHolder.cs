using vivace.Controllers;
using vivace.Models;

namespace vivace
{
    public static class RepositoryHolder
    {
        public static DocumentDBRepository<User> Users;
        public static DocumentDBRepository<Band> Bands;

        public static void Initialize()
        {
            Users = new DocumentDBRepository<User>("Users");
            Bands = new DocumentDBRepository<Band>("Bands");
        }
    }
}