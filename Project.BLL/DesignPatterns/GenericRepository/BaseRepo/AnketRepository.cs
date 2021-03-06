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
    public class AnketRepository : RepositoryBase<Anket>, IAnketRepository
    {
        public AnketRepository(AnketDbContext context) : base(context)
        {

        }
    }
}
