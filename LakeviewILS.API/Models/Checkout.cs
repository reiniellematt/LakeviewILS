using System;
using System.ComponentModel.DataAnnotations;

namespace LakeviewILS.API.Models
{
    public class Checkout
    {
        [Required]
        public LibraryAsset LibraryAsset { get; set; }

        public LibraryCard LibraryCard { get; set; }

        public DateTime Since { get; set; }

        public DateTime Until { get; set; }
    }
}