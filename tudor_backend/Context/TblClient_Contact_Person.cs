using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tudor_backend.DatabaseConnection
{
    public class TblClient_Contact_Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Person_id { get; set; }





        public string Name { get; set; }
        public string Position { get; set; }
        public string Tel_no { get; set; }
        public bool Isdeleted { get; set; } = false;
        public string Edit_By { get; set; }
        public string Delete_By { get; set; }
        public DateTime Edit_Date { get; set; }
        public DateTime? Delete_Date { get; set; }



    }
}
