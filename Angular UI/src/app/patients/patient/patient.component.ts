import {  PatientService } from '../../shared/patient.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Gender } from '../../models/gender.model';
import { State } from 'src/app/models/state.model';
import { City } from 'src/app/models/city.model';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styles: []
})
export class PatientComponent implements OnInit {
  selectedLevel;
  name: string;
  minDate: Date;
  maxDate: Date;

  genders: Gender[] = [
   
    { Id: 1, Name: 'M'},
    { Id: 2, Name: 'F'}
  ];


 // selectedState: State = new State(1, 'MH');
  states: State[];
  cities: City[];

  constructor(private service: PatientService,
    private toastr: ToastrService) {

      this.minDate = new Date(1920, 0, 1);
      this.maxDate = new Date(new Date().setDate(new Date().getDate() - 1));


     }

  ngOnInit() {
    this.resetForm();
    this.service.getStates().then(res => this.states = res as State[]);
   // this.service.getCities().then(res => this.cities = res as City[]);
  }

  onSelect(stateId) {
 this.service.getCities().then(res => {
  this.cities = res.filter(city => city.StateId.toString() === stateId);
});

  }




  resetForm(form?: NgForm) {
    if (form != null) {
      form.form.reset();
    }
    this.service.formData = {
      Id: 0,
      Name: '',
      SurName: '',
      DOB: '',
      Gender: '0',
      CityId: 0,
      StateId: 0
    }
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.Id === 0) {
      this.insertRecord(form);
    }

  }

  insertRecord(form: NgForm) {
    this.service.postPatient().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Patient Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }

}
