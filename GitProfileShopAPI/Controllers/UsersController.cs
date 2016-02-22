using GitProfileShopAPI.Models;
using GitProfileShopAPI.Utils;
using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;


namespace GitProfileShopAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        [Route("users/{login}")]
        [HttpGet]
        public async Task<Models.User> Get(string login)
        {
            GitHubClient github = GitHubHelper.GetClient();
            Octokit.User userBase = await github.User.Get(login);
            Models.User user = new Models.User(userBase);
            return user;
        }

        [Route("cart")]
        [HttpGet]
        public async Task<List<Models.User>> GetCart()
        {
            UserListHelper helper = UserListHelper.Instance;
            List<Models.User> list = helper.UserList;
            return list;
        }

        
        [Route("users/{login}")]
        [HttpGet]
        public void Put(int id, [FromBody]string value)
        {

        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        
        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}