using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorHotelDB23inClass.Interfaces;

namespace RazorHotelDB23inClass.Pages.Hotels
{
    public class DeleteHotelModel : PageModel
    {
        //lav en public property hotel som kan vise hotellet

        private IHotelService hservice;
        public DeleteHotelModel(IHotelService hotelService)
        {
            hservice= hotelService;
        }
        public void OnGet(int hotelnr)
        {
            //Hente hotellet

        }


    }
}
