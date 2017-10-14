using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShoeStoreTeam
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "gioi-thieu",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "lien-he",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Blog",
                url: "tin-tuc",
                defaults: new { controller = "Blog", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Product Category",
                url: "san-pham/{link}-{cateId}",
                defaults: new { controller = "Category", action = "ProductCategory", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Detail Product",
               url: "chi-tiet/{link}-{proId}",
               defaults: new { controller = "Product", action = "DetailProduct", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
