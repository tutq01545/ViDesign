using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.ViDesign.EntityFrameworkCore
{
    public static class ViDesignDbContextModelCreatingExtensions
    {
        public static void ConfigureViDesign(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ViDesignConsts.DbTablePrefix + "YourEntities", ViDesignConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}