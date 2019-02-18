using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{

    class Customer
    {

        public Customer(string _firstName, string _lastName, string _city)
        {
            FirstName = _firstName;
            LastName = _lastName;
            City = _city;
        }

        public Customer()
        {

        }

        /// <summary>
        /// Méthode static
        /// elle n'est pas appellée sur une instance en cours
        /// Mais sur l'objet static Customer.
        /// </summary>
        public static int DifferenceAge(Customer c1, Customer c2)
        {
            return c2.Birthday.Year - c1.Birthday.Year;
        }

        public static Customer CreateNewCustomer()
        {
            return new Customer();
        }


        private string firstName;
        private string lastName;
        private DateTime birthday;

        /// <summary>
        /// Prénom de mon client
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// Nom de mon client
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        /// <summary>
        /// Date de naissance
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public String City
        {
            get;
            set;
        }

        /// <summary>
        /// Renvoit le prénom, nom et ville
        /// </summary>
        /// <returns></returns>
        public String GetCompleteName()
        {

            return string.Format("Mon client : {0} {1} Ville : {2}", FirstName, LastName, City);

        }


    }
}
