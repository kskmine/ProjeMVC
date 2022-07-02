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
    public class PersonelRepository : RepositoryBase<Personel>, IPersonelRepository
    {
        public PersonelRepository(AnketDbContext context) : base(context)
        {

        }
    }
}
