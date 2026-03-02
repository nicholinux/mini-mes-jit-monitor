using System; // needed to interface with files
using System.Collections.Generic;
using System.IO;

public class LogEvent
{
    public DateTime TimeStamp { get; set; }
    public string LineId{ get; set; } = "";
    public string StationID { get; set; } = "";
    public string UnitID { get; set; } = "";
    public string EventType { get; set; } = "";
    public string ReasonCode { get; set; } = ""; 
}
