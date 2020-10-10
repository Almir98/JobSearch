import {UserType} from '../_models/UserType';

export interface User {

    userId: number;
    firstName: string;
    lastName: string;
    phone: string;
    email: string;
    adress: string;
    yearOfBirth: Date;
    passwordHash: string;
    passwordSalt: string;

    cityId?: number;
    genderId?: number;

    userType : UserType;

}
