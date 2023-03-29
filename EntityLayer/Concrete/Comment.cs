using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Comment
    {
        [Key]
        public int MyPrCommentIdoperty { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentData { get; set; }
        public bool CommentStatus { get; set; }
        //Blog sayfasına yorum yapmak için ilişkilendiriyoruz. çünkü İlişkilendirmekle sayfalar arasında bağlantı sağlayıp
        //birbirleri arasında veri akışı sağlıyabiliyoruz.
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
