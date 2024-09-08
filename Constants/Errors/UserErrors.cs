namespace LunaEdgeTestTask.Constants.Errors
{
    public static class UserErrors
    {
        public const string INVALID_USERNAME = "Username is already in use!";
        public static string INVALID_PASSWORD = $"Password's length must be between {ValidationConstants.PasswordMinLength} and {ValidationConstants.PasswordMaxLength} characters. Password should contain at least one capital letter and at least one digit!";
        public const string INVALID_EMAIL = "User's email is invalid!";
    }
}
