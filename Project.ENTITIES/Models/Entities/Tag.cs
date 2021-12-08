using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.Entities
{
    public class Tag:BaseEntity
    {
        public string TagName { get; set; }
        public string TagDescription { get; set; }
        public bool IsChecked { get; set; }

        public virtual List<PostTag> PostTags { get; set; }
    }
}
