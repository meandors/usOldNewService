using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewClientApp.ServiceRef;
using System.Diagnostics;

namespace OldClientApp
{
    public partial class ClientApp : Form
    {
        public ClientApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            Person person = new Person();
            person.Name = tbName.Text;
            person.Surname = tbSurname.Text;
            person.BirthDate = dtAddBirth.Value;
            Debug.WriteLine("Dodawanie...");
            try
            {

                client.Open();
                client.AddPerson(person);
                Debug.WriteLine("Dodano!");
                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }

        private void bGetAll_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            Debug.WriteLine("Wykonano pobieranie clientow:");
            try
            {
                client.Open();
                if (client.GetArraySize() < 1)
                {
                    MessageBox.Show("Brak osob w bazie!");
                }
                else
                {
                    Person[] persons = client.GetPersons();
                    lbClients.Items.Clear();
                    foreach (var person in persons)
                    {
                        string res = "Id: " + person.Id + "  |  Name: " + person.Name + "  |  Surname: " 
                            + person.Surname + "   |   Birthday date: " + person.BirthDate.ToShortDateString();
                        Debug.WriteLine(res);
                        lbClients.Items.Add(res);
                    }
                }
                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }

        private void bGetByID_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            Debug.WriteLine("Wykonano pobieranie clientow:");
            try
            {
                client.Open();
                Person person = client.GetPerson((int)nClientID.Value);
                if (person.Name == "")
                {
                    MessageBox.Show("Brak osoby o ID: " + nClientID.Value);
                }
                else
                {
                    string res = "Id: " + person.Id + "  |  Name: " + person.Name + "  |  Surname: " 
                        + person.Surname + "   |   Birthday date: "+person.BirthDate.ToShortDateString();
                    Debug.WriteLine(res);
                    lbClients.Items.Clear();
                    lbClients.Items.Add(res);
                }
                client.Close();
                client.Close();
                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            Person person = new Person();
            person.Id = (int)nModID.Value;
            person.Name = tbModName.Text;
            person.Surname = tbModSurname.Text;
            person.BirthDate = dtModBirth.Value;
            try
            {
                client.Open();
                client.ModifyPerson(person);
                Debug.WriteLine(client.GetArraySize());
                client.Close();
            }
            catch
            {
                client.Abort();
            }
            
        }
    }
}
