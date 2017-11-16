using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfNewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        static List<Person> personsList = new List<Person>();
        public void AddPerson(Person person)
        {
            person.Id = personsList.Count;
            personsList.Add(person);
        }

        public int GetArraySize()
        {
            return personsList.Count;
        }

        public Person GetPerson(int id)
        {
            if (id < personsList.Count && id > -1)
                return personsList.ElementAt(id);
            else
                return new Person();
        }

        public Person[] GetPersons()
        {
            return personsList.ToArray<Person>();
        }

        public void ModifyPerson(Person person)
        {
            personsList.Insert(person.Id, person);
            personsList.RemoveAt(person.Id + 1);
        }
    }
}
