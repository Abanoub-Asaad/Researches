using System.Xml.Linq;
using System;
using System.Text;
using System.Xml;
using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;
namespace Demo
{
    class Program
    {
        public static void Main()
        {
            XDocument xmlDocumente = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),


                new XComment("Creating an XML Tree using LINQ to XML"),

                new XElement("peoples",

                    new XElement("people",
                        new XElement("ID", 1),
                        new XElement("Name", "Ali"),
                        new XElement("city", "10th of Ramadan"),
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
                     new XElement("city", "New Cairo"),
                     new XElement("country", "egypt")),

                     new XElement("people",
                     new XElement("ID", 39),
                     new XElement("Name", "sharaawy"),
                     new XElement("city", "Ras El Bar"),
                     new XElement("country", "egypt"))));


            xmlDocumente.Save("people.xml");
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //sort the file
            XElement root = XElement.Load("people.xml");
            XElement[] sortedTables = root.Elements("people").OrderBy(t => (int)t.Element("ID")).ToArray();
            root.ReplaceAll(sortedTables);
            root.Save("people.xml");
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int count = 0;
            int ent;
            ent = sortedTables.Length % 4;
            Console.WriteLine(ent);

            using (XmlTextWriter writer = new XmlTextWriter("people1.xml", null))
            {

                writer.WriteStartDocument();

                writer.WriteStartElement("people");
                for (int i = 0; i < sortedTables.Length; i++)
                {

                    // XElement[] d = new XElement[10];
                    count++;
                    if (count <= 10)
                    {
                        //  d[0] = sortedTables[i];
                        writer.WriteStartElement(sortedTables[i].Name.ToString());

                        var desiredElement = sortedTables[i].FirstNode as XElement;
                        var n1 = desiredElement.Name;
                        var v1 = desiredElement.Value;
                        writer.WriteStartElement(n1.ToString());
                        writer.WriteString(v1.ToString());
                        writer.WriteEndElement();
                        //=========================================================================================================
                        var desiredElemen = sortedTables[i].FirstNode.NextNode as XElement;
                        var n2 = desiredElemen.Name;
                        var v2 = desiredElemen.Value;
                        writer.WriteStartElement(n2.ToString());
                        writer.WriteString(v2.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredEleme = sortedTables[i].LastNode.PreviousNode as XElement;
                        var n3 = desiredEleme.Name;
                        var v3 = desiredEleme.Value;
                        writer.WriteStartElement(n3.ToString());
                        writer.WriteString(v3.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredElem = sortedTables[i].LastNode as XElement;
                        var n4 = desiredElem.Name;
                        var v4 = desiredElem.Value;
                        writer.WriteStartElement(n4.ToString());
                        writer.WriteString(v4.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    if (count == 10)
                    {
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                    }
                }

            }
            using (XmlTextWriter writer = new XmlTextWriter("people2.xml", null))
            {
                int coun = 0;
                writer.WriteStartDocument();

                writer.WriteStartElement("people");
                for (int i = 0; i < sortedTables.Length; i++)
                {
                    coun++;
                    if (coun <= 20 && coun > 10)
                    {
                        writer.WriteStartElement(sortedTables[i].Name.ToString());

                        var desiredElement = sortedTables[i].FirstNode as XElement;
                        var n1 = desiredElement.Name;
                        var v1 = desiredElement.Value;
                        writer.WriteStartElement(n1.ToString());
                        writer.WriteString(v1.ToString());
                        writer.WriteEndElement();
                        //=========================================================================================================
                        var desiredElemen = sortedTables[i].FirstNode.NextNode as XElement;
                        var n2 = desiredElemen.Name;
                        var v2 = desiredElemen.Value;
                        writer.WriteStartElement(n2.ToString());
                        writer.WriteString(v2.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredEleme = sortedTables[i].LastNode.PreviousNode as XElement;
                        var n3 = desiredEleme.Name;
                        var v3 = desiredEleme.Value;
                        writer.WriteStartElement(n3.ToString());
                        writer.WriteString(v3.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredElem = sortedTables[i].LastNode as XElement;
                        var n4 = desiredElem.Name;
                        var v4 = desiredElem.Value;
                        writer.WriteStartElement(n4.ToString());
                        writer.WriteString(v4.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    if (coun == 20)
                    {
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                    }
                }

            }
            using (XmlTextWriter writer = new XmlTextWriter("people3.xml", null))
            {
                int cou = 0;
                writer.WriteStartDocument();

                writer.WriteStartElement("people");
                for (int i = 0; i < sortedTables.Length; i++)
                {
                    cou++;
                    if (cou <= 30 && cou > 20)
                    {
                        writer.WriteStartElement(sortedTables[i].Name.ToString());

                        var desiredElement = sortedTables[i].FirstNode as XElement;
                        var n1 = desiredElement.Name;
                        var v1 = desiredElement.Value;
                        writer.WriteStartElement(n1.ToString());
                        writer.WriteString(v1.ToString());
                        writer.WriteEndElement();
                        //=========================================================================================================
                        var desiredElemen = sortedTables[i].FirstNode.NextNode as XElement;
                        var n2 = desiredElemen.Name;
                        var v2 = desiredElemen.Value;
                        writer.WriteStartElement(n2.ToString());
                        writer.WriteString(v2.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredEleme = sortedTables[i].LastNode.PreviousNode as XElement;
                        var n3 = desiredEleme.Name;
                        var v3 = desiredEleme.Value;
                        writer.WriteStartElement(n3.ToString());
                        writer.WriteString(v3.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredElem = sortedTables[i].LastNode as XElement;
                        var n4 = desiredElem.Name;
                        var v4 = desiredElem.Value;
                        writer.WriteStartElement(n4.ToString());
                        writer.WriteString(v4.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    if (cou == 30)
                    {
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                    }
                }

            }


            using (XmlTextWriter writer = new XmlTextWriter("people4.xml", null))
            {
                int co = 0;
                writer.WriteStartDocument();

                writer.WriteStartElement("people");
                for (int i = 0; i < sortedTables.Length; i++)
                {
                    co++;
                    if (co <= 40 && co > 30)
                    {
                        writer.WriteStartElement(sortedTables[i].Name.ToString());

                        var desiredElement = sortedTables[i].FirstNode as XElement;
                        var n1 = desiredElement.Name;
                        var v1 = desiredElement.Value;
                        writer.WriteStartElement(n1.ToString());
                        writer.WriteString(v1.ToString());
                        writer.WriteEndElement();
                        //=========================================================================================================
                        var desiredElemen = sortedTables[i].FirstNode.NextNode as XElement;
                        var n2 = desiredElemen.Name;
                        var v2 = desiredElemen.Value;
                        writer.WriteStartElement(n2.ToString());
                        writer.WriteString(v2.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredEleme = sortedTables[i].LastNode.PreviousNode as XElement;
                        var n3 = desiredEleme.Name;
                        var v3 = desiredEleme.Value;
                        writer.WriteStartElement(n3.ToString());
                        writer.WriteString(v3.ToString());
                        writer.WriteEndElement();
                        //==========================================================================================================
                        var desiredElem = sortedTables[i].LastNode as XElement;
                        var n4 = desiredElem.Name;
                        var v4 = desiredElem.Value;
                        writer.WriteStartElement(n4.ToString());
                        writer.WriteString(v4.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    if (co == 40)
                    {
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                    }
                }

            }
            XElement ro1 = XElement.Load("people1.xml");
            XElement[] s1 = ro1.Elements("people").ToArray();
            XElement ro2 = XElement.Load("people2.xml");
            XElement[] s2 = ro2.Elements("people").ToArray();
            XElement ro3 = XElement.Load("people3.xml");
            XElement[] s3 = ro3.Elements("people").ToArray();
            XElement ro4 = XElement.Load("people4.xml");
            XElement[] s4 = ro4.Elements("people").ToArray();
            //------------------------------------------------------------------------------------------
            var desiredE = s1[0].FirstNode as XElement;
            var n11 = desiredE.Name;
            var v11 = desiredE.Value;
            //--------------------------------------------------------

            var desired = s2[0].FirstNode as XElement;
            var n12 = desired.Name;
            var v12 = desired.Value;
            //-----------------------------------------------------------
            var desiredleme = s3[0].FirstNode as XElement;
            var n33 = desiredleme.Name;
            var v33 = desiredleme.Value;
            //-------------------------------------------------------------
            var desireElem = s4[0].FirstNode as XElement;
            var n44 = desireElem.Name;
            var v44 = desireElem.Value;
            //----------------------------------------------------------------
            XDocument xmlocumente = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("Creating an XML Tree using LINQ to XML"),
               new XElement("tables",
                   new XElement("data",
                       new XElement(n11.ToString(), v11.ToString()),
                       new XElement("Name", "people1.xml")),
                        new XElement("data",
                       new XElement(n12.ToString(), v12.ToString()),
                       new XElement("Name", "people2.xml")),
                        new XElement("data",
                       new XElement(n33.ToString(), v33.ToString()),
                       new XElement("Name", "people3.xml")),
                        new XElement("data",
                       new XElement(n44.ToString(), v44.ToString()),
                       new XElement("Name", "people4.xml"))));
            xmlocumente.Save("Entry_Indices_Table.xml");
            //---------------------------------------------------------------------
            int num = 0;
            Console.WriteLine("enter 1 to search by ID ");
            Console.WriteLine("enter 2 to search by name ");
            Console.Write("enter your chosse : ");
            String chos = Console.ReadLine();
            if (chos == "1")
            {
                Console.Write("enter ID :");
                int id = Convert.ToInt32(Console.ReadLine());

                XElement f = XElement.Load("Entry_Indices_Table.xml");
                XElement[] w = f.Elements("data").ToArray();

                Boolean ch = false;
                for (int i = 0; i < w.Length; i++)
                {

                    int x = i + 1;
                    if (i < w.Length - 1)
                    {

                        var rrr = w[i].FirstNode as XElement;
                        var n444 = rrr.Name;
                        var v444 = rrr.Value;

                        var rr = w[x].FirstNode as XElement;
                        var n4444 = rr.Name;
                        var v4444 = rr.Value;

                        var rrr1 = w[i].FirstNode.NextNode as XElement;
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

                    var rrr1 = w[w.Length - 1].FirstNode.NextNode as XElement;
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
                            Console.WriteLine(num);
                        }
                    }
                }
            }
            if (chos == "2")
            {
                int coun = 1;
                Console.Write("enter the city :");
                String city = Console.ReadLine();

                XElement f = XElement.Load("people.xml");
                XElement[] w = f.Elements("people").ToArray();
                for (int s = 0; s < w.Length; s++)
                {
                    var or = w[s].LastNode.PreviousNode as XElement;
                    var nam = or.Name;
                    var val = or.Value;
                    if (val == city)
                    {
                        Console.WriteLine(coun);
                    }
                    coun++;
                }
            }
            Console.ReadLine();
        }
    }
}
