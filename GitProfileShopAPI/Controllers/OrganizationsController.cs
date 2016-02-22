using GitProfileShopAPI.Utils;
using Octokit;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GitProfileShopAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrganizationsController : ApiController
    {

        [Route("organizations/{name}")]
        [HttpGet]
        public async Task<Organization> Get(string name)
        {
            Organization org = await GitHubHelper.GetOrganizationByName(name);
            return org;
        }


    }
}