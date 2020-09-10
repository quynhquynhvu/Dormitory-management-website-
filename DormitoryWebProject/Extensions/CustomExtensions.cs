using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Extensions
{
    public class CustomExtensions
    {
    }

    public static class HtmlExtensions
    {
        public static MvcHtmlString ShowImage(this HtmlHelper html, string imagePath)
        {
            String img = "";
            if (imagePath != null)
            {
                img = imagePath;
            }
            else
            {
                img = "~/assets/image/no-image-found.png";
            }
            return new MvcHtmlString("<img src='" + img + "' style='width: 200px; '/>");
        }
    }
}