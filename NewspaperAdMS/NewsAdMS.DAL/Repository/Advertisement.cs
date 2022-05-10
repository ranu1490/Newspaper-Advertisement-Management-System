using NewsAdMS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAdMS.DAL.Repository
{
    internal class Advertisement : IAdvertisement
    {
        public string BookAd(AdvertisementDetails advertisementDetails)
        {
            return "Booked";
        }

        public string DeleteAd(string Adv_Type)
        {
            return "Deleted";
        }

        public List<AdvertisementDetails> GetAllAdvertisements()
        {
            return new List<AdvertisementDetails>();
        }
        public string UpdateAd(AdvertisementDetails advertisementDetails)
        {
            return "Updated";
        }

        public AdvertisementDetails GetBook(string Adv_Type)
        {
            AdvertisementDetails advertisementDetails = new AdvertisementDetails();
            return advertisementDetails;
        }

        public string SaveAd(AdvertisementDetails advertisementDetails)
        {
            return "Saved";
        }
    }
}
