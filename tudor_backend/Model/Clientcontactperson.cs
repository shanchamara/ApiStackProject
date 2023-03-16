namespace tudor_backend.Model
{
    public class Clientcontactperson
    {
        public virtual int Person_id { get; set; }


        public virtual string Name { get; set; }
        public virtual string Position { get; set; }
        public virtual string Tel_no { get; set; }
        public virtual bool Isdeleted { get; set; } = false;
        public virtual string Edit_By { get; set; }
        public virtual string Delete_By { get; set; }
        public virtual DateTime Edit_Date { get; set; }
        public virtual DateTime? Delete_Date { get; set; }
    }

    public class Insertcontactperson : Clientcontactperson
    {

    }

    public class Updatecontactperson : Clientcontactperson
    {

    }

    public class Deletecontactperson : Clientcontactperson
    {

    }

    public class SqlViewcontactperson : Clientcontactperson
    {

    }

}
