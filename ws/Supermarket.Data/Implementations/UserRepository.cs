﻿using Microsoft.EntityFrameworkCore;
using Supermarket.Data.Context;
using Supermarket.Data.Repository;
using Supermarket.Domain.Entities;
using Supermarket.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Supermarket.Data.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private DbSet<User> _database;

        public UserRepository(MyContext context) : base(context)
        {
            _database = context.Set<User>();
        }

        public async Task<User> FindByLogin(string email)
        {
            return await _database.FirstOrDefaultAsync(user => user.Email.Equals(email));
        }
    }
}
