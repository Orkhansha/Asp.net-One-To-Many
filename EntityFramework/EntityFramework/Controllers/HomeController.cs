using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDetail sliderDetail = _context.SliderDetail.FirstOrDefault();
            About about = _context.About.FirstOrDefault();
            ExpertText expertText = _context.ExpertText.FirstOrDefault();
            List<ExpertCard> expertCards = _context.ExpertCards.ToList();
            BlogText blogText = _context.BlogText.FirstOrDefault();
            List<BlogCard> blogCards = _context.BlogCards.ToList();
            List<Say> says = _context.Says.ToList();
            List<InstaSlider> instaSliders = _context.InstaSliders.ToList();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetails = sliderDetail,
                Abouts = about,
                ExpertText = expertText,
                ExpertCards = expertCards,
                BlogText = blogText,
                BlogCards = blogCards,
                Says = says,
                InstaSliders = instaSliders
            };
            return View(model);
        }

       

       
    }
}
