using System;
using System.Collections.Generic;
using System.Linq;
namespace AutonomousRobot.AI
{
public class SensorReading
{
public int SensorId { get; set; }
public string Type { get; set; }
public double Value { get; set; }
public DateTime Timestamp { get; set; }
public double Confidence { get; set; }
}
public enum RobotAction
{
Stop,
SlowDown,
Reroute,
Continue
}
public static class DecisionEngine
{
public static List<SensorReading> GetRecentReadings(
List<SensorReading> sensorHistory,
DateTime fromTime)
{
return sensorHistory
.Where(r => r.Timestamp >= fromTime)
.ToList();
}
public static bool IsBatteryCritical(List<SensorReading> readings)
{
return readings
.Any(r => r.Type == "Battery" && r.Value < 20);
}
public static double GetNearestObstacleDistance(List<SensorReading> readings)
{
return readings
.Where(r => r.Type == "Distance")
.Select(r => r.Value)
.DefaultIfEmpty(double.MaxValue)
.Min();
}
public static bool IsTemperatureSafe(List<SensorReading> readings)
{
return readings
.Where(r => r.Type == "Temperature")
.All(r => r.Value < 90);
}
public static double GetAverageVibration(List<SensorReading> readings)
{
return readings
.Where(r => r.Type == "Vibration")
.Select(r => r.Value)
.DefaultIfEmpty(0)
.Average();
}
public static Dictionary<string, double> CalculateSensorHealth(
List<SensorReading> sensorHistory)
{
return sensorHistory
.GroupBy(r => r.Type)
.ToDictionary(
g => g.Key,
g => g.Average(r => r.Confidence)
);
}
public static List<string> DetectFaultySensors(
List<SensorReading> sensorHistory)
{
return sensorHistory
.GroupBy(r => r.Type)
.Where(g => g.Count(r => r.Confidence < 0.4) > 2)
.Select(g => g.Key)
.ToList();
}
public static bool IsBatteryDrainingFast(
List<SensorReading> sensorHistory)
{
var batteryValues = sensorHistory
.Where(r => r.Type == "Battery")
.OrderBy(r => r.Timestamp)
.Select(r => r.Value)
.ToList();
if (batteryValues.Count < 2)
return false;
return batteryValues
.Zip(batteryValues.Skip(1), (prev, next) => next < prev)
.All(x => x);
}
public static double GetWeightedDistance(List<SensorReading> readings)
{
var distanceReadings = readings
.Where(r => r.Type == "Distance");
double weightedSum = distanceReadings
.Sum(r => r.Value * r.Confidence);
double totalConfidence = distanceReadings
.Sum(r => r.Confidence);
if (totalConfidence == 0)
return double.MaxValue;
return weightedSum / totalConfidence;
}
public static RobotAction DecideRobotAction(
List<SensorReading> recentReadings,
List<SensorReading> sensorHistory)
{
if (IsBatteryCritical(recentReadings))
return RobotAction.Stop;
if (IsBatteryDrainingFast(sensorHistory))
return RobotAction.Stop;
double nearestObstacle = GetNearestObstacleDistance(recentReadings);
if (nearestObstacle < 1.0)
return RobotAction.Reroute;
if (!IsTemperatureSafe(recentReadings))
return RobotAction.SlowDown;
double vibration = GetAverageVibration(recentReadings);
if (vibration > 7.0)
return RobotAction.SlowDown;
return RobotAction.Continue;
}
}
class Main6
{
public static void main6()
{
List<SensorReading> sensorHistory = new List<SensorReading>
{
new SensorReading { SensorId = 1, Type = "Distance"
, Value = 0.8, Confidence = 0.9,
Timestamp = DateTime.Now },
new SensorReading { SensorId = 2, Type = "Battery"
, Value = 18, Confidence = 0.8,
Timestamp = DateTime.Now },
new SensorReading { SensorId = 3, Type = "Temperature"
, Value = 92, Confidence =
0.7, Timestamp = DateTime.Now },
new SensorReading { SensorId = 4, Type = "Vibration"
, Value = 8.2, Confidence = 0.6,
Timestamp = DateTime.Now }
};
DateTime fromTime = DateTime.Now.AddSeconds(-10);
// Mandatory execution order
var recentReadings = DecisionEngine.GetRecentReadings(sensorHistory, fromTime);
bool batteryCritical = DecisionEngine.IsBatteryCritical(recentReadings);
double nearestObstacle =
DecisionEngine.GetNearestObstacleDistance(recentReadings);
bool temperatureSafe = DecisionEngine.IsTemperatureSafe(recentReadings);
double avgVibration = DecisionEngine.GetAverageVibration(recentReadings);
var health = DecisionEngine.CalculateSensorHealth(sensorHistory);
var faulty = DecisionEngine.DetectFaultySensors(sensorHistory);
bool drainingFast = DecisionEngine.IsBatteryDrainingFast(sensorHistory);
double weightedDistance = DecisionEngine.GetWeightedDistance(recentReadings);
RobotAction action = DecisionEngine.DecideRobotAction(recentReadings,
sensorHistory);
Console.WriteLine($"Robot Action: {action}");
}
}
}