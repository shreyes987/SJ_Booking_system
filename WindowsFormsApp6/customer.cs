namespace WindowsFormsApp6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string TicketsNo { get; set; }

        [StringLength(50)]
        public string From { get; set; }

        [StringLength(50)]
        public string To { get; set; }
    }
}
