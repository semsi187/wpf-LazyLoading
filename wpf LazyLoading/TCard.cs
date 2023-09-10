﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_LazyLoading
{
    public partial class TCard
    {
        public int Id { get; set; }

        public int IdTeacher { get; set; }

        public int IdBook { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime? DateIn { get; set; }

        public int IdLib { get; set; }

        public virtual Book IdBookNavigation { get; set; } = null!;

        public virtual Lib IdLibNavigation { get; set; } = null!;

        public virtual Teacher IdTeacherNavigation { get; set; } = null!;
    }
}
