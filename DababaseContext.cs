using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using IBM.EntityFrameworkCore.Storage.Internal;
using System.ComponentModel.DataAnnotations;
 

namespace ConsoleApp
{
    public class UPCStyle
    {
        [Key]
        public string TUSEA { get; set; }
        public string TUSTYL { get; set; }
        public string TUCLR { get; set; }
    }
    public class MyContext : DbContext
    {
        public MyContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {     
             optionsBuilder.UseDb2(@"Server=<servername>:<portno>;Database=<dbname>;userid=<uid>;password=<pwd>", p=>p.SetServerInfo( IBMDBServerType.AS400, IBMDBServerVersion.AS400_07_01 ));
        }

        public virtual DbSet<UPCStyle> MYTABLE { get; set;}
    }
}