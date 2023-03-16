using Microsoft.EntityFrameworkCore;
using tudor_backend.Context;
using tudor_backend.DatabaseConnection;
using tudor_backend.Model;

namespace tudor_backend.Services
{
    public interface IClientContactPersonService
    {
        Task<List<SqlViewcontactperson>> GetAll();
        Task<Message<string>> RegisterAsync(Insertcontactperson model);
        TblClient_Contact_Person GetById(int id);
        Task<Message<string>> DeleteAsync(Deletecontactperson model);
        Task<Message<string>> UpdateAsync(Updatecontactperson model);
        Task<SqlViewcontactperson> GetDetailsById(int id);
        Task<List<SqlViewcontactperson>> Getbyreq(int id);
        TblClient_Contact_Person GetByReqId(int personid);




    }
    public class ClientContactPersonService : IClientContactPersonService
    {
        public ClientContactPersonService(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public async Task<List<SqlViewcontactperson>> GetAll()
        {
            return await (from a in _context.TblClient_Contact_Person
                          select new SqlViewcontactperson()
                          {
                              Person_id = a.Person_id,
                              Name = a.Name,
                              Position = a.Position,
                              Tel_no = a.Tel_no,
                              Isdeleted = a.Isdeleted,
                              Edit_By = a.Edit_By,
                              Delete_By = a.Delete_By,
                              Edit_Date = a.Edit_Date,
                              Delete_Date = (DateTime)a.Delete_Date,
                          }).Where(d => d.Isdeleted.Equals(false)).ToListAsync();
        }


        public async Task<List<SqlViewcontactperson>> Getbyreq(int id)
        {
            return await (from a in _context.TblClient_Contact_Person
                          select new SqlViewcontactperson()
                          {
                              Person_id = a.Person_id,
                              Name = a.Name,
                              Position = a.Position,
                              Tel_no = a.Tel_no,
                              Isdeleted = a.Isdeleted,
                              Edit_By = a.Edit_By,
                              Delete_By = a.Delete_By,
                              Edit_Date = a.Edit_Date,
                              Delete_Date = (DateTime)a.Delete_Date,
                          }).Where(d => d.Isdeleted.Equals(false)).ToListAsync();
        }



        public async Task<SqlViewcontactperson> GetDetailsById(int id)
        {
            return await (from a in _context.TblClient_Contact_Person
                          select new SqlViewcontactperson()
                          {
                              Person_id = a.Person_id,
                              Name = a.Name,
                              Position = a.Position,
                              Tel_no = a.Tel_no,
                              Isdeleted = a.Isdeleted,
                              Edit_By = a.Edit_By,
                              Delete_By = a.Delete_By,
                              Edit_Date = a.Edit_Date,
                              Delete_Date = (DateTime)a.Delete_Date,
                          }).Where(d => d.Isdeleted.Equals(false) && d.Person_id.Equals(id)).SingleOrDefaultAsync();
        }

        public async Task<Message<string>> RegisterAsync(Insertcontactperson model)
        {
            try
            {
                var contactperson = new TblClient_Contact_Person
                {
                    Name = model.Name,
                    Tel_no = model.Tel_no,
                    Position = model.Position,
                    Edit_By = model.Edit_By,
                    Edit_Date = model.Edit_Date,

                };

                _context.TblClient_Contact_Person.Add(contactperson);
                await _context.SaveChangesAsync();

                return new Message<string>() { Status = "S", Text = $"Client Contact Person Added Successfully. Person ID is {contactperson.Person_id}", Result = contactperson.Person_id.ToString() };

            }
            catch (Exception ex)
            {
                return new Message<string>() { Status = "E", Text = ex.Message };
            }
        }
        public TblClient_Contact_Person GetById(int id)
        {
            return _context.TblClient_Contact_Person.SingleOrDefault(d => d.Person_id.Equals(id));
        }

        public TblClient_Contact_Person GetByReqId(int personid)
        {
            return _context.TblClient_Contact_Person.SingleOrDefault(d => d.Person_id.Equals(personid));
        }


        public async Task<Message<string>> DeleteAsync(Deletecontactperson model)
        {
            try
            {
                var existContactPerson = GetByReqId(model.Person_id);

                if (existContactPerson.Isdeleted == false)
                {
                    existContactPerson.Isdeleted = true;
                    existContactPerson.Delete_By = model.Delete_By;
                    existContactPerson.Delete_Date = model.Delete_Date;
                    await _context.SaveChangesAsync();

                }
                else
                {
                    return new Message<string>()
                    {
                        Status = "S",
                        Text = $"Contact Person {existContactPerson.Person_id} already deleted",
                        Result = existContactPerson.Person_id.ToString()

                    };
                }

                return new Message<string>()
                {
                    Status = "S",
                    Text = $"Contact Person {existContactPerson.Person_id} deleted successfully",
                    Result = existContactPerson.Person_id.ToString()

                };

            }
            catch (Exception ex)
            {
                return new Message<string>()
                { Text = $"Delete error {ex.Message}" };
            }
        }

        public async Task<Message<string>> UpdateAsync(Updatecontactperson model)
        {
            try
            {
                var existContactPerson = GetByReqId(model.Person_id);

                existContactPerson.Tel_no = model.Tel_no != null ? model.Tel_no : existContactPerson.Tel_no;
                existContactPerson.Name = model.Name != null ? model.Name : existContactPerson.Name;
                // existContactPerson.FKRequest_id = model.FKRequest_id;
                existContactPerson.Position = model.Position != null ? model.Position : existContactPerson.Position;
                existContactPerson.Isdeleted = model.Isdeleted;
                existContactPerson.Delete_By = model.Delete_By;
                existContactPerson.Edit_By = "Updated by " + model.Edit_By != null ? model.Edit_By : existContactPerson.Edit_By;
                existContactPerson.Delete_Date = model.Delete_Date;
                existContactPerson.Edit_Date = model.Edit_Date;



                await _context.SaveChangesAsync();


                return new Message<string>()
                {
                    Status = "S",
                    Text = $"Contact Person {existContactPerson.Name} details updated successfully",
                    Result = existContactPerson.Person_id.ToString()

                };

            }
            catch (Exception ex)
            {
                return new Message<string>()
                { Text = $"Update error {ex.Message}" };
            }
        }
    }
}

