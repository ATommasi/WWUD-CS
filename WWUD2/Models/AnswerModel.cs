using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WUDIF.Models
{
    public class Answer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerID { get; set; }

        [Required(ErrorMessage = "You must enter an answer")]
        [StringLength(180, MinimumLength = 8, ErrorMessage ="Answer must be between 8 and 180 characters")]
        public string AnswerContent { get; set; }


        private DateTime _date = DateTime.Now;
        public DateTime AddDate
        {
            get { return _date; }
            set { _date = value; }
        }

        [ForeignKey("Question")]
        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}