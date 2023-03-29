using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Category
    {// Şimdi biz burda propertyler tanımlayacağız.
     // Bunu da şu şekilde tanımlayacağız:Erişim Belirleyici türü(Access Modifier)- Değişken türü -isim-{get set}
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }  
        public string CategoryDescription { get; set; }
        public bool CategoryStatus{ get; set; }

        //BURDAKİ KOD İLE REFRANSLARI İİLİŞKİLENDİRECEİĞİZ.
        public List<Blog> Blogs { get; set; }

    }
}
