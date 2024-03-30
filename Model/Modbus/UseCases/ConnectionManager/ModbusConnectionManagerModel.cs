namespace Model.Modbus.UseCases.ConnectionManager
{
    using EasyModbus;
    using EasyModbus.Exceptions;
    using Model.Modbus.Interfaces;
    using shared.Messages.Modbus;

    public class ModbusConnectionManagerModel : IModbusConnectionManagerModel
    {
        private bool isConnected = false;
        private ModbusClient _modbusClient;

        public ModbusConnectionManagerModel() { }

        public string StartConnection(string ipAddress, int port, int healthCheckPort)
        {
            if (isConnected)
            {
                return ModbusErrorMessages.ModbusAlreadyConnected;
            }
            else
            {
                try
                {
                    _modbusClient = new ModbusClient(ipAddress, port);
                    _modbusClient.Connect();
                    this.isConnected = true;

                    Task.Run(() => CheckConnection(healthCheckPort));

                    return ModbusSuccessMessages.ModbusConnectionSucessfully;
                }
                catch (Exception ex)
                {
                    isConnected = false;
                    throw new TimeoutException(ModbusErrorMessages.ModbusConnectionTimeOut + ex.Message);
                }
            }
        }

        public string StopConnection()
        {
            if (!isConnected)
            {
                return ModbusErrorMessages.ModbusNotConnected;
            }
            else
            {
                try
                {
                    isConnected = false;
                    _modbusClient?.Disconnect();
                    return ModbusSuccessMessages.ModbusConnectionClosedSucessfully;
                }
                catch (Exception ex)
                {
                    throw new OperationCanceledException(ex.Message);
                }
            }
        }

        private async Task CheckConnection(int healthCheckPort)
        {
            try
            {
                if (!isConnected)
                {
                    throw new ConnectionException(ModbusErrorMessages.ModbusNotConnected);
                }

                while (isConnected)
                {
                    _modbusClient.ReadHoldingRegisters(healthCheckPort, 1);

                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new ConnectionException(ModbusErrorMessages.ModbusConnectionTimeOut + ex.Message);
            }
        }

        public bool ConnectionIsActive()
        {
            return isConnected;
        }

        public async Task<string> WriteSingleCoilAsync(int coilAddress, bool value)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                _modbusClient.WriteSingleCoil(coilAddress, value);
                await Task.CompletedTask;
                return ModbusSuccessMessages.WritedSucessfully;
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<string> WriteMultipleCoilsAsync(int startingAddress, bool[] values)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                _modbusClient.WriteMultipleCoils(startingAddress, values);
                await Task.CompletedTask;
                return ModbusSuccessMessages.WritedSucessfully;
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<string> WriteSingleRegisterAsync(int registerAddress, int value)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                _modbusClient.WriteSingleRegister(registerAddress, value);
                await Task.CompletedTask;
                return ModbusSuccessMessages.WritedSucessfully;
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<string> WriteMultipleRegistersAsync(int startingAddress, int[] values)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                _modbusClient.WriteMultipleRegisters(startingAddress, values);
                await Task.CompletedTask;
                return ModbusSuccessMessages.WritedSucessfully;
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<bool[]> ReadCoilsAsync(int startingAddress, int quantity)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                return await Task.FromResult(_modbusClient.ReadCoils(startingAddress, quantity));
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<int[]> ReadHoldingRegistersAsync(int startingAddress, int quantity)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                return await Task.FromResult(_modbusClient.ReadHoldingRegisters(startingAddress, quantity));
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<bool[]> ReadDiscreteInputsAsync(int startingAddress, int quantity)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                return await Task.FromResult(_modbusClient.ReadDiscreteInputs(startingAddress, quantity));
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }

        public async Task<int[]> ReadInputRegistersAsync(int startingAddress, int quantity)
        {
            if (!isConnected)
            {
                throw new InvalidOperationException(ModbusErrorMessages.ModbusNotConnected);
            }

            try
            {
                return await Task.FromResult(_modbusClient.ReadInputRegisters(startingAddress, quantity));
            }
            catch (Exception ex)
            {
                isConnected = false;
                throw new OperationCanceledException(ex.Message);
            }
        }
    }
}

