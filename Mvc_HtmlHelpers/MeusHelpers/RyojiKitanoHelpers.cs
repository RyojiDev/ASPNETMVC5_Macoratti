using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_HtmlHelpers.MeusHelpers
{
    public static class RyojiKitanoHelpers
    {
        public static IHtmlString Imagem(this HtmlHelper helper, string src,string alt)
        {
            //Criar uma tag <img>
            TagBuilder tb = new TagBuilder("img");
            // Adiciona o atributo "src"
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            //adiciona o atributo alt
            tb.Attributes.Add("alt", alt);
            // retorna uma MvcHtmlString. esta classe implementa a interface IHtmlString
            // IHtmlStrings não será html codificado
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}