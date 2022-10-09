using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetail { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<ExpertText> ExpertText  { get; set; }
        public DbSet<ExpertCard> ExpertCards  { get; set; }
        public DbSet<BlogText> BlogText { get; set; }
        public DbSet<BlogCard> BlogCards { get; set; }
        public DbSet<Say> Says  { get; set; }
        public DbSet<InstaSlider> InstaSliders { get; set; }

    }
}
