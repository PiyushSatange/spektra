import { Component } from '@angular/core';
import { EmpService } from '../services/emp.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrl: './employees.component.css',
})
export class EmployeesComponent {
  empArr: Array<any>;

  constructor(private empservice: EmpService){
    this.empArr = empservice.empData;
  }
}
