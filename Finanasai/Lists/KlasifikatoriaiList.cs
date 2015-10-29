using System.Collections.Generic;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace Finanasai.Models
{
    public class KlasifikatoriaiList
    {
        public int Id { get; set; }
        public string KlasifikatoriusName;

        public static string GetControllerName(int id)
        {
            var name = "";
            switch (id)
            {
                case 0:
                    name = "Metai";
                    break;
                case 1:
                    name = "Menesiai";
                    break;
                case 2:
                    name = "Savaites";
                    break;
                case 3:
                    name = "Dienos";
                    break;
            }
            return name;
        }

        public static IEnumerable<SelectListItem> GetKlasifikatoriaiSelectList()
        {
            return new[]
            {
                new SelectListItem {Value = "0", Text = "Metai"},
                new SelectListItem {Value = "1", Text = "Menesiai"},
                new SelectListItem {Value = "2", Text = "Savaites"},
                new SelectListItem {Value = "3", Text = "Dienos"},
            };
        }
    }
}