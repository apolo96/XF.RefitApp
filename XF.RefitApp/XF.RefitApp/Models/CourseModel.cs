using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.RefitApp.Models
{
    public class CourseModel
    {
        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "codigo")]
        public string Codigo { get; set; }

        [JsonProperty(PropertyName = "primer_corte")]
        public string PrimerCorte { get; set; }

        [JsonProperty(PropertyName = "segundo_corte")]
        public string SegundoCorte { get; set; }

        [JsonProperty(PropertyName = "tercer_corte")]
        public string TercerCorte { get; set; }

        [JsonProperty(PropertyName = "links")]
        public Links Deatil { get; set; }
        
        public class Links
        {
            public string detalle { get; set; }
        }                 
    }
}
