using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ASPNET.WebAPI.Controllers {

    [EnableCors("*", "*", "*")]
    public class LanguageController : ApiController {
        private string[] languages = { "C#", "Java", "Pyhton", "Ruby", "Go" };

        //api/language
        public string[] Get() {
            return languages;
        }

        //api/languages/{id}
        public string Get(int id) {
            return languages[id];
        }
    }
}
