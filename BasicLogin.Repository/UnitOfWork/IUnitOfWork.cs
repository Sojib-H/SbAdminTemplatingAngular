using BasicLogin.Model;
using BasicLogin.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<EmployeeInfo> TblEmployeeInfoRepository { get; }
    }
}
