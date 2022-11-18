using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUW_DAL.Abstract
{
   public interface IGenericDal<T> where T: class
    {
        void Update(T t);
        void Delete(T t);
        void Insert(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
