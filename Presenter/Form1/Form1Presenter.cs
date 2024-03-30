using Model.Modbus.Interfaces;
using Model.Simulador.Senoide.Interfaces;
using Presenter.Form1.Interfaces;

namespace Presenter.Form1
{

    public class Form1Presenter : IForm1Presenter
    {
        private readonly IModbusConnectionManagerModel _connectionManagerModel;
        private readonly ISenoideSimuladorModel _senoideSimuladorModel;

        public Form1Presenter(
            IModbusConnectionManagerModel modbusConnectionManagerModel,
            ISenoideSimuladorModel senoideSimuladorModel)
        {
            this._connectionManagerModel = modbusConnectionManagerModel;
            _senoideSimuladorModel = senoideSimuladorModel;
        }

        public async void ConnectModbus(string ip, int port)
        {
            try
            {
                this._connectionManagerModel.StartConnection(ip, port, 2025);
                return;
            } catch (Exception ex)
            {
                throw;
            }
            
        }

        public void DisconnectModbus()
        {
            try
            {
                this._connectionManagerModel.StopConnection();
                return;
            } catch (Exception ex)
            {
                throw;
            }
        }

        public void GerarSenoide(int portToSendModbus)
        {
            double amplitude = 1.0;
            double frequencia = 60;
            double fase = 1;
            double passo = 1;
            try
            {
                this._senoideSimuladorModel.GerarSenoideContinua(amplitude, frequencia, fase, passo, portToSendModbus);
            } catch (Exception ex)
            {
                throw;
            }
        }
    }
}
