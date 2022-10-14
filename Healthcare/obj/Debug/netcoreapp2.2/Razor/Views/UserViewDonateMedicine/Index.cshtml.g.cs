#pragma checksum "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e54d52fc4891985638737a43f2d6902d78822f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserViewDonateMedicine_Index), @"mvc.1.0.view", @"/Views/UserViewDonateMedicine/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserViewDonateMedicine/Index.cshtml", typeof(AspNetCore.Views_UserViewDonateMedicine_Index))]
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
#line 1 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\_ViewImports.cshtml"
using Healthcare;

#line default
#line hidden
#line 2 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\_ViewImports.cshtml"
using Healthcare.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e54d52fc4891985638737a43f2d6902d78822f", @"/Views/UserViewDonateMedicine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e33c364396082acf2ff281ef424c6d518bd8bba", @"/Views/_ViewImports.cshtml")]
    public class Views_UserViewDonateMedicine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
  
    Layout = "UserLayout";
    List<Donation> userDonations = ViewBag.userDonations as List<Donation>;

#line default
#line hidden
            BeginContext(235, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(260, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e54d52fc4891985638737a43f2d6902d78822f3772", async() => {
                BeginContext(266, 167, true);
                WriteLiteral("\r\n    <style>\r\n        tr, th {\r\n            border: 1px solid black;\r\n            min-width: 200px;\r\n        }\r\n    </style>\r\n    <title>User Donate Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(440, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(442, 1721, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e54d52fc4891985638737a43f2d6902d78822f5135", async() => {
                BeginContext(448, 415, true);
                WriteLiteral(@"
    <h3><label>User Donate Details</label></h3>
    <br />
    <table>
        <tr>
            <th><label>Medicine Category</label></th>
            <th><label>Medicine Name</label></th>
            <th><label>Donated Quantity</label></th>
            <th><label>Donor Name</label></th>
            <th><label>Pickup Address</label></th>
            <th><label>Donated Date</label></th>
        </tr>
");
                EndContext();
#line 31 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
         if (userDonations.Count > 0)
        {
            

#line default
#line hidden
#line 33 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
             for (int i = 0; i < userDonations.Count; i++)
            {
                string medCategory = String.Format("medCategory{0}", i);
                string medName = String.Format("medName{0}", i);
                string medQty = String.Format("medQty{0}", i);
                string reqName = String.Format("reqName{0}", i);
                string pickAddress = String.Format("pickAddress{0}", i);
                string donatedDate = String.Format("donatedDate{0}", i);

#line default
#line hidden
                BeginContext(1406, 52, true);
                WriteLiteral("                <tr>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("id", " id=", 1458, "", 1474, 1);
#line 42 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
WriteAttributeValue("", 1462, medCategory, 1462, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1474, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1476, 33, false);
#line 42 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
                                          Write(userDonations[i].medicineCatagory);

#line default
#line hidden
                EndContext();
                BeginContext(1509, 45, true);
                WriteLiteral("</label></th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("id", " id=", 1554, "", 1566, 1);
#line 43 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
WriteAttributeValue("", 1558, medName, 1558, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1566, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1568, 29, false);
#line 43 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
                                      Write(userDonations[i].medicineName);

#line default
#line hidden
                EndContext();
                BeginContext(1597, 45, true);
                WriteLiteral("</label></th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("id", " id=", 1642, "", 1653, 1);
#line 44 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
WriteAttributeValue("", 1646, medQty, 1646, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1653, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1655, 31, false);
#line 44 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
                                     Write(userDonations[i].donateQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(1686, 45, true);
                WriteLiteral("</label></th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("id", " id=", 1731, "", 1743, 1);
#line 45 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
WriteAttributeValue("", 1735, reqName, 1735, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1743, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1745, 26, false);
#line 45 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
                                      Write(userDonations[i].donorName);

#line default
#line hidden
                EndContext();
                BeginContext(1771, 45, true);
                WriteLiteral("</label></th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("id", " id=", 1816, "", 1832, 1);
#line 46 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
WriteAttributeValue("", 1820, pickAddress, 1820, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1832, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1834, 30, false);
#line 46 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
                                          Write(userDonations[i].pickupAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1864, 45, true);
                WriteLiteral("</label></th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("id", " id=", 1909, "", 1925, 1);
#line 47 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
WriteAttributeValue("", 1913, donatedDate, 1913, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1925, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1927, 51, false);
#line 47 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
                                          Write(userDonations[i].donatedDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1978, 38, true);
                WriteLiteral("</label></th>\r\n                </tr>\r\n");
                EndContext();
#line 49 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
            }

#line default
#line hidden
#line 49 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
             
        }

#line default
#line hidden
                BeginContext(2042, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
#line 52 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
     if (userDonations.Count == 0)
    {

#line default
#line hidden
                BeginContext(2099, 50, true);
                WriteLiteral("        <label id=\"noData\">No data found</label>\r\n");
                EndContext();
#line 55 "C:\Users\LENOVO-PC\Desktop\Healthcare\Healthcare\Views\UserViewDonateMedicine\Index.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(2163, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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