using System;
using System.ComponentModel.DataAnnotations;

namespace News.Models {
    public class NewsModel {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime? LastUpdatedTime { get; set; }
    }
}