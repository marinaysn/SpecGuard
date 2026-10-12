using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace SpecGuard.Api.Tests;

public class HealthEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> factory;

    public HealthEndpointTests(WebApplicationFactory<Program> factory)
    {
        this.factory = factory;
    }

    [Fact]
    public async Task GetHealth_ReturnsOk()
    {
        var response = await factory.CreateClient().GetAsync("/health");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
