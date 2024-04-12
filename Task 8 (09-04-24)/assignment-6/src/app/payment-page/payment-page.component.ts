import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-payment-page',
  templateUrl: './payment-page.component.html',
  styleUrl: './payment-page.component.css'
})
export class PaymentPageComponent {
  item;
  constructor(private route:Router){
    this.item = history.state.item;
    console.log(this.item);
  }

  onConform(){
    this.route.navigate(['/success']);
  }
}
