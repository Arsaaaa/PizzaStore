using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Order
    {

        #region Instance field
        private double _tax;
        private int _deliveryFee;
        private Customer _customer;
        private Pizza _pizza;


        #endregion

        #region Properties

        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }

        }


        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }

        }

        public double Tax

        {
            get { return _tax; }
            private set { _tax = value; }

        }

        public int DeliveryFee

        {
            get { return _deliveryFee; }
            private set { _deliveryFee = value; }
        }
        #endregion

        #region Conctructors
        public Order(Pizza pizza, Customer customer)
        {
            Pizza = pizza;
            Customer = customer;
            Tax = 0.25;
            DeliveryFee = 40;
        }

        public override string ToString()
        {
            return $"{Customer.ToString()}, {Pizza.ToString()}, Total Price: {CalculateTotalPrice()} kr.";       
        
        }

        public double CalculateTotalPrice()
        {
            return Pizza.Price + (Pizza.Price * Tax) + DeliveryFee;
        }

        #endregion
    }
}
