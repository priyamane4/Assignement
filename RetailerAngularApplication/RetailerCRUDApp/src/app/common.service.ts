import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { RetailerModel } from './retailer-model';

@Injectable({
  providedIn: 'root'
})
export class CommonService {
  readonly baseURL= 'https://localhost:44340/api/Retailer/AddRetailer';
  formData: RetailerModel=new RetailerModel();

  constructor(private _http:HttpClient) { }

  create(){
          
           //let jsondata =retailerForm.Json.stringiFy();
          return this._http.post(this.baseURL,this.formData);
  }
  // getAll():Observable<any>{
  // // return this._http.get("https://localhost:44340/api/Retailer/GetAllRetailer") 
  // }
  update(){

  }
  delete(){

  }
}
