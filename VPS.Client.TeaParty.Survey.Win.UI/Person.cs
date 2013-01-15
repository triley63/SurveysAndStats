using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPS.Client.TeaParty.Survey.Win.UI
{
    public class Person
    {
        #region Private Member Variable
        private CallStatus status;
        private int id;
        private string lastName;
        private string firstName;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zip;
        private List<string> phone = new List<string>();
        #endregion

        #region Public Properties

        public CallStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Address1
        {
            get { return this.address1; }
            set { this.address1 = value; }
        }

        public string Address2
        {
            get { return this.address2; }
            set { this.address2 = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public string Zip
        {
            get { return this.zip; }
            set { this.zip = value; }
        }

        public List<string> Phone
        {
            get { return this.phone; }
        }
        #endregion

        #region Constructors
        public Person() { }

        public Person(CallStatus status
            ,int id
            ,string lastName
            ,string firstName
            ,string address1
            ,string address2
            ,string city
            ,string state
            ,string zip)
        {
            this.status = status;
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
        #endregion

        public void AddPhone(string phoneNumber)
        {
            this.phone.Add(phoneNumber);
        }

        public string Join()
        {
            StringBuilder returnValue = new StringBuilder();
            returnValue.Append(string.Format("{0},", this.status));
            returnValue.Append(string.Format("{0},", this.id));
            returnValue.Append(string.Format("{0},", this.lastName));
            returnValue.Append(string.Format("{0},", this.firstName));
            returnValue.Append(string.Format("{0},", this.address1));
            returnValue.Append(string.Format("{0},", this.address2));
            returnValue.Append(string.Format("{0},", this.city));
            returnValue.Append(string.Format("{0},", this.state));
            returnValue.Append(string.Format("{0},", this.zip));

            foreach (string ph in this.phone)
            {
                returnValue.Append(string.Format("{0},", ph));
            }

            return returnValue.ToString().Substring(0, returnValue.ToString().Length - 1);

        }
    }
}
