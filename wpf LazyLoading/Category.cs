﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_LazyLoading
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
