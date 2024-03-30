using Model.Modbus.Interfaces;
using Model.Simulador.Senoide.Interfaces;

namespace Model.Simulador.Senoide
{
    public class SenoideSimulatorModel : ISenoideSimuladorModel
    {
        private IModbusConnectionManagerModel _modbusConnectionManagerModel;

        public SenoideSimulatorModel(IModbusConnectionManagerModel modbusConnectionManagerModel) 
        {
            this._modbusConnectionManagerModel = modbusConnectionManagerModel;
        }

        public void GerarSenoideContinua(double amplitude, double frequencia, double fase, double passo, int portModbus)
        {
            double t = 0.0; // Inicializa o tempo/ângulo
            bool stop = true;
            int i = 0;

            while (stop)
            {
                double valorSenoide = amplitude * Math.Sin(2 * Math.PI * frequencia * t + fase);
                valorSenoide *= 1000;
                Console.WriteLine(valorSenoide);

                this._modbusConnectionManagerModel.WriteSingleRegisterAsync(portModbus, (int)valorSenoide);
                t += passo; // Incrementa o tempo/ângulo
                Thread.Sleep(1000);
                i++;
                bool modbusIsActive = this._modbusConnectionManagerModel.ConnectionIsActive();
                if (i == 60)
                {
                    stop = false;
                }

            }
        }
    }
}
