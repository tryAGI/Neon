namespace Neon.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static NeonClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NEON_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("NEON_API_KEY environment variable is not found.");

        var client = new NeonClient(apiKey);
        
        return client;
    }
}
