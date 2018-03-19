namespace UkrainianLiteraure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Periphrases")]
    public partial class Periphras
    {
        public int Id { get; set; }

        public string PeriphraseName { get; set; }

        public int? PeriphraseOwner_Id { get; set; }

        public virtual Author Author { get; set; }
    }
}
