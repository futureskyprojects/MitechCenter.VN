#pragma checksum "F:\MitechCenter.vn\Areas\MCMS\Views\Copyright\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171a36afb48aeaf533df4c70aadd6734885b5382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MCMS_Views_Copyright_Index), @"mvc.1.0.view", @"/Areas/MCMS/Views/Copyright/Index.cshtml")]
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
#line 1 "F:\MitechCenter.vn\Areas\MCMS\Views\_ViewImports.cshtml"
using MitechCenter.vn;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171a36afb48aeaf533df4c70aadd6734885b5382", @"/Areas/MCMS/Views/Copyright/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c74aad799e1d51f7d91cfc76d5d0e34100e56c7", @"/Areas/MCMS/Views/_ViewImports.cshtml")]
    public class Areas_MCMS_Views_Copyright_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\MitechCenter.vn\Areas\MCMS\Views\Copyright\Index.cshtml"
  
	ViewData["Title"] = "SỞ HỮU";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-wrapper"">
	<!-- ============================================================== -->
	<!-- Preloader - style you can find in spinners.css -->
	<!-- ============================================================== -->
	<div class=""preloader"">
		<div class=""lds-ripple"">
			<div class=""lds-pos""></div>
			<div class=""lds-pos""></div>
		</div>
	</div>
	<!-- ============================================================== -->
	<!-- Preloader - style you can find in spinners.css -->
	<!-- ============================================================== -->
	<!-- ============================================================== -->
	<!-- Login box.scss -->
	<!-- ============================================================== -->
	<div class=""auth-wrapper d-flex no-block justify-content-center align-items-center position-relative""
		style=""background:url(assets/images/big/auth-bg.jpg) no-repeat center center;"">
		<div class=""auth-box row"">
			<div class=""col-lg-7 col-md-5 modal-bg-img"" style=""ba");
            WriteLiteral("ckground-image: url(assets/images/big/LoginPanel.png);\">\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-lg-5 col-md-7 bg-white\">\r\n\t\t\t\t<div class=\"p-3\">\r\n");
            WriteLiteral("\t\t\t\t\t<h2 class=\"mt-3 text-center\">ĐĂNG NHẬP</h2>\r\n\t\t\t\t\t<p class=\"text-center\" style=\"font-size: 12px;\">Nhập tài khoản và mật khẩu của bạn để truy cập trang quản trị.</p>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "171a36afb48aeaf533df4c70aadd6734885b53825044", async() => {
                WriteLiteral(@"
						<div class=""row"">
							<div class=""col-lg-12"">
								<div class=""form-group"">
									<label class=""text-dark"" for=""uname"">Tên đăng nhập</label>
									<input class=""form-control"" id=""uname"" type=""text""
										placeholder=""Nhập tên đăng nhập"">
								</div>
							</div>
							<div class=""col-lg-12"">
								<div class=""form-group"">
									<label class=""text-dark"" for=""pwd"">Mật khẩu</label>
									<input class=""form-control"" id=""pwd"" type=""password""
										placeholder=""Nhập mật khẩu"">
								</div>
							</div>
							<div class=""col-lg-12 text-center"">
								<button type=""submit"" class=""btn btn-block btn-dark"">Đăng nhập</button>
							</div>
");
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<!-- ============================================================== -->\r\n\t<!-- Login box.scss -->\r\n\t<!-- ============================================================== -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
