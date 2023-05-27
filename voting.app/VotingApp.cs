using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Newtonsoft.Json;

namespace votingApp;

public class VotingApp
{
  [Function("votingApp")]
  public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
    FunctionContext executionContext)
  {
    var json = JsonConvert.SerializeObject("fuck Bolsonaro");
    var response = req.CreateResponse(HttpStatusCode.OK);
    response.Headers.Add("Content-Type", "text/json; charset=utf-8");
    response.WriteString(json);
    return response;
  }
}
