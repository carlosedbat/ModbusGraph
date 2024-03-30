using Presenter.Form1.Interfaces;

namespace Modbus_Graph
{
    public partial class Form1 : Form, IForm1View
    {
        private IForm1Presenter _form1Presenter;

        public Form1(IForm1Presenter form1Presenter)
        {
            this._form1Presenter = form1Presenter;
            InitializeComponent();
        }

        public void ShowView()
        {
            this.Show();
        }

        public void UpdateConnectionStatus(string status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => labelStatusConnection.Text = status));
            }
            else
            {
                labelStatusConnection.Text = status;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = textBoxIP.Text;
                int port = int.Parse(textBoxPort.Text);

                this._form1Presenter.ConnectModbus(ip, port);

                this.UpdateConnectionStatus("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                this._form1Presenter.DisconnectModbus();
                this.UpdateConnectionStatus("Desconectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSimulateSin_Click(object sender, EventArgs e)
        {
            int portToSend;

            try
            {
                portToSend = int.Parse(textBoxSimulatorPort.Text);
            }
            catch
            {
                MessageBox.Show("Tipo incorreto de dado.");
                return;
            }
            
            try
            {
                this._form1Presenter.GerarSenoide(portToSend);
            } catch (Exception ex)
            {

            }
        }
    }
}