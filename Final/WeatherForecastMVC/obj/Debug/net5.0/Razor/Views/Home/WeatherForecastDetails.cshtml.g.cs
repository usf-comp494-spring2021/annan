#pragma checksum "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a50427dcefb8cad695a1fdb2330169729b0833b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeatherForecastDetails), @"mvc.1.0.view", @"/Views/Home/WeatherForecastDetails.cshtml")]
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
#line 1 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\_ViewImports.cshtml"
using WeatherForecastMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\_ViewImports.cshtml"
using WeatherForecastMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a50427dcefb8cad695a1fdb2330169729b0833b", @"/Views/Home/WeatherForecastDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b36a524be64b423cc3d2efb3156d151e004392", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeatherForecastDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherForecastMVC.Models.WeatherForecastDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
   
    ViewData["Title"] = "WeatherForecastDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Weather Forecast Details</h1>\r\n<h3>\r\n    ");
#nullable restore
#line 8 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 9 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
Write(Model.forecastDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n\r\n<div style=\"column-count:2\">\r\n    <p>\r\n        <strong>Temperature: </strong>");
#nullable restore
#line 14 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                                 Write(Model.temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral("°F<br />\r\n        <strong>Feels like: </strong>");
#nullable restore
#line 15 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                                Write(Model.feelsLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("°F<br />\r\n        <strong>Descriptor: </strong>");
#nullable restore
#line 16 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                                Write(Model.descriptor);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Wind speed: </strong>");
#nullable restore
#line 17 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                                Write(Model.windSpeed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mph<br />\r\n        <strong>Wind direction: </strong>");
#nullable restore
#line 18 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                                    Write(Model.windDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Pressure: </strong>");
#nullable restore
#line 19 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                              Write(Model.pressure);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kPa<br />\r\n        <strong>Visibility: </strong>");
#nullable restore
#line 20 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                                Write(Model.visibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("%<br />\r\n        <strong>Clouds: </strong>");
#nullable restore
#line 21 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                            Write(Model.clouds);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Humidity: </strong>");
#nullable restore
#line 22 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                              Write(Model.humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral("%<br />\r\n        <strong>Rainfall: </strong>");
#nullable restore
#line 23 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                              Write(Model.rainfall);

#line default
#line hidden
#nullable disable
            WriteLiteral("%<br />\r\n        <strong>Snowfall: </strong>");
#nullable restore
#line 24 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
                              Write(Model.snowfall);

#line default
#line hidden
#nullable disable
            WriteLiteral("%<br />\r\n    </p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a50427dcefb8cad695a1fdb2330169729b0833b8690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 997, "~/images/", 997, 9, true);
#nullable restore
#line 28 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
AddHtmlAttributeValue("", 1006, Model.imagePath, 1006, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\harry\OneDrive - University of St. Francis\7_2021 Spring\C#\Projects\Final\WeatherForecastMVC\Views\Home\WeatherForecastDetails.cshtml"
AddHtmlAttributeValue("", 1035, Model.imagePath, 1035, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherForecastMVC.Models.WeatherForecastDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
