using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
        public void Start()
        { 
        
             // Creating pizzas
             Pizza pizza1 = new Pizza("Sole",78);
             Pizza pizza2 = new Pizza("Naples",79);
             Pizza pizza3 = new Pizza("Italiana",75);

            //Creating customer
            Customer customer1 = new Customer("Hans");
            Customer customer2 = new Customer("Hassan");
            Customer customer3 = new Customer("Ali");

            //Creating order
            Order order1 = new Order(pizza1, customer2);
            Order order2 = new Order(pizza2, customer3);    
            Order order3 = new Order(pizza3, customer1);



            //Printing out order information
            Console.WriteLine(order1);  
            Console.WriteLine(order2);   
            Console.WriteLine(order3);   

  
        
        
        }

        #region Instance field

        




        #endregion

        #region Properties





        #endregion

        #region Conctructors





        #endregion




    }
}
