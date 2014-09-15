using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace PaladinCloudware.Helpers
{
    public static class SelectExtensions
    {
        public static MvcHtmlString MyDropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, string optionLabel)
        {
            return System.Web.Mvc.Html.SelectExtensions.DropDownList(htmlHelper, name, selectList, optionLabel, new {@class="form-control"});
        }

        public static MvcHtmlString MyDropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList)
        {
            return System.Web.Mvc.Html.SelectExtensions.DropDownList(htmlHelper, name, selectList, new { @class = "form-control" });
        }
    }
}