using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace wcfOldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OldService : IPerson
    {

        public void AddPerson(Person person)
        {
            person.Id = PersonsData.personsList.Count;
            PersonsData.personsList.Add(person);
        }

        public int GetArraySize()
        {
            return PersonsData.personsList.Count;
        }

        public Person GetPerson(int id)
        {
            if (id < PersonsData.personsList.Count && id > -1)
                return PersonsData.personsList.ElementAt(id);
            else
                return new Person();
        }

        public Person[] GetPersons()
        {
            return PersonsData.personsList.ToArray<Person>();
        }

        public void ModifyPerson(Person person)
        {
            PersonsData.personsList.Insert(person.Id, person);
            PersonsData.personsList.RemoveAt(person.Id + 1);
        }
    }
}
