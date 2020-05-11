namespace gestion_commerciale_TiffanyCoundoul_liage3.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(50)]
        public string Libelle { get; set; }

        public double? Stock { get; set; }

        public double? Prix { get; set; }

        [StringLength(50)]
        public string Categorie { get; set; }
    }
}
