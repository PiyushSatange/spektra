import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DatapageComponent } from './../datapage/datapage.component';

@Component({
  selector: 'app-myform',
  templateUrl: './myform.component.html',
  styleUrl: './myform.component.css'
})
export class MyformComponent {
  constructor(private router: Router){}
  onSubmit(first: string, last: string, email: string, pass: string){
    this.router.navigate(['/data'],{
      state: {
        first, last,email, pass
      }
    });
  }
}