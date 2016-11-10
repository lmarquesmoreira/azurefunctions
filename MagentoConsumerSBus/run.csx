using System;
using System.Threading.Tasks;

public static void Run(string mySbMsg, TraceWriter log)
{
    log.Info($"Magento Consumer processed message: {mySbMsg}");
}