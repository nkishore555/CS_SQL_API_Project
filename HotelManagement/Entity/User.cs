using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Entity
{
    public class User
    {

        public int UserId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
