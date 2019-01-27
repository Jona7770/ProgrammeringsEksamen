using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class NewsData : DbContext
    {
       
         public NewsData(DbContextOptions<NewsData> options) : base(options)
            {
                Database.EnsureCreated();
            }
         public DbSet<News> MultipleNews { get; set; }

        
    }
}
