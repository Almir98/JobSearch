import { Advertisment } from './Advertisment';
import { User } from './User';

export class Application {

    applicationId: number;
    applicationDate : Date;
    description : string;
    cv: string;
    motivation: string;

    user: User;
    advertisment: Advertisment;

    advertismentId?: number;
    userId?: number;
}
