using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace ODataApi
{
    public class Edm
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "AirVinyl";
            builder.ContainerName = "AirVinylContainer";

            builder.EntitySet<WeatherForecast>("WeatherForecasts");
            
            return builder.GetEdmModel();
        }
    }
}