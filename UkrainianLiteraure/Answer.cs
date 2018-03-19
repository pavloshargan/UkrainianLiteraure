namespace UkrainianLiteraure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answer
    {
        public int Id { get; set; }

        public string AnswerText { get; set; }

        public bool IsTrue { get; set; }

        public int? Question_Id { get; set; }

        public virtual Question Question { get; set; }
    }
}
