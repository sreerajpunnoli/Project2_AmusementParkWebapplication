namespace ProjectNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RideDetail")]
    public partial class RideDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime RideDay { get; set; }

        public int? RideSeats { get; set; }
    }
}
