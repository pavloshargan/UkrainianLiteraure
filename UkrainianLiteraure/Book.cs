namespace UkrainianLiteraure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Heroes = new HashSet<Hero>();
        }

        public int Id { get; set; }

        public string Path { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Style { get; set; }

        public string Theme { get; set; }

        public string Idea { get; set; }

        public string Description { get; set; }

        public string PlacesOfActions { get; set; }

        public int? BookAuthor_Id { get; set; }

        public virtual Author Author { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hero> Heroes { get; set; }
    }
}
