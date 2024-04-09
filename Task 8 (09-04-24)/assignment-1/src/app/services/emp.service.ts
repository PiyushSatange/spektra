import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmpService {

  constructor() { }

  empData: Array<any> = [
    {empid: 1, empname: "Piyush", empdesi: "Developer"},
    {empid: 2, empname: "Roshan", empdesi: "Tester"},
    {empid: 3, empname: "Pratik", empdesi: "Support"}
  ]
}
