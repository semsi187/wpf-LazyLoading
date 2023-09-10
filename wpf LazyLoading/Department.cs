using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_LazyLoading
{
    public partial class Department
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
