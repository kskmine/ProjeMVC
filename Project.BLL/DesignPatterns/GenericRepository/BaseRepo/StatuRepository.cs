using Project.BLL.DesignPatterns.GenericRepository.ConcRepo;
using Project.DAL.ContextClasses;
using Project.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRepo
{
    public class StatuRepository : RepositoryBase<Statu>, IStatuRepository
    {
        public StatuRepository(AnketDbContext context) : base(context)
        {

        }
    }
}
