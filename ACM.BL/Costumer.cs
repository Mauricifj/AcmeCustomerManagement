using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Costumer
    {
        public Costumer()
        {

        }
        public Costumer(int costumerId)
        {
            this.CostumerId = costumerId;
        }
        public static int InstanceCount { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CostumerId { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        ///<summary>
        ///Retrieve one costumer
        /// </summary>
        public Costumer Retrieve(int costumerId)
        {
            // Code that retrieves the defined costumer
            return new Costumer();
        }

        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        public List<Costumer> Retrieve()
        {
            return new List<Costumer>();
        }

        /// <summary>
        /// Save the current costumer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined costumer
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}