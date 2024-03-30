namespace Modbus_Graph.Services
{
    using Microsoft.Extensions.DependencyInjection;
    using Model.Modbus.Interfaces;
    using Model.Modbus.UseCases.ConnectionManager;
    using Model.Simulador.Senoide;
    using Model.Simulador.Senoide.Interfaces;
    using Presenter.Form1;
    using Presenter.Form1.Interfaces;

    public class ServiceConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            ConfigureForms(services);
            ConfigurePresenters(services);
            ConfigureModels(services);
            // Continue adicionando outros serviços necessários, se houver
        }

        private static void ConfigureForms(IServiceCollection services)
        {
            // Adicione suas Forms ao container de DI
            services.AddTransient<Form1>();
            services.AddTransient<IForm1View, Form1>();
            // Adicione outras Forms conforme necessário
        }

        private static void ConfigurePresenters(IServiceCollection services)
        {
            // Adicione seus Presenters ao container de DI
            // Exemplo:
            services.AddTransient<IForm1Presenter, Form1Presenter>();
            // Adicione outros Presenters conforme necessário
        }

        private static void ConfigureModels(IServiceCollection services)
        {
            services.AddSingleton<IModbusConnectionManagerModel, ModbusConnectionManagerModel>();
            services.AddTransient<ISenoideSimuladorModel, SenoideSimulatorModel>();
        }
    }
}
