using System;
namespace LoggerService.Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void warn(string message);
        void debug(string message);
        void error(string message);
    }
}
