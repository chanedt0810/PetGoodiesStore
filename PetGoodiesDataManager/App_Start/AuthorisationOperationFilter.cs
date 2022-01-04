﻿using Swashbuckle.Swagger;
using System.Collections.Generic;
using System.Web.Http.Description;

namespace PetGoodiesDataManager.App_Start
{
    public class AuthorisationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorisation",
                @in = "header",
                description = "access token",
                required = false,
                type = "string",
                @default = "bearer "
            });
        }
    }
}