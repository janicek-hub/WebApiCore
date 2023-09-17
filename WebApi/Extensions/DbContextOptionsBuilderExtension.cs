using Microsoft.EntityFrameworkCore;

namespace WebApi.Extensions
{
    public static class DbContextOptionsBuilderExtension
    {
        public static void OnConfigure(this DbContextOptionsBuilder optionsBuilder, IConfiguration configuration, string connectionStringName)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (configuration == null) throw new Exception("configuration is null");
                if (string.IsNullOrEmpty(connectionStringName)) throw new Exception("connectionStringName is null");

                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

                configuration.GetConnectionString(connectionStringName);

                switch (configuration.GetValue<string>("DBType"))
                {
                    case "RAM":
                        var rand = new Random();
                        var randnum = rand.Next(1000000000, 2000000000);
                        //Constants.DBType.RAM
                        optionsBuilder.UseInMemoryDatabase($"{connectionStringName}-{randnum}");
                        break;
                    default:
                        var cs = configuration.GetConnectionString(connectionStringName);

                        if (string.IsNullOrEmpty(cs))
                        {
                            optionsBuilder.UseInMemoryDatabase(connectionStringName);
                        }
                        else
                        {
                            optionsBuilder.UseSqlServer(cs, x => x.MigrationsHistoryTable("__EFMigrationsHistory"));
                        }
                        break;
                }
#if DEBUG
                optionsBuilder.EnableSensitiveDataLogging(true);
#endif
            }
        }
    }
}