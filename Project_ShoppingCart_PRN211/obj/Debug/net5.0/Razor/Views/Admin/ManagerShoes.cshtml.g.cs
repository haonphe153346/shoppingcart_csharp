#pragma checksum "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf37947f69ec475bcf524ad2be8bfb086d029015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManagerShoes), @"mvc.1.0.view", @"/Views/Admin/ManagerShoes.cshtml")]
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
#line 2 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
using Project_ShoppingCart_PRN211;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
using Project_ShoppingCart_PRN211.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
using System.Web.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf37947f69ec475bcf524ad2be8bfb086d029015", @"/Views/Admin/ManagerShoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf79f43d1ddf81bb5b2f5b06c84ad0d2b799f57", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ManagerShoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Project_ShoppingCart_PRN211.Models.Shoe>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagerShoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagerCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagerOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddShoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditShoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d0290157754", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>
        Apex Admin
    </title>
    <link rel=""shortcut icon"" href=""/images/logo-mb.png"" type=""image/png"">
    <!-- GOOGLE FONT -->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap"" rel=""stylesheet"">
    <!-- BOXICONS -->
    <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
    <!-- APP CSS -->
    <link rel=""stylesheet"" href=""/css/grid.css"">
    <link rel=""stylesheet"" href=""/css/app.css"">
     <script type=""text/javascript"">
            function doDelete(id) {
                if (confirm(""Are u sure to delete category with id="" + id + "" ?"")) {
                    window.location = ""/Admin/DeleteShoes?ShoesId="" + id;
                WriteLiteral("\n                }\r\n            }\r\n        </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d0290159881", async() => {
                WriteLiteral(@"

    <!-- SIDEBAR -->
    <div class=""sidebar"">
        <div class=""sidebar-logo"">
            <img src=""/images/logo-lg.png"" alt=""Comapny logo"">
            <div class=""sidebar-close"" id=""sidebar-close"">
                <i class='bx bx-left-arrow-alt'></i>
            </div>
        </div>
        <div class=""sidebar-user"">
            <div class=""sidebar-user-info"">
                <img src=""./images/user-image.jpg"" alt=""User picture"" class=""profile-image"">
                <div class=""sidebar-user-name"">
                    ");
#nullable restore
#line 51 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
               Write(ViewBag.Account.AccountName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901511053", async() => {
                    WriteLiteral("\r\n                <button class=\"btn btn-outline\">\r\n                    <i class=\'bx bx-log-out bx-flip-horizontal\'></i>\r\n                </button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n        <!-- SIDEBAR MENU -->\r\n        <ul class=\"sidebar-menu\">\r\n            <li>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901512784", async() => {
                    WriteLiteral("\r\n                    <i class=\'bx bx-home\'></i>\r\n                    <span>dashboard</span>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901514474", async() => {
                    WriteLiteral("\r\n                    <i class=\'bx bx-shopping-bag\'></i>\r\n                    <span>Manager Shoes</span>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901516089", async() => {
                    WriteLiteral("\r\n                    <i class=\'bx bx-chart\'></i>\r\n                    <span>Manager Category</span>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901517700", async() => {
                    WriteLiteral("\r\n                    <i class=\'bx bx-calendar\'></i>\r\n                    <span>Manager Order</span>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </li>
           
        </ul>
        <!-- END SIDEBAR MENU -->
    </div>
    <!-- END SIDEBAR -->
    <!-- MAIN CONTENT -->
    <div class=""main"">
        <div class=""main-header"">
            <div class=""mobile-toggle"" id=""mobile-toggle"">
                <i class='bx bx-menu-alt-right'></i>
            </div>
            <div class=""main-title"">
                dashboard
            </div>
        </div>
        <div class=""main-content"">





            <div class=""col-12"">
                <!-- ORDERS TABLE -->
                <div class=""box"">
                    <div class=""box-header"">
                        Manager Shoes
                    </div>
                    <br/>
                    <div class=""box-header"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901520078", async() => {
                    WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-outline-primary\">Add new Shoes</button>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    <div class=""box-body overflow-scroll"">
                        <table>
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Category</th>
                                    <th>Price</th>
                                    <th>Quantity</th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 134 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 137 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                       Write(item.ShoesId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"order-owner\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 5287, "\"", 5317, 2);
                WriteAttributeValue("", 5293, "/images/", 5293, 8, true);
#nullable restore
#line 140 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
WriteAttributeValue("", 5301, item.ShoesImage, 5301, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"user image\">\r\n                                                <span>");
#nullable restore
#line 141 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                                 Write(item.ShoesName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 144 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                       Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 145 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                       Write(item.ShoesPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>

                                        <td>
                                            <div class=""payment-status payment-pending"">
                                                <div class=""dot""></div>
                                                <span>");
#nullable restore
#line 150 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                                 Write(item.ShoesQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901525677", async() => {
                    WriteLiteral("\r\n                                                <span class=\"order-status order-ready\">\r\n                                                View/Edit\r\n                                            </span>\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ShoesId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                                                                                    WriteLiteral(item.ShoesId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ShoesId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ShoesId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ShoesId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            \r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
                BeginWriteAttribute("onclick", " onclick=\"", 6663, "\"", 6698, 3);
                WriteAttributeValue("", 6673, "doDelete(\'", 6673, 10, true);
#nullable restore
#line 162 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
WriteAttributeValue("", 6683, item.ShoesId, 6683, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6696, "\')", 6696, 2, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""order-status order-ready"">
                                                Delete
                                            </span>
                                              </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 169 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n                <!-- END ORDERS TABLE -->\r\n            </div>\r\n            <br />\r\n            Trang ");
#nullable restore
#line 177 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
              Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 177 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                                                            Write(Model.PageCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <br />\r\n            <nav aria-label=\"Page navigation example\">\r\n                <ul class=\"pagination\">\r\n                    \r\n                    \r\n");
#nullable restore
#line 184 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                     for (var i = 0; i < Model.PageCount; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"page-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf37947f69ec475bcf524ad2be8bfb086d02901531327", async() => {
#nullable restore
#line 186 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                                                                                                                        Write(i+1);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                                                                                                                         WriteLiteral(i+1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n");
#nullable restore
#line 187 "D:\PRN2911\project_prn211\Project_ShoppingCart_PRN211\Project_ShoppingCart_PRN211\Views\Admin\ManagerShoes.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    
                </ul>
            </nav>


            <br /> <br /> <br /> <br /> <br /> <br />
            <div class=""site-block-27"">
                <ul>
                    <li></li>
                </ul>
            </div>
        </div>
    </div>

    <!-- END MAIN CONTENT -->

    <div class=""overlay""></div>
    </div>
    <!-- SCRIPT -->
    <!-- APEX CHART -->
    <script src=""https://cdn.jsdelivr.net/npm/apexcharts""></script>
    <!-- APP JS -->
    <script src=""/js/app.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<Project_ShoppingCart_PRN211.Models.Shoe>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591