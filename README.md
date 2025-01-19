# Monitoring/Observability PoC

A repository containing monitoring and observability PoC using Grafana + Prometheus.

This will be the simple architecture for this PoC:

```mermaid
flowchart TD
    user((User)) -- Consumes --> api{{C# API}}
    application((Application)) -- Consumes --> api
    api -- Usage Data --> prometheus[Prometheus]
    prometheus -- Stores Usage Data --> prometheus_volume[(Prometheus Volume)]
    prometheus -- Exposes --> prometheus_api{{Prometheus API}}
    grafana[Grafana] -- Consumes --> prometheus_api
    internal_customer((Internal Customer)) -- Visualizes Dashboards --> grafana
```

## Running Instructions

To run this project, all you need to do is to run docker compose command

```
docker compose up -d
```

Since this is only a PoC, the API is running on HTTP and you would be able to access its swagger via http://localhost:8080/swagger/index.html

The metrics for the API can be found at http://localhost:1234/metrics
