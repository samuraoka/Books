using Books.Entities;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Books.Web.Helpers
{
    public static class GenreHelpers
    {
        public static string GetDisplayName(this Genre value)
        {
            var result = value.ToString();

            var attribute = value.GetType().GetField(result)
                .GetCustomAttributes(inherit: false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            if (attribute != null)
            {
                result = attribute.GetName();
            }

            return result;
        }

    }
}
