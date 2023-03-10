using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using RazorHotelDB23inClass.Interfaces;
using RazorHotelDB23inClass.Models;
using System.Runtime.CompilerServices;

namespace RazorHotelDB23inClass.Pages.Hotels
{
    public class GetAllHotelsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public List<Hotel> Hotels { get; set; }

        private IHotelService hService;
        public GetAllHotelsModel(IHotelService hotelService)
        {
            hService = hotelService;
        }

        public async Task OnGetAsync()
        {
            if (!FilterCriteria.IsNullOrEmpty())
            {
                Hotels = await hService.GetHotelsByNameAsync(FilterCriteria);
            }
            else
            {
                Hotels = await hService.GetAllHotelAsync();
            }
            
        }
    }
}
