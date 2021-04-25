using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatProject.Models
{
    class Lesson
    {
        public long MentorId { get; set; }
        public long StudentGroupId { get; set; }
        public long ThemeId { get; set; }
        public DateTime LessonDate { get; set; }

        //public  Mentor Mentor { get; set; }

        //public  StudentGroup StudentGroup { get; set; }

        public  Theme Theme { get; set; }

       // public virtual IList<Visit> Visits { get; set; }
    }
}
