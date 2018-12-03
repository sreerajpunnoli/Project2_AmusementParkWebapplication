namespace ProjectNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketBooking")]
    public partial class TicketBooking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime BookedTicketDate { get; set; }

        public int SeatsCount { get; set; }

        public int TransactionId { get; set; }
    }
}
