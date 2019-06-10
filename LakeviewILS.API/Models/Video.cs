using System.ComponentModel.DataAnnotations;

namespace LakeviewILS.API.Models
{
    public class Video : LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
