namespace Presenter.Form1.Interfaces
{
    public interface IForm1Presenter
    {
        void ConnectModbus(string ip, int port);

        void DisconnectModbus();

        void GerarSenoide(int portToSendModbus);
    }
}
