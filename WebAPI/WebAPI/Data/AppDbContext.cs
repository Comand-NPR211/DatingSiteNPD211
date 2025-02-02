using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using WebAPI.Data.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebAPI.Data.Entities.Identity;

namespace WebAPI.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Додайте інші таблиці, якщо потрібно

}
