using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class NewsProxy
    {
        [Key]
        public int NewsId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string HashTags { get; set; }
        //string HashTags = "...";
        //List<> HashTagsList = Arrays.asList(Hashtags.split(","));
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
