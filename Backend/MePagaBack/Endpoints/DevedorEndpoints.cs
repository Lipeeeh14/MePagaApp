namespace MePagaBack.API.Endpoints;

internal static class DevedorEndpoints
{
    internal static void MapDevedorEndpoints(this IEndpointRouteBuilder app) 
    {
        var group = app.MapGroup("devedor");

        group.MapGet("/", () =>
        {
            return Results.Ok();
        });
    }
}
