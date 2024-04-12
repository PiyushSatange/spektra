import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
    selector: 'app-payment-page',
    templateUrl: './payment-page.component.html',
    styleUrl: './payment-page.component.css',
    standalone: true,
    imports: [NavbarComponent]
})
export class PaymentPageComponent {
  constructor(private router:Router){}

  onSubmit(){
    this.router.navigate(["/success"]);
  }
}
