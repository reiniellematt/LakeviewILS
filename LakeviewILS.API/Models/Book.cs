using System.ComponentModel.DataAnnotations;

namespace LakeviewILS.API.Models
{
    public class Book : LibraryAsset
    {
        [Required]
        public string Isbn { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string DeweyIndex { get; set; }
    }
}
