using Octokit;
using System.Threading.Tasks;

namespace GitProfileShopAPI.Utils
{
    public sealed class GitHubHelper
    {
        public static GitHubClient GetClient()
        {
            ProductHeaderValue header = new ProductHeaderValue("GitProfileShop");
            GitHubClient client = new GitHubClient(header);
            return client;
        }

        public static async Task<Organization> GetOrganizationByName(string name)
        {
            GitHubClient github = GitHubHelper.GetClient();
            Organization organization = await github.Organization.Get(name);
            return organization;
        }
    }
}