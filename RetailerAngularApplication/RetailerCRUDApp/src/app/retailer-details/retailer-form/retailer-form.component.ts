import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CommonService } from 'src/app/common.service';

@Component({
  selector: 'app-retailer-form',
  templateUrl: './retailer-form.component.html',
  styleUrls: ['./retailer-form.component.css']
})
export class RetailerFormComponent implements OnInit {

  constructor(public service:CommonService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    debugger;
     this.service.create().subscribe(
            res=>{
              console.log("Record saved successfully");
            }
     );
  }

}
