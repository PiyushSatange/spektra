import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DatapageComponent } from './../datapage/datapage.component';

@Component({
  selector: 'app-myform',
  templateUrl: './myform.component.html',
  styleUrl: './myform.component.css'
})
export class MyformComponent {
    firstName : string | undefined;
    lastName : string | undefined;
    email : string | undefined;
    password : string | undefined;

  constructor(private router: Router){}
  onSubmit(){
    this.router.navigate(['/data'],{
      queryParams:{
        firstName:this.firstName,
        lastName:this.lastName,
        email:this.email,
        password:this.password
      }
    });
  }
}