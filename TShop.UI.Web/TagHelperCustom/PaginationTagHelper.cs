using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application;

namespace TShop.UI.Web.TagHelperCustom
{
    [HtmlTargetElement("div",Attributes ="Pagination")]
    public class PaginationTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;

        public PaginationTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName("Pagination")]
        public Paging Paging { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var UrlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.SuppressOutput();
            output.Content.AppendHtml($@"<div class='w100 categoryFooter'>
                <div class='pagination pull-left no-margin-top'>
                    <ul class='pagination no-margin-top'>
                     <li><a href='#'>«</a></li>");

            for (short i = 1; i <= Paging.TotalPage; i++)
            {
                if (Paging.SelectPage == i)
                {
                    output.Content.AppendHtml($@"<li class='active'><a>{i}</a></li>");
                    
                }
                else
                {
                    
                    output.Content.AppendHtml($@"<li><a href='{UrlHelper.Action("Index", "Store", new { Paging.Category, Paging.Brand, Paging.Color, SelectPage=i, Paging.ShowPage, Paging.TotalPage })}'>{i}</a></li>");
                }
            } 

                output.Content.AppendHtml($@"<li><a href='#'>»</a></li></ul>
                </div>
                <div class='pull-right pull-right col-sm-4 col-xs-12 no-padding text-right text-left-xs'>
                    <p>Showing {Paging.SelectPage}–{Paging.TotalPage} of 12 results</p>
                </div>
            </div>");

        }
    }
}
