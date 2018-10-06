using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Core.Services
{
    /// <summary>
    /// Represents a users business logic
    /// </summary>
    public sealed class UsersService
    {
        private  readonly  IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository) 
            => _usersRepository = usersRepository;

        public IEnumerable<User> GetUsers()
        {
            return _usersRepository.Get().ToList();
        }

        /// <summary>
        /// Finds a user and validate it
        /// </summary>
        /// <param name="username">A user name </param>
        /// <param name="password">A password</param>
        /// <returns>A <see cref="BasicOperationResult{T}"/> with a valid user</returns>
        public BasicOperationResult<User> Authenticate(string username, string password)
        {
            User foundUser =  _usersRepository.Find(user => user.Username == username && user.Password == password);

            if (foundUser == null )
            {
                return BasicOperationResult<User>.Fail("Usuario y/o contraseña invalido. por favor intente de nuevo");
            }

            if (!foundUser.IsActive)
            {
                return BasicOperationResult<User>.Fail("El usuario se encuentra inactivo, por favor contacte con el adminsitrador");
            }

            return BasicOperationResult<User>.Ok(foundUser);
        }

        public IOperationResult<User> UpdateUser(User newUser)
        {
            return _usersRepository.Update(newUser);
        }

        public IOperationResult<User> CreateUser(User newUser)
        {
            return _usersRepository.Create(newUser);
        }

        public IOperationResult<User> Deactivate(User user)
        {
            user.IsActive = false;
            return _usersRepository.Update(user);
        }
    }
}
