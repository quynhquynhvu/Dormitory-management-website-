using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Extensions
{
    public class CustomizeViewEngine : RazorViewEngine
    {
        public CustomizeViewEngine()
        {
            ViewLocationFormats = new[]
             {
                //Default
            "~/Views/{1}/{0}.cshtml", "~/Views/{1}/{0}.vbhtml",
            "~/Views/Shared/{0}.cshtml", "~/Views/Shared/{0}.vbhtml",

            //New Pattern ==== Trangchu, Sukien, Lienhe
            "~/Views/{1}/Main/{0}.cshtml",
            //New Pattern ==== Home
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml",
            //New Pattern ==== CMS
            "~/Views/CMS/{1}/{0}.cshtml",
        };
            MasterLocationFormats = new[]
            {
                //Default
            "~/Views/{1}/{0}.cshtml", "~/Views/{1}/{0}.vbhtml",
            "~/Views/Shared/{0}.cshtml", "~/Views/Shared/{0}.vbhtml",

            //New Pattern ==== Trangchu, Sukien, Lienhe
            "~/Views/{1}/Main/{0}.cshtml",
            //New Pattern ==== Home
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml","~/Views/Home/{1}/Main/{0}.cshtml",
            "~/Views/Home/{1}/Main/{0}.cshtml",
            //New Pattern ==== CMS
            "~/Views/CMS/{1}/{0}.cshtml",
        };
            PartialViewLocationFormats = new[]
            {
                //Default
            "~/Views/{1}/{0}.cshtml", "~/Views/{1}/{0}.vbhtml",
            "~/Views/Shared/{0}.cshtml", "~/Views/Shared/{0}.vbhtml",

            //New Pattern ==== Shared
            "~/Views/Shared/PartialViews/{0}.cshtml","~/Views/Shared/PartialViews/HomePartial/{0}.cshtml",
            "~/Views/Shared/PartialViews/WelcomePartial/{0}.cshtml",
            //New Pattern ==== Trangchu, Sukien, Lienhe
            "~/Views/{1}/PartialViews/{0}.cshtml",
            //New Pattern ==== Home
            "~/Views/Home/{1}/PartialViews/{0}.cshtml","~/Views/Home/{1}/PartialViews/{0}.cshtml",
            "~/Views/Home/{1}/PartialViews/{0}.cshtml","~/Views/Home/{1}/PartialViews/{0}.cshtml",
            "~/Views/Home/{1}/PartialViews/{0}.cshtml","~/Views/Home/{1}/PartialViews/{0}.cshtml",
            "~/Views/Home/{1}/PartialViews/{0}.cshtml","~/Home/Views/{1}/PartialViews/{0}.cshtml",
            "~/Views/Home/{1}/PartialViews/{0}.cshtml"
        };
        }
    }
}