namespace BankLogin
{
    public class LoginPerson
    {
        public string Login(string username, string password)
        {
            string result = "";
            if (username == "Byreddy" && password == "Hari@143")
            {
                result = "Login Success";

            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }

    }
}
