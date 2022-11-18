using OUW_DAL.Concrete;
using OUW_DAL.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUW_DAL.UnitOfWork.Concrete
{
    public class UOWDal : IUOWDal
    {
        private readonly Context _context;

        public UOWDal(Context context)
        {
            _context = context;
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
