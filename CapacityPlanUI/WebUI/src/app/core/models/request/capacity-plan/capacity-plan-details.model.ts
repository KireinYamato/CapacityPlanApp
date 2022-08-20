export class CapacityPlanDetails{
    capacityPlanRefId: number;
    name: string;
    project: Project
    workStream: WorkStream;
    language: Language;
    channel: Channel;
    billingModel: BillingModel;
    locationDetails: LocationDetails;
    peopleDetails: PeopleDetails;

    constructor(){
        this.peopleDetails = new PeopleDetails();   
        this.project = new Project();
        this.workStream = new WorkStream();
        this.language = new Language();
        this.channel = new Channel();
        this.billingModel = new BillingModel();
        this.locationDetails = new LocationDetails();        
    }

}

export class Project {
    name: string;
}

export class WorkStream {
    name: string;
}

export class Language {
    name: string;
}

export class Channel {
    name: string;
}

export class BillingModel {
    name: string;
}

export class LocationDetails {
    geography: Geography;
    country: Country;
    city: City;

    constructor(){
        this.geography = new Geography();
        this.country = new Country();
        this.city = new City();
    }
}

export class Geography{
    name: string;
}

export class Country{
    name: string;
}

export class City {
    name: string;
}


export class PeopleDetails {
    deliveryLead: DeliveryLead;
    wccLead: WCCLead;
    pocLead: POCLead;

    constructor(){
        this.deliveryLead = new DeliveryLead();
        this.wccLead = new WCCLead();
        this.pocLead = new POCLead();
    }
}

export class DeliveryLead {
    firstName: string;
    middleName: string;
    lastName: string;
}

export class WCCLead {
    firstName: string;
    middleName: string;
    lastName: string;
}

export class POCLead {
    firstName: string;
    middleName: string;
    lastName: string;
}