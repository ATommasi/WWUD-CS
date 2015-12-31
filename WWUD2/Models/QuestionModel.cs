using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using System.Linq;
using System.Web;

namespace WWUD2.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }

        [Required(ErrorMessage ="You must enter a question")]
        [StringLength(180,MinimumLength =8)]
        public string QuestionContent { get; set; }


        private DateTime _date = DateTime.Now;
        public DateTime AddDate {
            get { return _date; }
            set { _date = value; }
        }

        [ForeignKey("User")]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}