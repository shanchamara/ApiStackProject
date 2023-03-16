using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tudor_backend.Model;
using tudor_backend.Services;

namespace tudor_backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientContactPersonController : ControllerBase
    {
        private const string API_ROUTE_NAME = "/api/client_contact_person";
        private readonly IClientContactPersonService _clientcontactpersonService;
        public ClientContactPersonController(IClientContactPersonService clientcontactpersonService)
        {
            _clientcontactpersonService = clientcontactpersonService;
        }

        [HttpGet]
        [Route(API_ROUTE_NAME + "/GetAll")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(new Message<List<SqlViewcontactperson>> { Status = "S", Result = await _clientcontactpersonService.GetAll() });
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest, new Message<string>() { Text = ex.Message });
            }
        }


        [HttpGet]
        [Route(API_ROUTE_NAME + "/Getbyreq/{id}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Getbyreq(int id)
        {
            try
            {
                return Ok(new Message<List<SqlViewcontactperson>> { Status = "S", Result = await _clientcontactpersonService.Getbyreq(id) });
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest, new Message<string>() { Text = ex.Message });
            }
        }



        [HttpGet]
        [Route(API_ROUTE_NAME + "/GetDetails/{id}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetDetails(int id)
        {
            try
            {
                return Ok(new Message<SqlViewcontactperson> { Status = "S", Result = await _clientcontactpersonService.GetDetailsById(id) });
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest, new Message<string>() { Text = ex.Message });
            }
        }

        [HttpPost]
        [Route(API_ROUTE_NAME + "/Insert")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Insert([FromBody] Insertcontactperson model)
        {
            try
            {
                return Ok(await _clientcontactpersonService.RegisterAsync(new Insertcontactperson()
                {
                    Person_id = model.Person_id,
                    Name = model.Name,
                    Position = model.Position,
                    Tel_no = model.Tel_no,
                    Edit_By = "Inserted by " + model.Edit_By,
                    Edit_Date = CommonResources.LocalDatetime(),

                }));
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest, new Message<string>() { Text = ex.Message });
            }
        }

        [HttpDelete]
        [Route(API_ROUTE_NAME + "/Delete/{personid}/{requestid}")]
        public async Task<IActionResult> Delete(int personid, int requestid)
        {
            try
            {
                var model = new Deletecontactperson
                {
                    Delete_By = User.Identities.First().Claims.Single(s => s.Type == "uid").Value,
                    Delete_Date = CommonResources.LocalDatetime(),
                    Person_id = personid,
                };

                return Ok(await _clientcontactpersonService.DeleteAsync(model));

            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest, new Message<string>() { Text = ex.Message });
            }
        }

        [HttpPut]
        [Route(API_ROUTE_NAME + "/Update/{personId}/{requestId}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Update(int personId, int requestId, [FromBody] Updatecontactperson model)
        {
            try
            {
                model.Edit_By = User.Identities.First().Claims.Single(s => s.Type == "uid").Value;
                model.Edit_Date = CommonResources.LocalDatetime();
                model.Person_id = personId;
                return Ok(await _clientcontactpersonService.UpdateAsync(model));

            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest, new Message<string>() { Text = ex.Message });
            }
        }
    }
}
