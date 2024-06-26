﻿using System.Runtime.InteropServices;

namespace APIMetrics.Models;

public class MetricsDefinitions
{
    public string Horario => $"{DateTime.UtcNow.AddHours(-3):HH:mm:ss}";
    public int CurrentValue { get; set; } = 1;
    public string Local => Environment.MachineName;
    public string Kernel => Environment.OSVersion.VersionString;
    public string Framework => RuntimeInformation.FrameworkDescription;
}
