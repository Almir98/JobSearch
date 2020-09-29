import {Company} from './Company';
import {City} from './City';
import {JobLevel} from './JobLevel';
import {JobType} from './JobType';


export interface Advertisment 
{
    advertismentid: number;
    categoryName: string;
    published: Date;
    toDate: Date;
    isActive: boolean;
    requirements: string;
    bonusSkills: string;
    offers: string;
    education: string;
    jobDescription: string;

    company: Company;
    city: City;
    jobLevel: JobLevel;
    jobType: JobType;



}
