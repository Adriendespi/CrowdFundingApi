namespace CrowdFunding.Api.Model
{
    public class UserApi
    {
        public int Id { get; set; }

        public string Pseudo { get; set; }
        public bool IsAdmin { get; set; }
        public string Token { get; set; }
    }
}
