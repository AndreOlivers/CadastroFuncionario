namespace FuncionarioWeb.Middlwares;

public class ConfigureDataBase
{

    private readonly IConfiguration _configuration;

    public ConfigureDataBase(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void AddConfigureDataBase(IServiceCollection services)
    {
        var address = _configuration["MSSQLSERVER:ADDRESS"];
        var database = _configuration["MSSQLSERVER:DATABASE"];
        var trustedConnection = _configuration["MSSQLSERVER:TRUSTED_CONNECTION"];
        var trustServerCertificate = _configuration["MSSQLSERVER:TRUST_SERVER_CERTIFICATE"];

        bool trusted = trustedConnection?.ToLower() == "true";
        bool trustCert = trustServerCertificate?.ToLower() == "true";

        string connectionString;

        if (trusted)
        {
            connectionString = $"Server={address};Database={database};Trusted_Connection=True;TrustServerCertificate={trustCert};";
        }
        else
        {
            // Se usar usuário e senha, leia também USER e PASS e monte aqui
            var user = _configuration["MSSQLSERVER:USER"];
            var pass = _configuration["MSSQLSERVER:PASS"];
            connectionString = $"Server={address};Database={database};User Id={user};Password={pass};TrustServerCertificate={trustCert};";
        }

        services.AddNHibernate(connectionString);
        services.AddControllersWithViews();
    }
}


//var connectionString = $"Server={address};Database={database};" +
//                       $"Trusted_Connection={trustedConnection};" +
//                       $"TrustServerCertificate={trustServerCertificate};" +
//                       $"User Id={user};Password={pass};";

//var user = _configuration["MSSQLSERVER:USER"];
//var pass = _configuration["MSSQLSERVER:PASS"];
