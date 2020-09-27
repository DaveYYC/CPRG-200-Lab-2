using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Hahner_CPRG_200_Lab2
{
    public static class CustomerList
    {
        const string path = "Customers.txt"; // file name for the .txt file required
        /// <summary>
        /// Reads from the file if it exists; or creates an empty file
        /// </summary>
        /// <returns>
        /// List of customers if file existed, or empty list otherwise
        /// </returns>
        public static List<Customer> ReadCustomers()
        {
            List<Customer> customers = new List<Customer>(); // empty list
            FileStream fs = null;
            StreamReader sr = null;

            // for reading
            string line;    // the read line
            string[] parts; // the split string array
            try
            {
                // open the file for reading (if the first time, the file doesn't exist)
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read the data
                while (!sr.EndOfStream) // while there is still data
                {
                    line = sr.ReadLine();
                    parts = line.Split(','); // split at the commas 
                    // create another customer and add to the customer list
                    Customer c = new Customer();
                    c.CustomerType = parts[0];
                    c.AccountNo = Convert.ToInt32(parts[1]);
                    c.CustomerName = parts[2];
                    c.ChargeAmount = Convert.ToDouble(parts[3]);
                    customers.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw ex; // pass it to the calling code
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return customers;
        }

        // save the list to the .txt file
        public static void SaveCustomers(List<Customer> customers)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // open the file for writing and overwrite any old content
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                // save data
                foreach (Customer c in customers)
                    sw.WriteLine(c.ToFileLine());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}