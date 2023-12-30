using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class UserAdressEntity
    {
        [Key, ForeignKey(nameof(User))]
        public int Id { get; set;}
        public string? CityName { get; set; } = string.Empty;
        public string? StreetName { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
        public string? PostalCode { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;

        public UserEntity User { get; set; }
    }
}
