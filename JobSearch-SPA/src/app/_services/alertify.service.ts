import { Injectable } from '@angular/core';

declare let alertify:any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

constructor() { }

confirm(message:string,okCallBak:()=>any)  // Yes no
{
  alertify.confirm(message,function(e){
    if(e)
    {
      okCallBak();
    }
    else{}
  });
}

success(content:string)
{
  alertify.success(content);
}

error(content:string)
{
  alertify.error(content);
}

warning(content:string)
{
  alertify.warning(content);
}

message(content:string)
{
  alertify.message(content);
}





}
