﻿using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace TaskTimeTracker.Helpers
{
    public class BasicAuthFilter : IOperationFilter
    {
        private const string BASIC_AUTH = "Basic aGFuc0BoYW5zLmhhbnM6cGFzc3dvcmQ=";

        public void Apply(Operation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
            {
                operation.Parameters = new List<IParameter>();
            }
            operation.Parameters.Add(new NonBodyParameter
            {
                Name = "Authorization",
                In = "header",
                Type = "string",
                Default = BASIC_AUTH
            });
        }
    }
}
