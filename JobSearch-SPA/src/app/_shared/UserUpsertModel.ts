export class UserUpsertModel {

    constructor(

        public FirstName : string,
        public LastName : string,
        public Email : string,
        public Phone : string,
        public Adress : string,
        public Password : string,

        public DateTime? : Date,
        public  CityId? : number,
        public  GenderId? : number,
        public  UserTypeId? : number,
    ){}

}
