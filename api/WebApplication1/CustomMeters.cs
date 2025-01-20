using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.SignalR;
using Prometheus;

public class CustomDotNetMeters
{
    public int requestsToWeather{get; set;}

    public void PublishRequestsToWeather(){
        var requestsToWeatherMeter = new Meter("CAPI.Weather.Requests", "v1");

        var requestsToWeatherCounter = requestsToWeatherMeter.CreateCounter<int>("Weather Requests", "Requests", "Count on the number of requests specific to the /weatherforecast path.");

        requestsToWeatherCounter.Add(this.requestsToWeather);
    }
}