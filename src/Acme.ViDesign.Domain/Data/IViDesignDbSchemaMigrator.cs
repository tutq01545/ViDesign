using System.Threading.Tasks;

namespace Acme.ViDesign.Data
{
    public interface IViDesignDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
