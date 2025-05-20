using CQRS.NET8.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CQRS.NET8;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<UserDto> Users { get; set; }
}