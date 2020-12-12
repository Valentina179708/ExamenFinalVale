using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenValentinaFinal.Controllers
{
    public class OperationController : ApiController
    {
        public string Get(int id)
        {
            if(id<0)
            {
                return "error";
            }
            if (id == 0)
            {
                return "Realizado por Valentina Gemio Martinez";
            }
            return "Ingreso el numero:" +id.ToString();


    }

}
}

