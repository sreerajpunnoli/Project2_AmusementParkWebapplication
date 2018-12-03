namespace ProjectNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketDetail")]
    public partial class TicketDetail
    {
        [Key]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime TicketDay { get; set; }

        public int? AvailableSeatCount { get; set; }
    }
}
