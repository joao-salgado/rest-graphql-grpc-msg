using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EDMIL.Communication.Infra.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CommunicationDBContext>
    {
        public CommunicationDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CommunicationDBContext>();
            optionsBuilder.UseNpgsql("CommunicationDb");

            return new CommunicationDBContext(optionsBuilder.Options);
        }
    }
}
