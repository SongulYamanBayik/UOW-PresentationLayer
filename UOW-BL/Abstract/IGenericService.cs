using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOW_BL.Abstract
{
   public interface IGenericService<T>
    {
        void TUpdate(T t);
        void TDelete(T t);
        void TInsert(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
