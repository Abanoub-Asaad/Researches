using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml;
using System.IO;
using System.Xml.Linq;
namespace Files_Research_Code
{
    class Data
    {
        public void fill_all_data()
        {
            XDocument xmlDocumente = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

                     new XElement("peoples",

                        new XElement("people",
                        new XElement("ID", 1),
                        new XElement("Name", "Ali"),
                        new XElement("city", "New Cairo"),
                        new XElement("country", "egypt")),


                        new XElement("people",
                        new XElement("ID", 2),
                        new XElement("Name", "Ahmed"),
                        new XElement("city", "6th of October"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 3),
                        new XElement("Name", "alaa"),
                        new XElement("city", "15th of May"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 4),
                        new XElement("Name", "sayed"),
                        new XElement("city", "Akhmim"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 5),
                        new XElement("Name", "rana"),
                        new XElement("city", "Alexandria"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 6),
                        new XElement("Name", "mohamed"),
                        new XElement("city", "Arish"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 7),
                        new XElement("Name", "Mina"),
                        new XElement("city", "Aswan"),
                        new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 13),
                      new XElement("Name", "alaa"),
                      new XElement("city", "Beni Ebeid"),
                      new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 14),
                      new XElement("Name", "sayed"),
                      new XElement("city", "Bilbeis"),
                      new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 15),
                      new XElement("Name", "rana"),
                      new XElement("city", "Cairo"),
                      new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 8),
                        new XElement("Name", "tamam"),
                        new XElement("city", "Asyut"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 9),
                        new XElement("Name", "kero"),
                        new XElement("city", "Badr"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 10),
                        new XElement("Name", "abdalla"),
                        new XElement("city", "Banha"),
                        new XElement("country", "egypt")),

                        new XElement("people",
                        new XElement("ID", 11),
                        new XElement("Name", "Mark"),
                        new XElement("city", "Belqas"),
                        new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 12),
                       new XElement("Name", "osama"),
                       new XElement("city", "Beni Mazar"),
                       new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 16),
                      new XElement("Name", "mariam"),
                      new XElement("city", "Dahab"),
                      new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 17),
                      new XElement("Name", "ali"),
                      new XElement("city", "Dairut"),
                      new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 18),
                      new XElement("Name", "tamam"),
                      new XElement("city", "Damanhur"),
                      new XElement("country", "egypt")),

                      new XElement("people",
                       new XElement("ID", 23),
                       new XElement("Name", "yara"),
                       new XElement("city", "Edfu"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 24),
                       new XElement("Name", "sayed"),
                       new XElement("city", "El Arish"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 25),
                       new XElement("Name", "rana"),
                       new XElement("city", " El Fashn"),
                       new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 19),
                      new XElement("Name", "tone"),
                      new XElement("city", "Damietta"),
                      new XElement("country", "egypt")),

                      new XElement("people",
                      new XElement("ID", 20),
                      new XElement("Name", "abdalla"),
                      new XElement("city", "Dar El Salam"),
                      new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 21),
                       new XElement("Name", "nada"),
                       new XElement("city", "Desouk"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 22),
                       new XElement("Name", "abdalla"),
                       new XElement("city", "Dishna"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 26),
                       new XElement("Name", "fatma"),
                       new XElement("city", "El Husseiniya"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 27),
                       new XElement("Name", "ali"),
                       new XElement("city", "El Manzala"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 28),
                       new XElement("Name", "alaa"),
                       new XElement("city", "El Qantara"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 29),
                       new XElement("Name", "tone"),
                       new XElement("city", "Faiyum"),
                       new XElement("country", "egypt")),

                       new XElement("people",
                       new XElement("ID", 30),
                       new XElement("Name", "abdalla"),
                       new XElement("city", "Girga"),
                       new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 31),
                     new XElement("Name", "Mark"),
                     new XElement("city", "Giza"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 32),
                     new XElement("Name", "abdalla"),
                     new XElement("city", "Hihya"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 33),
                     new XElement("Name", "alaa"),
                     new XElement("city", "Zagazig"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 34),
                     new XElement("Name", "sayed"),
                     new XElement("city", "Wadi El Natrun"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 35),
                     new XElement("Name", "rana"),
                     new XElement("city", "Tanta"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 36),
                     new XElement("Name", "mohamed"),
                     new XElement("city", "Suez"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 37),
                     new XElement("Name", "manar"),
                     new XElement("city", "Sohag"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 38),
                     new XElement("Name", "tamam"),
                     new XElement("city", "Sharm El Sheikh"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 40),
                     new XElement("Name", "tone"),
                     new XElement("city", "10th of Ramadan"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 39),
                     new XElement("Name", "sharaawy"),
                     new XElement("city", "Ras El Bar"),
                     new XElement("country", "egypt"))));


            xmlDocumente.Save("people.xml");
        }

        //================================================================================================
        public void sort_all_data()
        {
            XElement root = XElement.Load("people.xml");
            Program.sortedTable = root.Elements("people").OrderBy(t => (int)t.Element("ID")).ToArray();
            root.ReplaceAll(Program.sortedTable);
            root.Save("people.xml");
        }
        //================================================================================================

        public void split(int start, int end, string file_name)
        {
            int count = 0;

            XmlTextWriter writer = new XmlTextWriter(file_name, null);

            writer.WriteStartDocument();

            writer.WriteStartElement("people"); ;

            for (int i = start; i <= end; i++)
            {
                ++count;

                writer.WriteStartElement(Program.sortedTable[i].Name.ToString());

                var desiredElement = Program.sortedTable[i].FirstNode as XElement;
                var name1 = desiredElement.Name;
                var value1 = desiredElement.Value;
                writer.WriteStartElement(name1.ToString());
                writer.WriteString(value1.ToString());
                writer.WriteEndElement();
                //=========================================================================================================
                var desiredElemen = Program.sortedTable[i].FirstNode.NextNode as XElement;
                var name2 = desiredElemen.Name;
                var value2 = desiredElemen.Value;
                writer.WriteStartElement(name2.ToString());
                writer.WriteString(value2.ToString());
                writer.WriteEndElement();
                //==========================================================================================================
                var desiredEleme = Program.sortedTable[i].LastNode.PreviousNode as XElement;
                var name3 = desiredEleme.Name;
                var value3 = desiredEleme.Value;
                writer.WriteStartElement(name3.ToString());
                writer.WriteString(value3.ToString());
                writer.WriteEndElement();
                //==========================================================================================================
                var desiredElem = Program.sortedTable[i].LastNode as XElement;
                var name4 = desiredElem.Name;
                var value4 = desiredElem.Value;
                writer.WriteStartElement(name4.ToString());
                writer.WriteString(value4.ToString());
                writer.WriteEndElement();
                writer.WriteEndElement(); 
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        //================================================================================================
        public void make_small_file_to_store_entry_indexes()
        {
            XElement row1 = XElement.Load("cluster_1.xml");
            XElement[] s1 = row1.Elements("people").ToArray();
            XElement row2 = XElement.Load("cluster_2.xml");
            XElement[] s2 = row2.Elements("people").ToArray();
            XElement row3 = XElement.Load("cluster_3.xml");
            XElement[] s3 = row3.Elements("people").ToArray();
            XElement row4 = XElement.Load("cluster_4.xml");
            XElement[] s4 = row4.Elements("people").ToArray();
            //-----------------------------------------------
            var desiredElement_file1 = s1[0].FirstNode as XElement;
            var name_file1 = desiredElement_file1.Name;
            var value_file1 = desiredElement_file1.Value;
            //-----------------------------------------------

            var desiredElement_file2 = s2[0].FirstNode as XElement;
            var name_file2 = desiredElement_file2.Name;
            var value_file2 = desiredElement_file2.Value;
            //----------------------------------------------
            var desiredElement_file3 = s3[0].FirstNode as XElement;
            var name_file3 = desiredElement_file3.Name;
            var value_file3 = desiredElement_file3.Value;
            //-----------------------------------------------
            var desireElem = s4[0].FirstNode as XElement;
            var name_file4 = desireElem.Name;
            var value_file4 = desireElem.Value;
            //-----------------------------------------------
            XDocument xmlocumente = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("Creating an XML Tree using LINQ to XML"),
               new XElement("tables",
               new XElement("data",
               new XElement(name_file1.ToString(), value_file1.ToString()),
               new XElement("Name", "cluster_1.xml")),
               new XElement("data",
               new XElement(name_file2.ToString(), value_file2.ToString()),
               new XElement("Name", "cluster_2.xml")),
               new XElement("data",
               new XElement(name_file3.ToString(), value_file3.ToString()),
               new XElement("Name", "cluster_3.xml")),
               new XElement("data",
               new XElement(name_file4.ToString(), value_file4.ToString()),
               new XElement("Name", "cluster_4.xml"))));
            xmlocumente.Save("Entry_Indices_Table.xml");
        }
    }

}
