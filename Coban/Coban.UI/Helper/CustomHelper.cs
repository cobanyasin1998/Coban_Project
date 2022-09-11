using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Coban.UI.Helper
{
    public static class CustomHelper
    {
        public static IHtmlContent Grid(this IHtmlHelper htmlHelper, string value, string name)
        {
            string str = "<input type='submit' value ='" + value + "'name='" + name + "' />";
            return new HtmlString(str);
        }
    }
}
