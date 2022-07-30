import { CityResponse } from "./city-response.model";
import { CountryResponse } from "./country-response.model";
import { GeographyResponse } from "./geography-response.model";

export class LocationDetailsResponse{
    geography: GeographyResponse;
    country: CountryResponse;
    city: CityResponse;
}