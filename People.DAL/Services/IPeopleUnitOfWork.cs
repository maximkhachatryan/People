using People.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.DAL.Services
{
    public interface IPeopleUnitOfWork
    {
        IPeopleRepository<Person> FolksRepo { get; }

        //Here can be also added repos for another entities

        void Complete();
    }
}
