using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorHotelDB23inClass.Interfaces;
using RazorHotelDB23inClass.Models;


namespace RazorHotelDB23inClass.Pages.Hotels
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Hotel Hotel { get; set; }

        private IHotelService hservice;
        public CreateModel( IHotelService hotelService  )
        {
            hservice= hotelService;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            await hservice.CreateHotelAsync( Hotel );
            return RedirectToPage("GetAllHotels");
        }
    }
}
