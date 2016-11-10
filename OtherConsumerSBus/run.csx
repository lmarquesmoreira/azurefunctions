using System;
using System.Threading.Tasks;

public static void Run(string mySbMsg, TraceWriter log)
{
    log.Info($"OtherConsumer processed message: {mySbMsg}");
}