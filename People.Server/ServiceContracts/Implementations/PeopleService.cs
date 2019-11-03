using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using People.DAL.Entities;
using People.DAL.Services;
using People.Server.DataContracts;

namespace People.Server.ServiceContracts.Implementations
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    class PeopleService : IPeopleContract
    {
        readonly IPeopleUnitOfWork _unitOfWork;
        public PeopleService(IPeopleUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Insert(PersonDTO person)
        {
            _unitOfWork.FolksRepo.Create(new Person //TODO: Use Mapper
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Notes = person.Notes,
                Email = person.Email,
                Phone = person.Phone,
                CrDate = person.CrDate
            });
        }
    }
}
