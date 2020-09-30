export interface Application {

    applicationId: number;
    applicationDate : Date;
    description : string;
    cv: string;
    motivation: string;

    advertismentId?: number;
    userId?: number;
}
