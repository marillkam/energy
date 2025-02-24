using System;
using System.Collections.Generic;
using System.Windows.Forms;
public class EnergyMeter
{
    public string DeviceName { get; set; }
    public decimal PowerConsumption { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public EnergyMeter(string deviceName, decimal powerConsumption)
    {
        DeviceName = deviceName;
        PowerConsumption = powerConsumption;
        StartTime = DateTime.Now;
        EndTime = StartTime;
    }
    public void StopMeter()
    {
        EndTime = DateTime.Now;
    }
    public decimal CalculateEnergy()
    {
        if (EndTime == StartTime)
        {
            return 0;
        }
        var duration = EndTime - StartTime;
        var hours = duration.Hours + (duration.Minutes / 60m);
        return PowerConsumption * hours;
    }
}