using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageDBoevning
{
    public class UserManager
    {
        

        public void CreateUserAcc(string userName, string pw)
        {
            using (var context = new AppDbContext())
            {
                var newUser = new User
                {
                    Username = userName,
                    PasswordHash = pw
                };

                context.Users.Add(newUser);

                context.SaveChanges();
                Console.WriteLine($"{userName} registrerades i databasen.");
            }
            
                
            
        }
    }
}
