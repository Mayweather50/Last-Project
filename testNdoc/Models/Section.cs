using System;
using System.Collections.Generic;


namespace testNdoc
{
    public  class Section
    {
        public Section()
        {
            Documents = new HashSet<Documents>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsRemove { get; set; }

        public virtual ICollection<Documents> Documents { get; set; }
    }
}
