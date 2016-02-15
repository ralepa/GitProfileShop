using GitProfileShopAPI.Models;
using GitProfileShopAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace GitProfileShopAPI.Controllers
{
    public class OrganizationsController : ApiController
    {
        private const string URL = "https://api.github.com/organizations";

        // GET api/<controller>/5
        public object Get(int id)
        {
            string parameters = string.Format("?id={0}", id);
            return GetOrganizationData(parameters);
        }

        public string Get(string name)
        {
            string parameters = string.Format("?name={0}", name);
            return GetOrganizationData(parameters);
        }

        private string GetOrganizationData(string parameter)
        {
            RestClient<Organization> restClient = new RestClient<Organization>(URL, HttpVerb.GET);
            return restClient.MakeRequest(parameter);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}