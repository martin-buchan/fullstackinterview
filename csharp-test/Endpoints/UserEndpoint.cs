using FastEndpoints;

public class UserEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/api/users");
        AllowAnonymous();
    }

    /// <summary>
    /// Call the following API
    /// https://jsonplaceholder.typicode.com/users
    /// 
    /// create a C# POCO (model) to represent the response from the API 
    /// Filter the list of return objects to only return entries where ID is greater than 3
    /// return the filtered list to the client
    /// 
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public override async Task HandleAsync(CancellationToken ct)
    {
        // add your code here
    }
}
