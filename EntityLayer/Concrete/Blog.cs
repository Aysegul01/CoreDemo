using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Blog
    {
        [Key]
        public int BlogId { get; set; } 
        public string BlogTitle { get; set; }
        public string BlogThumbnailıamge { get; set; }
        public string MyProperty { get; set; }
        public string BlogContent { get; set; } 
        public string BlogCreateDate { get; set; }
        public string BlogStatus{ get; set; }
        //Referans Category İlişkilendiriyoruz.
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //Burda Blog kısmını yorum(Comment) bölümüyle ilişkilendiriyoruz.
        public List<Comment> Comments { get; set; }


    }
}
