namespace Neon.IntegrationTests;

[TestClass]
public partial class Examples
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Neon tools with any MEAI-compatible AI provider
        using var client = new NeonClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
