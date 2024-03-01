using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {

        #region Instance field

        private string _name;


        #endregion

        #region Properties
        public string Name
        {

            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region Conctructors
        public Customer(string name)
        {
            Name = name;
        }
        #endregion
        public override string ToString()
        {
            return $"Customer: {Name}";


        } 
    
    }
}
