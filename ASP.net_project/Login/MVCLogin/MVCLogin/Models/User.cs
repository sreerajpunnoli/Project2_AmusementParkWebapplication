namespace MVCLogin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="This field is required")]
        [StringLength(50)]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(100)]
        public string Password { get; set; }

        public string LoginErrorMessage
        {
            get;
            set;
        }

    }
}
