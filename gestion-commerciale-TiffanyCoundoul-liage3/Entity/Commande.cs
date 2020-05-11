namespace gestion_commerciale_TiffanyCoundoul_liage3.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande")]
    public partial class Commande
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public double? QteCommande { get; set; }

        public double? Montant { get; set; }

        public int? Id_Client { get; set; }

        public int? Id_Article { get; set; }
    }
}
