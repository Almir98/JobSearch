import {Country} from '.././_models/Country';

export interface City {

    cityId :number;
    cityName: string;
    zipCode: string;

    countryId?: number;
}
