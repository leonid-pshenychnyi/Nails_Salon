#pragma checksum "C:\Users\bredu\Desktop\huila\Nails_Salon\Nails-Salon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701d9de89e14267eb3073846f7d11c33157a03f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\bredu\Desktop\huila\Nails_Salon\Nails-Salon\Views\_ViewImports.cshtml"
using Nails_Salon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bredu\Desktop\huila\Nails_Salon\Nails-Salon\Views\_ViewImports.cshtml"
using Nails_Salon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701d9de89e14267eb3073846f7d11c33157a03f3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3e95d6f08a2ae9e2340e5887e186e9446df668", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bredu\Desktop\huila\Nails_Salon\Nails-Salon\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
<div class=""row"" style=""margin-top: 100px"">
    <div class=""col-8"">
        <p style=""font-size: 40px !important;"" class=""text-left text-white"">ЧТО ДЛЯ НАС МАНИКЮР?</p>
        <p style=""font-family: DefaultFont, serif !important; font-size: 20px"" class=""text-white text-left"">
            Красивый маникюр - это то, что просто необходимо каждой женщине, ведь ухоженные руки одно из самых основных вещей во внешнем виде.Вы можете быть одетой в спортивную одежду,
            и быть без макияжа, но руки должны всегда привлекать внимание своей красотой. Предложений
            по маникюру сейчас достаточно много, салоны красоты предлагают большое количество услуг,
            в которые входят различные покрытия и наращивания ногтей. Но найти хорошего мастеа по
            маникюру не так уж и легко. Ведь хочется, чтобы именно ваши ручки были индивидуальны.
        </p>
    </div>
    <div class=""col-4"" style=""margin-top: 20px; font-size: 20px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701d9de89e14267eb3073846f7d11c33157a03f34433", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""text-white"" for=""formGroupExampleInput"">Имя</label>
                <input style=""background: transparent !important; font-size: 20px"" type=""text"" class=""text-white form-control"" id=""formGroupExampleInput"" placeholder=""Ваше имя"">
            </div>
            <div class=""form-group"">
                <label class=""text-white"" for=""formGroupExampleInput2"">Телефон</label>
                <input style=""background: transparent !important; font-size: 20px "" type=""text"" class=""text-white form-control"" id=""formGroupExampleInput2"" placeholder=""Ваш телефон"">
            </div>
            <div>
                <button style=""margin-top: 20px; border-color: #f47994 !important; border-radius: 5px !important; border-width: 3px !important; background-color: #000000 !important; font-family: Fulbo, serif; font-size: 20px;"" type=""button"" class=""container btn btn-dark btn-sm"">Записаться на приём</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<div class=""text-center container align-content-center cent"">
    <h1 style=""font-family: Fulbo, serif !important; margin-top: 100px"" class=""text-white"">Наши услуги</h1>
    <p style=""font-family: DefaultFont, serif !important; margin-top: -10px;font-size: 20px"" class=""text-white"">Наш салон продоставляет широкий спектр услуг в области маникюра и педикюра</p>
    <div class=""row justify-content-md-center"">
        <div class=""col col-lg-7"">
            <hr style=""border: 2px solid #f47994 !important; opacity: unset !important; margin-top: -10px;""/>
        </div>
    </div>
