using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Files_Research_Code
{
    class Program 
    {
        //sortedTable is an array carries all the ids after sorting in ascending order
        public static XElement[] sortedTable ;
        static void Main(string[] args)
        {
            /* Class Data contains 4 functions that I used
             * 
             * fill_all_data: Here I make the xml file"people" that contain the whole unsorted data.
             * 
             * sort_all_data: Here I sort all the data that in "people" file, in ascending order according to the ID
             * 
             * split: Here I split the xml file that contains all the data to 4 xml files
             * split takes three parameters, first:  start index that in the array 
             *                               sceond: end index that will be in the specific xml file
             *                               third : the name of the file that I want to be.          
             *                               
             * make_small_file_to_store_entry_indexes: Here I make a xml file called "Entry_Indices_Table" to carry the entry indexes 
             * for the four files. to apply the concept of clustering very well.
            */
            Data data_obj = new Data();
            data_obj.fill_all_data();
            data_obj.sort_all_data();
            data_obj.split(0  , 9 , "cluster_1.xml");
            data_obj.split(10 , 19 , "cluster_2.xml");
            data_obj.split(20 , 29 , "cluster_3.xml");
            data_obj.split(30 , 39 , "cluster_4.xml");
            data_obj.make_small_file_to_store_entry_indexes();

            Console.WriteLine("Enter 1 to search by ID ");
            Console.WriteLine("Enter 2 to search by name ");
            Console.Write("Enter your choice : ");

            /* Class Operation contains three mehods.
             * 
             * choose_operation: this functions is considered as the main function for the next 2 methods that in class "Operation"
             * 
             * search_by_id: Here the user can enter the id that he want and the output'll be the number of iterations 
             * 
             * search_by_city_name: Here the user can enter the city name that he want and the output'll be the number of iterations 
             */
            Operation operation_obj = new Operation();
            operation_obj.choose_operation();
        }
    }
}
