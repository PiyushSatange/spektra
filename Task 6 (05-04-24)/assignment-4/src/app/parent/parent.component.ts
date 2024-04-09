import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrl: './parent.component.css'
})
export class ParentComponent {  
  studentData:Array<any> = [
    {
      sId:1,
      sName:"Piyush",
      sGender:"male",
      sDOB:"01-12-2001",
      cFees:1000
    },
    {
      sId:2,
      sName:"Om",
      sGender:"male",
      sDOB:"01-12-2001",
      cFees:8000
    },
    {
      sId:3,
      sName:"Rakesh",
      sGender:"male",
      sDOB:"01-12-2001",
      cFees:5000
    },
    {
      sId:4,
      sName:"Vinay",
      sGender:"male",
      sDOB:"01-12-2001",
      cFees:4000
    },
    {
      sId:5,
      sName:"Sachin",
      sGender:"male",
      sDOB:"01-12-2001",
      cFees:9000
    },
    {
      sId:6,
      sName:"Rohit",
      sGender:"female",
      sDOB:"01-12-2001",
      cFees:5000
    },
    {
      sId:7,
      sName:"Atharv",
      sGender:"male",
      sDOB:"01-12-2001",
      cFees:1000
    },
    {
      sId:8,
      sName:"Ayush",
      sGender:"female",
      sDOB:"01-12-2001",
      cFees:50000
    },
    {
      sId:9,
      sName:"Vinod",
      sGender:"female",
      sDOB:"01-12-2001",
      cFees:2000
    }
  ]
  totalMale:number = 0;
  totalFemale:number = 0;
  constructor(){
    for (let student of this.studentData) {
      if(student.sGender=="male")
        this.totalMale++;
    }

    for (let student of this.studentData) {
      if(student.sGender=="female")
        this.totalFemale++;
    }
  }
}
