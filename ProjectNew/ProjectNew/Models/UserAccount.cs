namespace ProjectNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAccount")]
    public partial class UserAccount
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }


        [DisplayName("User Name")]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50)]
        public string Password { get; set; }

        public string LoginErrorMessage
        {
            get;
            set;
        }

    }
}