</div>
<div class=""row"" style=""margin-top: 30px"">
");
            WriteLiteral("    <div class=\"col-3\">\n        <img src=\"images/5.jpg.png\">\n    </div>\n    <div class=\"col\">\n");
            WriteLiteral(@"    </div>
    <div class=""col-8"">
        <h2 class=""text-white"">Маникюр</h2>
        <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 22px"">
            Забота о руках и ногтях - это залог сильных и красивых ногтей. Можно выполнять определенные процедуры самостоятельно,
            но многие предпочитают обращаться к специалистам. От правильно проведенных манипуляций будет зависеть конечный результат.
            Различают два способа подготовки и проведения маникюра: гигиенический маникюр и декоративный маникюр.
            При этом, гигиенический маникюр послужит основой для качественного декоративного.
        </p>
    </div>
</div>

<div class=""row"" style=""margin-top: 50px"">
");
            WriteLiteral(@"    <div class=""col-8"">
        <h2 style=""text-align: right"" class=""text-white"">Педикюр</h2>
        <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 22px"">
            Ухоженные стопы и пальцы ног - это красивые и здоровые ноги. Безусловно,
            лучший уход - профессиональный. Домашний педикюр - отлично справляется
            с функцией поддержки ухоженного вида, но для того, чтобы раз в месяц навести
            “генеральный марафет” ног, все таки, лучше обратиться к специалисту и сделать
            профессиональный педикюр.
        </p>
    </div>
    <div class=""col-3"">
        <img src=""images/3.jpg.png"">
    </div>
    <div class=""col"" style=""width: 500px; height: 500px; background-color: transparent""></div>
</div>
<div class=""row"" style=""margin-top: -150px"">
");
            WriteLiteral("    <div class=\"col-3\">\n        <img src=\"images/15.png\">\n    </div>\n    <div class=\"col\">\n");
            WriteLiteral(@"    </div>
    <div class=""col-8"">
        <h2 class=""text-white"">Покрытие гель-лаком</h2>
        <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 22px"">
            Наносится оно как обычный лак, но сохраняет стойкость гелевого покрытия.
            Суперустойчивое цветовое покрытие полюбилось женщинам тем, что держится
            на ногтях около 3 недель. Поверхность его не скалывается, не теряет цвета
            и свежего блеска. Снимать гель приходится из-за того, что отросшая снизу
            часть ногтя начинает бросаться в глаза.
        </p>
    </div>
</div>
<div class=""text-center container align-content-center cent"">
    <h1 style=""font-family: Fulbo, serif !important;"" class=""text-white"">Почему мы?</h1>
    <p style=""font-family: DefaultFont, serif !important; margin-top: -10px;font-size: 20px"" class=""text-white"">С нами вы получите не только желаймый результат, но и многое другое!</p>
    <div class=""row justify-content-md-center"">
        <div c");
            WriteLiteral("lass=\"col col-lg-7\">\n            <hr style=\"border: 2px solid #f47994 !important; opacity: unset !important; margin-top: -10px;\"/>\n        </div>\n    </div>\n</div>\n<div class=\"row gx-5\" style=\"margin-top: 30px\">\n");
            WriteLiteral(@"    <div class=""col-3"">
        <img src=""images/2.png"">
    </div>
    <div class=""col-3"">
        <div class=""box"">
            <h2 class=""text-white"">Опытные мастера</h2>
            <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 20px"">
                С нашими мастерами вы всегда в надёжных руках.
                Они вас проконсультируют, помогут с выбором
                дизайна и сделают качественно свою работу.
            </p>
        </div>
    </div>

    <div class=""col-3"">
        <img src=""images/17.jpg.png"">
    </div>
    <div class=""col-3"">
        <div class=""box"">
            <h2 style=""text-align: left"" class=""text-white"">Обработка инструментов</h2>
            <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 20px"">
                Бнзобасность и здоровье клиента одно из
                основопологающих нашего салона. После
                использования маникюрных инструментов,
                ");
            WriteLiteral("их отправляют на аппаратную стерилизацию.\n            </p>\n        </div>\n    </div>\n</div>\n<div class=\"row\" style=\"margin-top: 50px\">\n");
            WriteLiteral(@"    <div class=""col-3"">
        <img src=""images/6.jpg"">
    </div>

    <div class=""col-3"">
        <div class=""box"">
            <h2 class=""text-white"" style=""font-family: Fulbo, serif; font-size: 25px"">Качественные материалы</h2>
            <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 20px"">
                Мы используем только профессиональный и
                качественный материал. Ведь только так можно
                получить надёжный и превосходный результат.
            </p>
        </div>
    </div>
    <div class=""col-3"">
        <img src=""images/8.jpg"">
    </div>

    <div class=""col-3"">
        <div class=""box"">
            <h2 class=""text-white"">Уютная обстановка</h2>
            <p style=""text-align: left; color: white; font-family: DefaultFont, serif !important; font-size: 20px"">
                В салоне вас ожидает только тепло и уют.
                Здесь вы можете раслабиться, выпить кофе или
                чай и отдохнуть, пока мастер");
            WriteLiteral(@" выполняет работу.
            </p>
        </div>
    </div>
</div>

<div class=""text-center container align-content-center cent"">
    <h1 style=""font-family: Fulbo, serif !important; margin-top: 100px"" class=""text-white"">Наши работы</h1>
    <p style=""font-family: DefaultFont, serif !important; margin-top: -10px;font-size: 20px"" class=""text-white"">Подписывайтесь на наш блог в социальной сети Instagram</p>
    <div class=""row justify-content-md-center"">
        <div class=""col col-lg-7"">
                    <hr style=""border: 2px solid #f47994 !important; opacity: unset !important; margin-top: -10px;""/>
                </div>
    </div>
</div>

<div class=""container"">
    <div class=""row g-2"">
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
");
            WriteLiteral(@"        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
        <div class=""col-3"">
            <img src=""images/1.jpg"">
        </div>
    </div>
</div>

<div class=""text-center container align-content-center cent"">
    <h1 style=""font-family: Fulbo, serif !important; margin-top: 100px"" class=""text-white"">маникюрный Салон N.A.I.L.S.</h1>
    <p style=""font-family: DefaultFont, serif !important; margin-top: -10px;font-size: 20px"" class=""text-white"">N.A.I.L.S. - мы ваше хорошее настроение!</p>
    <div class=""row justify-content-md-center"">
        <div class=""col col-lg-7"">
                    <hr style=""border: 2px solid #f47994 !important; opacity: unset !important; margin-top: -10px;""/>
                </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-5"">
        <img src=""images/bg.jpg"" alt=""Salon"">
    </div>
 ");
            WriteLiteral(@"   <div class=""col-7"">
        <p class=""text-white"" style=""font-family: DefaultFont, serif !important; font-size: 20px"">
            Мы не просто маникюрный салон. Мы те, кто воплотит ваши желания в
            жизнь и сделает это в лучшем виде. Наш уютный салон оставит у вас
            только положительные впечатления, и не только от маникюра!

            В салоне вас ждут опытные и дружелюбные мастера, которые своей работе
            учитывают особенности каждого клиента, стараясь подчеркнуть вашу
            индивидуальность. Почувствуйте себя неповторимо и комфортно в новом образе,
            созданном в соответствии как с вашими пожеланиями, так и с последними
            веяниями моды. Также мы предостовляем приятные бонусы с нашей системой
            лояльности, вкусный кофе и фирменную сувенирную продукцию, чтобы вы зтали,
            что мы всегда под рукой.
        </p>
    </div>
</div>
<div class=""text-center container align-content-center cent"">
    <h1 style=""font-family: Fulbo, serif !imp");
            WriteLiteral(@"ortant; margin-top: 100px"" class=""text-white"">Как нас найти?</h1>
    <p style=""font-family: DefaultFont, serif !important; margin-top: -10px;"" class=""text-white"">Мы находимся по адресу: г. Харьков, ул. Пушкина 34</p>
    <div class=""row justify-content-md-center"">
        <div class=""col col-lg-7"">
            <hr style=""border: 2px solid #f47994 !important; opacity: unset !important; margin-top: -10px;""/>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-2"">
        <h2 style=""font-family: Fulbo"" class=""text-white"">Адрес</h2>
        <p style=""font-family: DefaultFont !important; font-size: 20px"" class=""text-white"">г. Харьков,<br> 
            ул. Пушкина 34</p>
        <br>
        <h2 style=""font-family: Fulbo"" class=""text-white"">Телефон</h2>
        <p style=""font-family: DefaultFont !important;font-size: 20px"" class=""text-white"">+38 (050) 921-20-30<br>
            +38 (097) 997-97-66</p>
        <br>
        <h2 style=""font-family: Fulbo"" class=""text-white"">Instagram</h2>
        <p");
            WriteLiteral(@" style=""font-family: DefaultFont !important;font-size: 20px"" class=""text-white"">https://www.instagram.com/</p>
        <br>
        <h2 style=""font-family: Fulbo"" class=""text-white"">Email</h2>
        <p style=""font-family: DefaultFont !important;font-size: 20px"" class=""text-white"">nails.kh@gmail.com</p>
    </div>
    <div class=""col-10"">
        <iframe class=""container"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d20518.585967096897!2d36.0241789398887!3d49.995923220509724!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x412798626d321d15%3A0xe162ae39bb16f654!2z0KHQvtC70L7QvdC40YbQtdCy0LrQsCwg0KXQsNGA0YzQutC-0LLRgdC60LDRjyDQvtCx0LvQsNGB0YLRjCwgNjIzNjg!5e0!3m2!1sru!2sua!4v1617716147706!5m2!1sru!2sua"" width=""500"" height=""500"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 12860, "\"", 12878, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\n    </div>\n</div>\n\n</div>");
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
