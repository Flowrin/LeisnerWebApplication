using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LeisnerWebApp.App_Code;
using LeisnerWebService.Classes;
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
        void SavePerson(int Status, string Email, string Password, string Name, string Address, string ChildsName, string Doctor, string DateOfBirth);
        [OperationContract]
        void SaveHour(string Hour);
        [OperationContract]
        List<Common> FindInfo();
        [OperationContract]
        void SaveInfo(Person personId, Week weekId, Time hourId, Day dayId, PeePee peePeeId);
    }
}


