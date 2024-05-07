using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        // Constructor Injection
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(string name)
        {
            var user = new User { Name = name };
            _userRepository.Save(user);
        }
    }
}
