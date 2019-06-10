using System;
using System.ComponentModel.DataAnnotations;

namespace LakeviewILS.API.Models
{
    public class Patron
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }

        public virtual LibraryBranch LibraryBranch { get; set; }
    }
}