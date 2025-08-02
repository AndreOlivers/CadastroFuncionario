//namespace FuncionarioWeb.Middlwares;

//public class ConfigureServices
//{
//    private readonly IConfiguration _configuration;

//    public ConfigureServices(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }

//    public void AddConfigureService(IServiceCollection services)
//    {
//        //var config = _configuration.GetSection("MSSQLSERVER");

//        var conexaoSQLServer = _configuration.GetConnectionString(
//            "DefaultConnection");

//        services.AddNHibernate(conexaoSQLServer!);

//        services.AddControllersWithViews();
//    }
//}
