using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Company
    {
        public int ID { get; private set; }
        public string CompanyName { get; private set; }
        public int Code { get; private set; }
        public string Department { get; private set; }
        public string HeadName { get; private set; }
        public string Date { get; private set; }
        public string Time { get; private set; }
        public string Comment { get; private set; }
        public string Payment { get; private set; }
        public int Edition { get; private set; }
        public User User { get; private set; }
        public List<Contact> Contacts { get; set; } 


        public Company() { }
        public Company(int id, string company, string head, DateTime date, string comment, List<Contact> contacts)
        {
            ID = id;
            CompanyName = company;
            HeadName = head;
            Date = date.ToString("MM.dd");
            Time = date.ToString("HH:mm");
            Comment = comment;
            Contacts = contacts;
        }
        public Company(int id, string company, int code, string payment, int edition,
            string department, string head, DateTime date, string comment, User user, List<Contact> contacts)
        {
            ID = id;
            Department = department;
            Code = code;
            CompanyName = company;
            HeadName = head;
            Date = date.ToString("MM.dd");
            Time = date.ToString("HH:mm");
            Comment = comment;
            Payment = payment;
            Edition = edition;
            User = user;
            Contacts = contacts;
        }
    }
}
