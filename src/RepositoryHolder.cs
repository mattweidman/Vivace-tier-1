using todo.Models;

namespace todo
{
    /** Holds DocumentDBRepositories of all collections */
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