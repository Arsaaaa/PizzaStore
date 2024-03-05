using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {

        #region Instance field
        string _name;
        int _price;
        #endregion



        #region Conctructors

        public Pizza(string name, int price)
        {
            _name = name;
            _price = price;


        }
        #endregion
        #region Properties

        public string Name

        { 
            get { return _name; }
            private set { _name = value; }

            #endregion

        }

        public int Price

        {
            get { return _price; }
            private set { _price = value; }

        }

        #region Methods

        public override string ToString()
        {
            return $"Pizza: {Name}, Price: {Price}";

        }

        #endregion
    }
}