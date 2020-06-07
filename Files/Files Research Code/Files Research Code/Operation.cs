using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Files_Research_Code
{
    class Operation
    {

        public void choose_operation()
        {
            
            
            String choice = Console.ReadLine();
            if (choice == "1")
            {
                search_by_id();
            }

            if (choice == "2")
            {
                search_by_city_name();
            }
            Console.ReadLine();

        }

        //==========================================================

        public void search_by_id()
        {
            int num = 0;


            Console.Write("Enter ID :");
            int id = Convert.ToInt32(Console.ReadLine());

            XElement file = XElement.Load("Entry_Indices_Table.xml");
            XElement[] arr = file.Elements("data").ToArray();

            Boolean ch = false;
            for (int i = 0; i < arr.Length; i++)
            {

                int x = i + 1;
                if (i < arr.Length - 1)
                {

                    var rrr = arr[i].FirstNode as XElement;
                    var n444 = rrr.Name;
                    var v444 = rrr.Value;

                    var rr = arr[x].FirstNode as XElement;
                    var n4444 = rr.Name;
                    var v4444 = rr.Value;

                    var rrr1 = arr[i].FirstNode.NextNode as XElement;
                    var n4441 = rrr1.Name;
                    var v4441 = rrr1.Value;

                    int com = Convert.ToInt32(v444.ToString());

                    int com2 = Convert.ToInt32(v4444.ToString());
                    num++;
                    if (id >= com && id < com2)
                    {
                        String g = v4441.ToString();
                        XElement xdoc = XElement.Load(g);
                        XElement[] ss = xdoc.Elements("people").ToArray();
                        for (int ii = 0; ii < ss.Length; ii++)
                        {
                            num++;
                            var dfff = ss[ii].FirstNode as XElement;
                            var v111 = dfff.Value;
                            int rt = Convert.ToInt32(v111);
                            if (id == rt)
                            {
                                Console.Write("\nThe number of Iterations is :   ");
                                Console.WriteLine(num);
                                ch = true;
                                break;
                            }
                        }
                    }


                }
                if (ch == true)
                    break;
            }
            if (ch == false)
            {

                var rrr1 = arr[arr.Length - 1].FirstNode.NextNode as XElement;
                var n4441 = rrr1.Name;
                var v4441 = rrr1.Value;
                XElement xdoc = XElement.Load(v4441.ToString());
                XElement[] ss = xdoc.Elements("people").ToArray();
                for (int ii = 0; ii < ss.Length; ii++)
                {
                    num++;
                    var dfff = ss[ii].FirstNode as XElement;
                    var v111 = dfff.Value;
                    int rt = Convert.ToInt32(v111);
                    if (id == rt)
                    {
                        Console.Write("\nThe number of Iterations is :   ");
                        Console.WriteLine(num);
                    }
                }
            }
        }

        //================================================================================
        public void search_by_city_name()
        {
            int count = 1;
            Console.Write("Enter the city : ");
            String city = Console.ReadLine();

            XElement file = XElement.Load("people.xml");
            XElement[] arr = file.Elements("people").ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                var or = arr[i].LastNode.PreviousNode as XElement;
                var nam = or.Name;
                var val = or.Value;
                if (val == city)
                {
                    Console.Write("\nThe number of Iterations is :   ");
                    Console.WriteLine(count);
                }
                count++;
            }
        }

    }
}
