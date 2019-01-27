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

        NewsData _newsdata = new NewsData();

        public News MultipleNews = new News()
        {
            NewsId = 1,
            Author = "Jonas Johansen",
            Title = "Kan man tilføje til databasen?",
            Content = "Hvis jeg kan læse det her er det blevet tilfølje til databasen som det skulle",
            CreatedDate = DateTime.Now,
            HashTags = "#PleaseWork,#HåberDetVirker"
        };
        _newData.News.Add(MultipleNews);
        _newData.SaveChanges();
    }
}
