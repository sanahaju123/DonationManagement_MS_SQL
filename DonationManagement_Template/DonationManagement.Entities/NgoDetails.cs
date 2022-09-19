using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonationManagement.Entities
{
    public class NgoDetails
    {
            public long NgoId { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public DateTime StartedIn { get; set; }

            public string FilePath { get; set; }

            public bool IsDeleted { get; set; }
    }
}
