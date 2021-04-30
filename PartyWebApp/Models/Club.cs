using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string maxCapacity { get; set; }
        public List<string> imagesUrl;

        //[NotMapped]
       /*public string[] imagesUrl
        {
            get
            {
                return this.imagesUrlDTO.Split(',');
            }
            set
            {
                this.imagesUrlDTO = string.Join(',',imagesUrl);
            }
        }
        public string imagesUrlDTO { get; set; }
       */
    }
}
