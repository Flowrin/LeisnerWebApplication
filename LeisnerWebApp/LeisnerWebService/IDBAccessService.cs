using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LeisnerWebApp.App_Code;
namespace LeisnerWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDBAccessService
    {

        [OperationContract]
     void  FindPerson();

        [OperationContract]
      List<Person> FindAllPersons();
        [OperationContract]
        void FindTime();
        [OperationContract]
        List<Time> FindAllTimes();
        [OperationContract]
        void SavePerson(int status, string email, string password, string name, string address, string childName, string doctor, string dateOfBirth);
    }
}


