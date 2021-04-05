using NewAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NewAPI.Controllers
{
    public class ValuesController : ApiController
    {
        
        public Response Get()
        {
            
            Response _objResponseModel = new Response();
            List<EntityFile> students = new List<EntityFile>();
            students.Add(new EntityFile
            {
                ID = 101,
                Name = "Seam",
                Email = "seam@gmail.com",
                Address = "Dhaka,Bangladesh"
            });
            students.Add(new EntityFile
            {
                ID = 102,
                Name = "Mitila",
                Email = "mitila@gmail.com",
                Address = "Dhaka,Bangladesh"
            });
            students.Add(new EntityFile
            {
                ID = 104,
                Name = "Popy",
                Email = "popy@yahoo.com",
                Address = "Dhaka,Bangladesh"
            });

            _objResponseModel.Data = students;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }
    }
}