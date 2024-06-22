import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { MedicineService } from '../services/medicine.service';
import { timeStamp } from 'console';

@Component({
  selector: 'app-payment-page',
  templateUrl: './payment-page.component.html',
  styleUrls: ['./payment-page.component.css']
})
export class PaymentPageComponent {
  constructor(private router: Router, private service: MedicineService, private activeroute:ActivatedRoute) {}
  User : any;
  id: any;
  onSubmit(form: NgForm) {
    this.id = this.activeroute.snapshot.params['id'];
    if (form.valid) {
      const { name, mail, number, city , Quantity} = form.value;
      this.service.addUser({ name, email: mail, phoneNo: number, location: city }).subscribe((data:any) => {
        this.User = data;
        console.log(this.User);
        this.service.addOrder({productId:this.id, customerId:this.User.id}).subscribe((data:any) => {
          console.log(data);
        });
        this.service.reduceQuantity(this.id, Quantity).subscribe((data:any)=>{
          console.log(data);
        })
        this.service.getProductById(this.id).subscribe((data:any)=>{
          if(data.quantity < Quantity){
            alert("Please reduce your quantity");
          }
          else{
            this.router.navigate(['/success']);
          }
        })
      });
    }
    
  }


}
