using People.Server.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace People.Server.ServiceContracts
{

    [ServiceContract]
    public interface IPeopleContract
    {

        [OperationContract]
        void Insert(PersonDTO person);
    }
}
