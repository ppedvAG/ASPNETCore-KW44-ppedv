﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using RazorPageSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageSamples.TagHelpers
{
    public class WebsiteInformationTagHelper : TagHelper
    {
        public WebsiteContext Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Content.SetHtmlContent(
   $@"<ul><li><strong>Version:</strong> {Info.Version}</li>
                <li><strong>Copyright Year:</strong> {Info.CopyrightYear}</li>
                <li><strong>Approved:</strong> {Info.Approved}</li>
                <li><strong>Number of tags to show:</strong> {Info.TagsToShow}</li></ul>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
