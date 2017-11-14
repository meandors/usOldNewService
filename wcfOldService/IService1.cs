﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfOldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        Person[] GetPersons();
        [OperationContract]
        Person GetPerson(int id);
        [OperationContract]
        void AddPerson(Person person);
        [OperationContract]
        void ModifyPerson(Person person);
        [OperationContract]
        int GetArraySize();
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
    }
}
