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

        group.MapGet("{id}", (long id) =>
        {
            return Results.Ok();
        });

        group.MapPost("/", () => 
        {
            return Results.Ok();
        });

        group.MapPut("/", () =>
        {
            return Results.Ok();
        });
    }
}
