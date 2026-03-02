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

class Program
{
    static void Main()
    {
        string path = "sample_log.csv";
        string[] lines = File.ReadAllLines(path);

        List<LogEvent> events = new List<LogEvent>();

        for (int i = 1; i < lines.Length; i++)
        {
           string line = lines[i];
           string[] parts = line.Split(',');

           LogEvent e = new LogEvent
           {
               TimeStamp = DateTime.Parse(parts[0]),
               LineId = parts[1],
               StationID = parts[2],
               UnitID = parts[3],
               EventType = parts[4],
               ReasonCode = parts.Length > 5 ? parts[5] : ""
           };
            
           events.Add(e);
            
        }
    }
}
