import { Patient } from './patient.model';
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { State } from '../models/state.model';
import { City } from '../models/city.model';
import { environment } from 'src/environments/environment';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PatientService {
  formData: Patient;

  list: Patient[];
  statelist: State[];
  citylist: City[];

  constructor(private http: HttpClient) { }

  postPatient() {
    return this.http.post(environment.apiURL + '/patients', this.formData);
  }


  getStates() {
    try {
    return this.http.get(environment.apiURL + '/states').toPromise()
    .then(res => this.statelist = res as State[]);;
    } catch (e) {
      console.log('Got an error!', e);
      throw e; // rethrow to not marked as handled
  }
   }

   getCities() {
    try {
    return this.http.get(environment.apiURL + '/cities').toPromise()
    .then(res => this.citylist = res as City[]);
  } catch (e) {
    console.log('Got an error!', e);
    throw e; // rethrow to not marked as handled
}

   }



  refreshList() {
    try {
    this.http.get(environment.apiURL + '/patients')
    .toPromise()
    .then(res => this.list = res as Patient[]);
  } catch (e) {
    console.log('Got an error!', e);
    throw e; // rethrow to not marked as handled
}
   
  }

  
}
