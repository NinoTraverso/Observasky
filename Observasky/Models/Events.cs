namespace Observasky.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class Events
    {
        [Key]
        public int IdEvent { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [NotMapped]
        public HttpPostedFileBase Image { get; set; }
        public string Photo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
