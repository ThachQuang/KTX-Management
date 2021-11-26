using R2S.Training.Dao;
using R2S.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2S.Training.Main
{
    class SaleManagement
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            GetAllCustomers();
            AddCustomer();
            DeleteCustomer();
            UpdateCustomer();

        }

        static int InputInt()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.Write("Input only numbers: ");
                }
            }
        }

        /// <summary>
        /// CHECK IF ORDER ID EXISTS
        /// </summary>
        /// <param name="order_id"></param>
        /// <returns></returns>
        static bool IsExistOrderID(int order_id)
        {
            try
            {
                const string CheckOrderID = @"SELECT count (*) FROM LineItem WHERE order_id = @id ";
                object[] para = new object[] { order_id };
                object count = DataProvider.Instance.ExecuteScalar(CheckOrderID, para);
                return (int)count != 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// CHECK IF CUSTOMER ID EXISTS
        /// </summary>
        /// <param name="customer_id"></param>
        /// <returns></returns>
        static bool IsExistCustomerID(int customer_id)
        {
            try
            {
                const string CheckCustomerID = @"SELECT count (*) FROM Customer WHERE customer_id = @id ";
                object[] para = new object[] { customer_id };
                object count = DataProvider.Instance.ExecuteScalar(CheckCustomerID, para);
                return (int)count != 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// CHECK IF PRODUCT ID EXISTS
        /// </summary>
        /// <param name="product_id"></param>
        /// <returns></returns>
        static bool IsExistProductID(int product_id)
        {
            try
            {
                const string CheckProductID = @"SELECT count (*) FROM Product WHERE product_id = @id ";
                object[] para = new object[] { product_id };
                object count = DataProvider.Instance.ExecuteScalar(CheckProductID, para);
                return (int)count != 0;
            }
            catch
            {
                return false;
            }
        }

        //Func1
        static void GetAllCustomers()
        {
            List<Customer> customers = CustomerDAO.Instance.GetAllCustomer();

            if (customers.Count == 0)
                Console.WriteLine("No customer found!");
            else
            {
                foreach (Customer customer in customers)
                {
                    Console.Write(customer.CustomerId + " ");
                    Console.WriteLine(customer.CustomerName);
                }
            }
        }

        //Func5
        static void AddCustomer()
        {
            Customer customer = new Customer();
            Console.Write("Enter customer name: ");
            customer.CustomerName = Console.ReadLine();

            bool status = CustomerDAO.Instance.AddCustomer(customer);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }

        //Func6
        static void DeleteCustomer()
        {
            int customer_id;
            while (true)
            {
                Console.Write("Enter customer ID: ");
                customer_id = InputInt();

                if (IsExistCustomerID(customer_id))
                    break;
                Console.WriteLine("Customer ID does not exist!");
            }

            bool status = CustomerDAO.Instance.DeleteCustomer(customer_id);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }

        //Func7
        static void UpdateCustomer()
        {
            int customer_id;
            while (true)
            {
                Console.Write("Enter customer ID: ");
                customer_id = InputInt();

                if (IsExistCustomerID(customer_id))
                    break;
                Console.WriteLine("Customer ID does not exist!");
            }

            Console.Write("Enter customer name: ");
            string customer_name = Console.ReadLine();

            Customer customer = new Customer(customer_id, customer_name);

            bool status = CustomerDAO.Instance.UpdateCustomer(customer);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }

        // Fun 9
        static void AddLineItem()
        {
            LineItem item = new LineItem();

            int order_id;
            while (true)
            {
                Console.Write("Enter order ID: ");
                order_id = InputInt();

                if (IsExistOrderID(order_id))
                    break;
                Console.WriteLine("Order ID does not exist!");
            }
            item.OrderId = order_id;

            int product_id;
            while (true)
            {
                Console.Write("Enter product ID: ");
                product_id = InputInt();

                if (IsExistProductID(product_id))
                    break;
                Console.WriteLine("Product ID does not exist!");
            }
            item.ProductId = product_id;

            Console.Write("Enter quantity: ");
            item.Quantity = InputInt();

            Console.Write("Enter price: ");
            item.Price = Convert.ToDouble(Console.ReadLine());

            bool status = LineItemDAO.Instance.AddLineItem(item);

            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
    }
}