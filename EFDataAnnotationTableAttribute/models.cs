using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAnnotationTableAttribute
{

    //Code First Default Convention. EmployeeID is Primary key
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
    }


    [Table("CustomerMaster1")]
    public class Customer1
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
    }

    [Table("CustomerMaster2", Schema = "Admin")]
    public class Customer2
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
    } 


}
