import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{HttpClientModule} from "@angular/common/http";
import { RetailerDetailsComponent } from './retailer-details/retailer-details.component';
import { RetailerFormComponent } from './retailer-details/retailer-form/retailer-form.component';

@NgModule({
  declarations: [
    AppComponent,
    RetailerDetailsComponent,
    RetailerFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
