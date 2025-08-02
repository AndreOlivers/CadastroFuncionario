namespace FuncionarioWeb.Middlwares;

public static class ConfigureMiddlawares
{
    public static IServiceCollection AddMiddlware(
        this IServiceCollection services, IConfiguration configuration)
    {
        //var configs = new ConfigureServices(configuration);

        var configDataBase = new ConfigureDataBase(configuration);

        configDataBase.AddConfigureDataBase(services);

        return services;
    }
}
