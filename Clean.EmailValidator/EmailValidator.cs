using System.Text.RegularExpressions;

namespace Clean.EmailValidator
{
    public static class EmailValidator
    {
        /// <summary>
        /// Validates an email address.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool Validate(string email)
        {
            string emailRegex = "^[\\w-.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            return Regex.IsMatch(email, emailRegex);
        }
    }
}
