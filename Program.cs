using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            //inserting record
            // insertRecord_UPCStyle(context);
            fetchRecords_UPCStyle(context);
            //updating record
            // updateRecord_UPCStyle(context);
            // fetchRecords_UPCStyle(context);
            //deleting record
            // deleteRecord_UPCStyle(context);
            // fetchRecords_UPCStyle(context);  
        }
        // public static void insertRecord_UPCStyle(MyContext context)
        // {
        //     UPCStyle newRecord = new UPCStyle
        //     {
        //         ID = 101,
        //         NAME = "Tom",
        //         MOBILENO = "22222222",
        //         ADDRESS = "37,Columbia Street,China Town",
        //         EMAIL = "tom@XXX.com"
        //     };
        //     context.Add(newRecord);
        //     context.SaveChanges();
            
        //     Console.WriteLine("\nRecord inserted into MyTable");
        //     Console.WriteLine("****************************");
        // }
        // public static void updateRecord_UPCStyle(MyContext context)
        // {
        //     UPCStyle updateRecord = context.MYTABLE.First(c => c.ID == 101);
        //     updateRecord.MOBILENO = "8989898988";
        //     updateRecord.ADDRESS = "100, C.V. Nagar, Bangalore";
        //     context.SaveChanges();
        //     updateRecord.EMAIL = "tom12@XXX.com";
        //     Console.WriteLine("\nRecord updated into MyTable");
        //     Console.WriteLine("***************************");
        // }
        // public static void deleteRecord_UPCStyle(MyContext context)
        // {
        //     UPCStyle delRecord =context.MYTABLE.First(c => c.ID == 101);
        //     context.MYTABLE.Remove(delRecord);
        //     context.SaveChanges();
        //     Console.WriteLine("\nRecord deleted from MyTable");
        //     Console.WriteLine("***************************");
        // }
        public static void fetchRecords_UPCStyle(MyContext context)
        {
            Console.WriteLine("\nUPCStyle Detail:");
            Console.WriteLine("---------------");
            var results = context.MYTABLE.Take(10); //.Where(c => c.ID == 101);
            foreach (var record in results )
            {
                Console.WriteLine(
                    "SEASON: "+ record.TUSEA +
                    "\n STYLE: " + record.TUSTYL + "\n COLOR: "+ record.TUCLR);

            }
            if (results.Count() == 0)
                Console.WriteLine("Record does not exist\n");
        }
    }
}
