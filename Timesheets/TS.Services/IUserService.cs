namespace TS.Services
{
    public interface IUserService
    {
        //TokenResponse 
        public string Authenticate(string user, string password);
    }
}