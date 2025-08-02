namespace FuncionarioWeb.Middlwares;

public static class ConfigureConfigIni
{
    public static WebApplicationBuilder AddConfigIni(
        this WebApplicationBuilder builder)
    {
        builder.Configuration
          .SetBasePath(AppContext.BaseDirectory)
          .AddIniFile("config.ini", optional: false, reloadOnChange: true);

        return builder;
    }
}
