using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Models
{
    public class Publication(int id, string title, int publishedOn)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public int PublishedOn { get; set; } = publishedOn;
    }
}