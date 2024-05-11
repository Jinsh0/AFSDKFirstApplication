using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Time;
using OSIsoft.AF.Data;

namespace AFSDKFirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Connecting to a PISystem (aka AF Server)
            //https://docs.aveva.com/bundle/af-sdk/page/html/T_OSIsoft_AF_PISystems.htm
            //https://docs.aveva.com/bundle/af-sdk/page/html/T_OSIsoft_AF_PISystem.htm
            PISystems myPISystems = new PISystems();
            PISystem myPISystem = myPISystems["Gary-VM102"];
            myPISystem.Connect();
            Console.WriteLine("Connected to AF Server {0}, with ID: {1}, and Version: {2}", myPISystem.Name, myPISystem.ID, myPISystem.ServerVersion);

            //Exercise 2: Connecting to an AF Database
            //https://docs.aveva.com/bundle/af-sdk/page/html/T_OSIsoft_AF_AFDatabases.htm
            //https://docs.aveva.com/bundle/af-sdk/page/html/N_OSIsoft_AF.htm
            AFDatabases myDBs = myPISystem.Databases;
            AFDatabase myDB = myDBs["AF Training"];
            Console.WriteLine("\nCurrent Database: {0}, with ID: {1}, and UniqueID: {2}", myDB.Name, myDB.ID, myDB.UniqueID);

            //Exercise 3: Writing Element's Properties
            //https://docs.aveva.com/bundle/af-sdk/page/html/T_OSIsoft_AF_Asset_AFElements.htm
            //https://docs.aveva.com/bundle/af-sdk/page/html/T_OSIsoft_AF_Asset_AFElement.htm
            Console.WriteLine("\nManual Listing of Elements:");
            AFElements myElements = myDB.Elements;
            AFElement myElement0 = myElements[0];
            AFElement myElement1 = myElements[1];
            AFElement myElement2 = myElements[2];
            Console.WriteLine(myElement0);
            Console.WriteLine(myElement1);
            Console.WriteLine(myElement2);

            Console.WriteLine("\nFor Loop Listing Elements:");
            foreach (var e in myElements)
            {
                Console.WriteLine(e.Name);
            }

            //Exercise 4: Creating Element
            //https://docs.aveva.com/bundle/af-sdk/page/html/T_OSIsoft_AF_Asset_AFElement.htm
            Console.WriteLine("\nCreating Element");
            //Code intentionally omitted and left as an exercise

            Console.ReadKey();
        }
    }
}
