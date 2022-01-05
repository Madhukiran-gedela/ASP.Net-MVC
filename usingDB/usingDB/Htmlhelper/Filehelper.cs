using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace usingDB.Htmlhelper
{
    public static class Filehelper
    {
        public static MvcHtmlString File(this HtmlHelper htmlHelper,string CssClassname)
        {
            TagBuilder tag = new TagBuilder("input");
            tag.MergeAttribute("type", "file");
            tag.MergeAttribute("id", "image");
            tag.MergeAttribute("name", "Photo");
            tag.MergeAttribute("class", CssClassname);
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }
    }
}