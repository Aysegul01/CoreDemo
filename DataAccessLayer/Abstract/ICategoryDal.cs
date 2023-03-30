using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal:IGenericDal<Category>
    {// bu aşağadaki yöntem generic repository kullanmadan uyguluyoruz.
       // List<Category> ListAllCategory();
      //  void AddCategory(Category category);
     //   void DeleteCategory(Category category);
     //   void UpdateCategory(Category category);
        //Id ye göre veri getirebilmek için bu metodu tanımladık.
        //Id ye göre veri getirmemiz şart çünkü crud işlemlerini ona göre yapacağız.
       // Category GetById(int id);
        
    }
}
