﻿using FreshBooks.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshBooks.Models
{
    public class Book : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Edition { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string imagesURL { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public BookUser BookUser { get; set; }

        /*        public List<Author_Books> Author_Books { get; set; }
        */
    }
}
