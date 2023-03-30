using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IBlogDal:IGenericDal<Blog>
    {    //Generic repository kullanmadan bu yöntemide uygularız ama bu yöntem ile bağımlılıkları arttırmış oluruz.
        //List<Blog> ListAllCategory();
        // void AddBlog(Blog blog);
       // void DeleteBlog(Blog blog);
      // void UpdateBlog(Blog blog);
        //Id ye göre veri getirebilmek için bu metodu tanımladık.
        //Id ye göre veri getirmemiz şart çünkü crud işlemlerini ona göre yapacağız.
     //   Blog GetById(int id);
    }
}
