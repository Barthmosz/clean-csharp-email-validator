using System.Text.RegularExpressions;

namespace Clean.EmailValidator
{
    public static class EmailValidator
    {
        public static bool Validate(string email)
        {
            string emailRegex = "/^[\\w-.]+@([\\w-]+\\.)+[\\w-]{2,4}$/g";
            return Regex.IsMatch(email, emailRegex);
        }
    }
}
