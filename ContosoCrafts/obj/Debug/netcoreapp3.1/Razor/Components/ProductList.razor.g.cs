#pragma checksum "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35759017f67f36c581342e8d4274343e01397d7f"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
using ContosoCrafts.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
using ContosoCrafts.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 12 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, @"<div class=""card-footer"">
                <small class=""text-muted"">
                    <button @onclick=""(e => SelectProduct(product.Id)"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                        More Info
                    </button>
                </small>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 23 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\brahimkellou\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591