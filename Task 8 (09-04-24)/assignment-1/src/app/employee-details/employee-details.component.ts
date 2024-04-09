import { Component, OnInit } from '@angular/core';
import { EmpService } from '../services/emp.service';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrl: './employee-details.component.css'
})
export class EmployeeDetailsComponent implements OnInit{
  empId: number | undefined;
  selectedEmp: any | undefined;

  constructor(private empservice:EmpService, private activeroute: ActivatedRoute){}
  ngOnInit(): void {
    this.empId = this.activeroute.snapshot.params['id'];
    this.selectedEmp = this.empservice.empData.find(emp => emp.empid == this.empId);    
  }
}
