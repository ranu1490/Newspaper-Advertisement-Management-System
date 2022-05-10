using System;
using System.Collections.Generic;
using System.Text;
using NewsAdMS.Entity;
namespace NewsAdMS.DAL.Repository
{
    internal interface IAdvertisement
    {
        string BookAd(AdvertisementDetails advertisementDetails);
        string UpdateAd(AdvertisementDetails advertisementDetails);
        string SaveAd(AdvertisementDetails advertisementDetails);
        string DeleteAd(string Adv_Type);
        AdvertisementDetails GetBook(string Adv_Type);
        List<AdvertisementDetails> GetAllAdvertisements();

    }
}
