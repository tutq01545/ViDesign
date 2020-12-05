using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.ViDesign.Pages
{
    public class Index_Tests : ViDesignWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
