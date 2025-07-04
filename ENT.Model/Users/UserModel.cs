using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.Users
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string MobileNumber { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public int? UserTypeId { get; set; }
        public string? HouseNumber { get; set; }
        public string? Landmark { get; set; }
        public string? AriaName { get; set; }
        public string? LocationType { get; set; }
    }
}
