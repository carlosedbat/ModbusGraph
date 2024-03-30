using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Simulador.Senoide.Interfaces
{
    public interface ISenoideSimuladorModel
    {
        void GerarSenoideContinua(double amplitude, double frequencia, double fase, double passo, int portModbus);
    }
}
