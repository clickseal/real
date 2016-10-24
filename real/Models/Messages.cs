using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace real.Models
{
    public class Messages
    {
        public string Mobile { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm - yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Ognoo { get; set; }
    }

    public class QuizAsuult
    {
        public int Id { get; set; }
        public string Title{ get; set; }
    }

    public class QuizHariult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Is_true { get; set; }
        public int Test_id { get; set; }
    }
}