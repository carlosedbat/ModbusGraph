namespace Model.Modbus.Interfaces
{
    public interface IModbusConnectionManagerModel
    {
        public string StartConnection(string ipAddress, int port, int healthCheckPort);

        public string StopConnection();

        public bool ConnectionIsActive();

        Task<bool[]> ReadCoilsAsync(int startingAddress, int quantity);

        Task<bool[]> ReadDiscreteInputsAsync(int startingAddress, int quantity);

        Task<int[]> ReadHoldingRegistersAsync(int startingAddress, int quantity);

        Task<int[]> ReadInputRegistersAsync(int startingAddress, int quantity);

        Task<string> WriteSingleCoilAsync(int coilAddress, bool value);

        Task<string> WriteMultipleCoilsAsync(int startingAddress, bool[] values);

        Task<string> WriteSingleRegisterAsync(int registerAddress, int value);

        Task<string> WriteMultipleRegistersAsync(int startingAddress, int[] values);
    }
}
