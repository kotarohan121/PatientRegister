import { Patient } from '../../shared/patient.model';
import { PatientService } from '../../shared/patient.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-patientlist',
  templateUrl: './patientlist.component.html',
  styles: []
})
export class PatientListComponent implements OnInit {

  constructor(private service: PatientService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: Patient) {
    this.service.formData = Object.assign({}, pd);
  }

 

}
