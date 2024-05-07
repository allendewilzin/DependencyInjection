using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IUserRepository
    {
        void Save(User user);
        void Edit(User user, bool editable);
    }

    public class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            // Implementation to save user to the database
            Console.WriteLine($"Saving user: {user.Name}");
        }
        public void Edit(User user, bool editable)
        {
            // Implementation to save user to the database
            Console.WriteLine($"Saving user: {user.Name}");
        }
    }
}
