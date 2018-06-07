﻿
using CRMLiteAppService.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRMLiteAppService.Data
{
	public class ApplicationDbContext : IdentityDbContext<AppUser>
	{
		public ApplicationDbContext(DbContextOptions options)
		  : base(options)
		{
		}

		public DbSet<Customer> Customers { get; set; }
	}
}
