using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAdMS.Entity
{
    public class AdvertisementDetails
    {
        public string Advertisement_catagoery { get; set; }
        //public string Book_Advertisement { get; set; }
        public string newspaper_type { get; set; }
        public string avaliablity_adv { get; set; }
        public string adv_type { get; set; }
        public string location { get; set; }
        public int cost_settings { get; set; }
        public int payment { get; set; }
        public DateTime date_avalibility { get; set; }
        public string rating { get; set; }
    }
}
