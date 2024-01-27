using JAPP.Data;
using JAPP.Data.Repositories.Athlete;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JAPP.MinimalAPI.Test;

public static class TestEndpoints
{
    //public static IServiceCollection TestModule(this IServiceCollection services)
    //{
    //    services.AddScoped<IAthleteRepository, AthleteRepository>();
    //    return services;
    //}

    public static IEndpointRouteBuilder MapTestEndpoints(this IEndpointRouteBuilder endpoints)
    {

        endpoints.MapGet("/test",async ([FromServices] IAthleteRepository athleteRepository) => {
            return await athleteRepository.GetAthletes(null);      
        });

        endpoints.MapPost("/test/Athletes", () => {
            return "test2";
        });

        return endpoints;
    }

}

