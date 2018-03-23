//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DonateNow
//{
//    public static class SwaggerServiceCollectionExtensions
//    {
//        public static IServiceCollection AddSwaggerPageConfiguration(this IServiceCollection services)
//        {
//            // Inject an implementation of ISwaggerProvider with defaulted settings applied
           
//            services.ConfigureSwaggerGen(options =>
//            {
//                options.SingleApiVersion(new Info
//                {
//                    Version = "v1",
//                    Title = "ATI Calibration Repository API",
//                    Description = "Describes the REST API used to interact with the ATI Calibration Repository",
//                    TermsOfService = "See license agreement.",
//                    Contact = new Contact { Name = "support@accuratetechnologies.com", Email = "support@accuratetechnologies.com", Url = "http://www.accuratetechnologies.com" },
//                    License = new License { Name = "Use under LICX", Url = "http://url.com" },

//                });
//                services.AddSwaggerGen()

//                //Determine base path for the application.
//                var basePath = PlatformServices.Default.Application.ApplicationBasePath;

//                //Set the comments path for the swagger json and ui.
//                options.IncludeXmlComments(basePath + "\\CalibrationRepository.xml");

//                // UseFullTypeNameInSchemaIds replacement for .NET Core
//                options.CustomSchemaIds(t => t.FullName);
//            });

//            return services;
//        }
//    }
//}
