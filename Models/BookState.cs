using System;
using System.ComponentModel.DataAnnotations;

namespace XLIB.Models
{
    public class BookState
    {
        // Properties
        [Key]
        public int StatusId { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

    }
}

