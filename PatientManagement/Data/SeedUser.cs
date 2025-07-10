using Microsoft.AspNetCore.Identity;

namespace PatientManagement.Data
{
    public class SeedUser
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string email = "doctor@example.com";
            string password = "Doctor@123";

            if (await userManager.FindByEmailAsync(email) == null)
            {
                var user = new IdentityUser
                {
                    UserName = "doctor",
                    Email = email,
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user, password);
            }
        }
    }

}
