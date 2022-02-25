import { Component } from '@angular/core'
import { FormControl, FormGroup, NgForm } from '@angular/forms';
import { CommonService } from './common.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(public commonService:CommonService){
  
  }

 
  

  

  // AddRetailer(retailerForm:NgForm){
  //   console.log(retailerForm.value);
  //   let obj = retailerForm;
  //   this.commonService.create(retailerForm).subscribe(resp =>{
  //     console.log(resp);
  //   });
  // }

  // getAllRetailer(){

  // }
}
