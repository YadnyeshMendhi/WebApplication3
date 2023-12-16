using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.HTML_Helpers
{
    public static class FileHelper
    {
        public static MvcHtmlString File(this HtmlHelper htmlHelper, string cssClassName)
        {
            TagBuilder tag = new TagBuilder("input");
            tag.MergeAttribute("type", "file");
            tag.MergeAttribute("id", "name");
            tag.MergeAttribute("name", "photo");
            tag.MergeAttribute("class", "cssClassName");
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }
    }
}