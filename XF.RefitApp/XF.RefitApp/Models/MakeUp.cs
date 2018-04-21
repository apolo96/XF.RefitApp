using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.RefitApp.Models
{
    public class MakeUp
    {
        
        public int id { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public object price_sign { get; set; }
        public object currency { get; set; }
        public string image_link { get; set; }
        public string product_link { get; set; }
        public string website_link { get; set; }
        public string description { get; set; }
        public double? rating { get; set; }
        public string category { get; set; }
        public string product_type { get; set; }
        public IList<object> tag_list { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string product_api_url { get; set; }
        public string api_featured_image { get; set; }
        public IList<ProductColor> product_colors { get; set; }
    }

    public class ProductColor
    {
        public string hex_value { get; set; }
        public string colour_name { get; set; }
    }
}
