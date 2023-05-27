using Microsoft.Extensions.Hosting;

namespace votingApp;

var host = new HostBuilder()
  .ConfigureFunctionsWorkerDefaults(builder =>
  {
    builder
      .AddApplicationInsights()
      .AddApplicationInsightsLogger();
  })
  .Build();

await host.RunAsync();
