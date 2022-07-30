using CapacityPlanApp.Models.DTO.Request.CityDTO;
using CapacityPlanApp.Models.DTO.Request.CountryDTO;
using CapacityPlanApp.Models.DTO.Request.GeographyDTO;

namespace CapacityPlanApp.Models.DTO.Request.LocationDetailsDTO
{
    public class LocationDetailsUpdate
    {
        public virtual GeographyCreate Geography { get; set; }
        public virtual CountryCreate Country { get; set; }
        public virtual CityCreate City { get; set; }
    }
}
