namespace MitechCenter.vn.Areas.MCMS.Models
{
    public class Notification
    {
        public static string Primary(string title, string message)
        {
            if (title.Length > 0)
            {
                message = " - " + message;
            }
            return "<div class=\"alert alert-primary mt-3\" role=\"alert\"><strong>" + title + "</strong>" + message + "</div>";
        }
        public static string Secondary(string title, string message)
        {
            if (title.Length > 0)
            {
                message = " - " + message;
            }
            return "<div class=\"alert alert-secondary mt-3\" role=\"alert\"><strong>" + title + "</strong>" + message + "</div>";
        }
        public static string Success(string title, string message)
        {
            if (title.Length > 0)
            {
                message = " - " + message;
            }
            return "<div class=\"alert alert-success mt-3\" role=\"alert\"><strong>" + title + "</strong>" + message + "</div>";
        }
        public static string Error(string title, string message)
        {
            if (title.Length > 0)
            {
                message = " - " + message;
            }
            return "<div class=\"alert alert-danger mt-3\" role=\"alert\"><strong>" + title + "</strong>" + message + "</div>";
        }
        public static string Warning(string title, string message)
        {
            if (title.Length > 0)
            {
                message = " - " + message;
            }
            return "<div class=\"alert alert-warning mt-3\" role=\"alert\"><strong>" + title + "</strong>" + message + "</div>";
        }
        public static string Info(string title, string message)
        {
            if (title.Length > 0)
            {
                message = " - " + message;
            }
            return "<div class=\"alert alert-info mt-3\" role=\"alert\"><strong>" + title + "</strong>" + message + "</div>";
        }
    }
}