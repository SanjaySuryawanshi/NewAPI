using NewAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NewAPI.Models;
using System.Data.Entity;
using NewAPI.Models;
using System.ServiceModel.Web;

namespace NewAPI.Controllers
{
    [RoutePrefix("api/Tested")]
    public class TestedController : ApiController
    {
        public List<QuestionList> GetQuestionList()
        {
           
            List<QuestionList> students = new List<QuestionList>();

            using (DataModelDbContext dc = new DataModelDbContext())
            {

                students = dc.QuestionLists.ToList();

            }
            
            return students;
        }
        [Route("GetData")]
        public Response GetData()
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

        [HttpPost]
        public QuestionList SaveQuestionDetails(QuestionList QList)
        {
            

            //ee.QuestionType = "2";
            using (DataModelDbContext dbContext = new DataModelDbContext())
            {
                dbContext.QuestionLists.Add(QList);
                dbContext.SaveChanges();
            }
            return QList;
        }
    }

}