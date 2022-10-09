
using EntityFramework.Models;
using System.Collections.Generic;

namespace EntityFramework.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail SliderDetails { get; set; }
        public About Abouts { get; set; }
        public ExpertText ExpertText { get; set; }
        public List<ExpertCard> ExpertCards { get; set; }
        public BlogText BlogText { get; set; }
        public List<BlogCard> BlogCards { get; set; }
        public List<Say> Says { get; set; }
        public List<InstaSlider> InstaSliders { get; set; }

    }
}
