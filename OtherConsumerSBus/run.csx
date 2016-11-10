using System;
using System.Threading.Tasks;

public static void Run(string msg, TraceWriter log)
{
    log.Info($"OtherConsumer processed message: {msg}");
}