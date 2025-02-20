namespace MovieSeriesReviewApp.CommonLayer.Utilities
{
    public class Validator
    {
        public static bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
