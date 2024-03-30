namespace shared.Messages.Modbus
{
    public class ModbusErrorMessages
    {
        public static string ModbusAlreadyConnected = "Ja existe uma conexao modbus em uso. Por favor, feche a conexao antes de abrir uma nova!";
        public static string ModbusConnectionTimeOut = "Falha na conexão Modbus: Timeout alcançado. Não foi possível estabelecer uma conexão com o dispositivo dentro do tempo limite especificado. Verifique se o dispositivo está online e acessível, e se as configurações de rede estão corretas.";
        public static string ModbusNotConnected = "A conexao modbus ainda nao foi estabelecida. Conecte-se ao dispositivo antes de prosseguir.";

    }
}
