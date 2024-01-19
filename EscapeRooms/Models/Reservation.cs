using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscapeRooms.Models
{
    
    public class Reservation
    {
        public int Id { get; set; }
        public  DateTime DateTime { get; set; }
        public string Description { get; set; }
        public int RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public virtual Room? Room { get; set; }
    }
    }

