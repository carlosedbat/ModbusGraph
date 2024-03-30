namespace Modbus_Graph
{
    using Microsoft.Extensions.DependencyInjection;
    using Modbus_Graph.Services;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            // Assegure-se de que esta linha esteja acessível após adicionar a referência correta
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Form1>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            ServiceConfiguration.ConfigureServices(services);
        }
    }
}