#pragma checksum "F:\MitechCenter.vn\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52981824be133798f9fb7949683f37d3521fba78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\MitechCenter.vn\Views\_ViewImports.cshtml"
using MitechCenter.vn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
using MitechCenter.vn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52981824be133798f9fb7949683f37d3521fba78", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c74aad799e1d51f7d91cfc76d5d0e34100e56c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
  
    Layout = "~/Views/Shared/_MetaLayout.cshtml";
    ViewData["Title"] = "COURSE";
    IEnumerable<Teacher> teachers = ViewBag.Teachers;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- breadcrumb start-->
<section class=""breadcrumb breadcrumb_bg"" style=""background: url('./img/tt1.jpg');background-position: center;background-repeat: no-repeat;background-size: cover;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb_iner text-center"">
                    <div class=""breadcrumb_iner_item"">
                        <h2>KHÓA HỌC</h2>
                        <p>Trang chủ<span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- breadcrumb start-->
<!--::review_part start::-->
<section class=""special_cource padding_top mb-5"" style=""margin-top: -50px"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-5"">
                <div class=""section_tittle text-center"">
                    <p>Danh sách</p>
                    <h2>Khóa học hiện có</h2>
                </div>
          ");
            WriteLiteral("  </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 36 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
             foreach (Course course in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 col-lg-4\">\r\n                    <div class=\"single_special_cource\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1480, "\"", 1500, 1);
#nullable restore
#line 40 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
WriteAttributeValue("", 1486, course.cImage, 1486, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"special_img\"");
            BeginWriteAttribute("alt", " alt=\"", 1521, "\"", 1527, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"special_cource_text\">\r\n                            <a href=\"course-details.html\" class=\"btn_4\">");
#nullable restore
#line 42 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                                                                   Write(course.cLearningTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <h4>");
#nullable restore
#line 43 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                           Write(String.Format("{0:###,###,###,###}", course.cPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (VNĐ)</h4>\r\n                            <a href=\"course-details.html\">\r\n                                <h3>");
#nullable restore
#line 45 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                               Write(course.cName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </a>\r\n                            <p>");
#nullable restore
#line 47 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                          Write(course.cDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                             foreach (Teacher teacher in teachers)
                            {
                                if (teacher.tId == course.tId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"author_info\">\r\n                                        <div class=\"author_img\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2368, "\"", 2390, 1);
#nullable restore
#line 54 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
WriteAttributeValue("", 2374, teacher.tAvatar, 2374, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2391, "\"", 2397, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"author_info_text\">\r\n                                                <p>Giảng viên</p>\r\n                                                <h5><a href=\"#\">");
#nullable restore
#line 57 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                                                           Write(teacher.tDisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 61 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
                                    break;
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 68 "F:\MitechCenter.vn\Views\Course\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!--::blog_part end::-->\r\n\r\n");
            DefineSection("styles", async() => {
                WriteLiteral(@"
    <style>
        .special_img {
            width: 100%;
            height: 240px;
            object-fit: cover;
        }

        .author_img img {
            width: 50px;
            height: 50px;
            border-radius: 50%;
            object-fit: cover;
        }

        .single_special_cource p {
            text-align: justify;
            overflow: hidden;
            text-overflow: ellipsis;
            display: -webkit-box;
            -webkit-line-clamp: 4; /* number of lines to show */
            -webkit-box-orient: vertical;
            font-size:18px;
        }

        .special_cource .single_special_cource .special_cource_text h3 {
            overflow: hidden;
            text-overflow: ellipsis;
            display: -webkit-box;
            -webkit-line-clamp: 3; /* number of lines to show */
            -webkit-box-orient: vertical;
            font-size: 26px;
        }
    </style>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
