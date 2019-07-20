namespace LoginApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login")]
    public partial class login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoginID { get; set; }

        public string Password { get; set; }
    }
}
