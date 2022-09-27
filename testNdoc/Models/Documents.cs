using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace testNdoc
{
    public partial class Documents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public bool? IsRemove { get; set; }

        public virtual Section Section { get; set; }
    }
}
