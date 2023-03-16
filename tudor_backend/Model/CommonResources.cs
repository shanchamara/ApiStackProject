using System.ComponentModel.DataAnnotations;

namespace tudor_backend.Model
{
    public static class CommonResources
    {
        public static bool Validate(object Obj, ref List<ValidationResult> results)
        {
            ValidationContext context = new ValidationContext(Obj, serviceProvider: null, items: null);
            return Validator.TryValidateObject(Obj, context, results, true);
        }

        public enum Roles
        {
            Administrator,
            Content_Admin,
            Report_Viewer
        }

        public enum GuestType
        {
            WORKER,
            VISITOR
        }

        public enum ExamStatus
        {
            PASSED,
            FAILED
        }

        public enum GuestSafetyRecordStatus
        {
            TAKE_EXAM,
            REPRINT,
            VALID
        }

        public const string default_username = "Eranga";
        public const string default_email = "eranga@overleap.com";
        public const string default_password = "Insee@123";
        public const Roles default_role = Roles.Administrator;
        public const string default_dateformat = "MM/dd/yyyy";

        public static DateTime LocalDatetime()
        {
            DateTime serverTime = DateTime.Now; // gives you current Time in server timeZone
            DateTime utcTime = serverTime.ToUniversalTime(); // convert it to Utc using timezone setting of server computer 

            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimeZoneInfo.FindSystemTimeZoneById("Sri Lanka Standard Time"));
            return localTime;
        }
    }
}

