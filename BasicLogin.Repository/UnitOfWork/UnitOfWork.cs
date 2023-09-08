using BasicLogin.Model;
using BasicLogin.Repository.GenericRepository;

namespace BasicLogin.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _context { get; set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            this._context = context;
        }

        private IRepository<EmployeeInfo> tblEmployeeInfoRepository;
        public IRepository<EmployeeInfo> TblEmployeeInfoRepository
        {
            get
            {
                if (this.tblEmployeeInfoRepository == null)
                {
                    this.tblEmployeeInfoRepository = new RepositoryImplementation<EmployeeInfo>(_context);
                }
                return tblEmployeeInfoRepository;
            }
        }
    }
}
