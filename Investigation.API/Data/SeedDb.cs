using Investigation.API.Helpers;
using Investigation.Shared.Entities;
using Investigation.Shared.Enums;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace Investigation.API.Data
{
    public class SeedDb
    {

        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProjectAsync();
            await CheckRoleAsync();
            await CheckUserAsync("1010", "Super", "Admin", "orlapez@gnmail.com", "3015555555", "Cr 25 8965", UserType.Admin);

        }

        private async Task CheckRoleAsync()
        {

            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());

        }
        private async Task<User> CheckUserAsync(string document, string firstname, string lastname, string email, string phone, string address, UserType userType)
        {

            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {

                    Document = document,
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    PhoneNumber = phone,
                    UserName = email,
                    Address = address,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
            return user;
        }

        private async Task CheckProjectAsync()
        {
            if (!_context.Investigadores.Any())
            {

                _context.Investigadores.Add(new Investigador { Nombre = "Juan", afiliacion = "ETS", Cedula = "12345", especialidad = "Ver anime" });
                _context.Investigadores.Add(new Investigador { Nombre = "Brayan", afiliacion = "EPM", Cedula = "54321", especialidad = "Jugar DarkSouls" });

            }



            await _context.SaveChangesAsync();

        }
    }
}
