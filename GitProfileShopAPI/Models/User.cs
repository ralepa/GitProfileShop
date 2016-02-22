namespace GitProfileShopAPI.Models
{
    public class User
    {
        private Octokit.User MainUser
        {
            get; set;
        }

        public User(Octokit.User user)
        {
            MainUser = user;
            Id = user.Id;
            Login = user.Login;
        }

        public long Id { get; set; }

        public string Login { get; set; }

        public double Value
        {
            get
            {
                var collaboratorsPrice = MainUser.Collaborators;
                var followersPrice = MainUser.Followers * .5;
                var followingPrice = MainUser.Following * .2;
                var privGistsPrice = MainUser.PrivateGists * 1;
                var publicGistsPrice = MainUser.PublicGists * 3;
                var publicReposPrice = MainUser.PublicRepos * 10;
                var privateReposPrice = MainUser.PublicRepos * 2;
                var hireablePrice = MainUser.Hireable.HasValue ? (MainUser.Hireable.Value ? 100 : 50) : 0;

                return collaboratorsPrice + followersPrice + followingPrice + privGistsPrice + publicGistsPrice + publicReposPrice + privateReposPrice;
            }
            
        }
    }

    public static class UserExtension
    {
    }
}