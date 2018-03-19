namespace UkrainianLiteraure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hero
    {
        public int Id { get; set; }

        public string HeroName { get; set; }

        public string Description { get; set; }

        public int? HerosBook_Id { get; set; }

        public virtual Book Book { get; set; }
    }
}