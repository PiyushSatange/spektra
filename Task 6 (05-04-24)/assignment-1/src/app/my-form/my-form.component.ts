import { Component } from '@angular/core';

@Component({
  selector: 'app-my-form',
  templateUrl: './my-form.component.html',
  styleUrl: './my-form.component.css'
})
export class MyFormComponent {
  userData:Array<any> = [
    {
      id:1,
      name:"Piyush",
      mail:"piyushsatange@gmail.com",
      city:"Amravati",
      no:9607772094
    },
    {
      id:2,
      name:"Yash",
      mail:"yashingale@gmail.com",
      city:"Bangalore",
      no:9876543218
    },
    {
      id:3,
      name:"Mayur",
      mail:"mayurw@gmail.com",
      city:"Pune",
      no:1234543216
    },
    {
      id:4,
      name:"Abhinav",
      mail:"abhinvc@gmail.com",
      city:"Delhi",
      no:9607772094
    },
    {
      id:5,
      name:"Atharv",
      mail:"piyushsatange@gmail.com",
      city:"Chennai",
      no:9182736450
    }
  ]
}
