using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll_practice;
using System.Data;
using System.Data.SqlClient;

namespace Finalproject
{
    class Program
    {

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-51F9O9S;Initial Catalog=Nepties;Integrated Security=True");
        //public void Select(string data)
        //{
            
        //    try
        //    {
        //        Console.WriteLine("Enter table Name :");
        //        string name = Console.ReadLine();
        //        string totalcolls = "select COUNT(*) as totalcolumn from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" + name + "'";
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(data, con);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            for (int i = 0; i < 2; i++)
        //            {
        //                Console.Write(dr[i].ToString());
        //            }

        //        }
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Invalid Query" + ex.ToString());
        //    }
        //}
        static void Main(string[] args)
        {
            try
            {
                DatabaseDML d = new DatabaseDML();
                Console.WriteLine("****************************");
                Console.WriteLine("1.Select            2.Insert");
                Console.WriteLine("****************************");
                Console.WriteLine("Enter Choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter Query:");
                    string query = Console.ReadLine();
                    d.Select(query);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Database Error :" + ex.ToString());
            }


            Console.ReadLine();
        }
    }
}
