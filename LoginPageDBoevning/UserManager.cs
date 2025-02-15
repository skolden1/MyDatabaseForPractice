using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageDBoevning
{
    public class UserManager
    {
        private readonly AppDbContext _context;
        public UserManager(AppDbContext context)
        {
            _context = context;
        }

        public void CreateUserAcc(string userName, string pw)
        {
            
                var newUser = new User
                {
                    Username = userName,
                    PasswordHash = pw
                };

                _context.Users.Add(newUser);

                _context.SaveChanges();
                Console.WriteLine($"{userName} registrerades i databasen.");
            
        }
    }
}
