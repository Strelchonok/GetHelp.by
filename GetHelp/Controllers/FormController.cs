using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetHelp.Models;
using System.Web.Http.Description;

namespace GetHelp.Controllers
{
    public class FormController : ApiController
    {
        UnitOfWork unitOfWork;
        public FormController()
        {
            unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public void Create([FromBody]QUERIES queries)
        {
            unitOfWork.Queries.Create(queries);
            unitOfWork.Save();

        }
    }
    

}
