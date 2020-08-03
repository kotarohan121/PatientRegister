import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
 import { ToastrModule } from 'ngx-toastr';
import { AppComponent } from './app.component';
import { PatientsComponent } from './patients/patients.component';
import { PatientComponent } from './patients/patient/patient.component';
import { PatientListComponent } from './patients/patientlist/patientlist.component';
import { PatientService } from './shared/patient.service';
import { RouterModule, Routes } from '@angular/router';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { AlphabetOnlyDirective } from './directives/alphabet-only.directive';



const appRoutes: Routes =[
  { path : 'patient' , component: PatientComponent },
 
];

@NgModule({
  declarations: [
    AppComponent,
    PatientsComponent,
    PatientComponent,
    PatientListComponent,
    AlphabetOnlyDirective
  ],
  imports: [
    BsDatepickerModule.forRoot(),
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    RouterModule
  ],
  providers: [PatientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
