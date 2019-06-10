using System.ComponentModel.DataAnnotations;

namespace LakeviewILS.API.Models
{
    public class BranchHours
    {
        public int Id { get; set; }

        public LibraryBranch LibraryBranch { get; set; }

        [Range(0, 6)]
        public int DayOfTheWeek { get; set; }

        [Range(0, 23)]
        public int OpenTime { get; set; }

        [Range(0, 23)]
        public int CloseTime { get; set; }
    }
}
