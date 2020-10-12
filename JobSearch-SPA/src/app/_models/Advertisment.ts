import {Company} from './Company';
import {City} from './City';
import {JobLevel} from './JobLevel';
import {JobType} from './JobType';


export interface Advertisment 
{
    advertismentId: number;
    categoryName: string;
    published: Date;
    toDate: Date;
    isActive: boolean;
    
    requirements: string;
    bonusSkills: string;
    offers: string;
    education: string;
    jobDescription: string;
    candidateDescription: string;

    companyId?: number;
    categoryId?: number;
    cityId?: number;
    jobLevelId?: number;
    jobTypeId?: number;

    company?: Company;
    city?: City;
    jobLevel?: JobLevel;
    jobType?: JobType;
}
