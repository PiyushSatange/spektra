import { Component } from '@angular/core';
import { MedicineService } from '../services/medicine.service';

@Component({
  selector: 'app-medicine-products',
  templateUrl: './medicine-products.component.html',
  styleUrl: './medicine-products.component.css'
})
export class MedicineProductsComponent {
    medArr: Array<any> | undefined;

    mid: number | undefined;
    mtitle: string | undefined;
    mdetails: string | undefined;
    msrc: string | undefined;
    mrating: number | undefined;
    price: number | undefined;
  
    product: any | undefined;
    constructor(private medicineservice: MedicineService){
      this.medArr = medicineservice.medicine; 
      this.mid = medicineservice.medicine.length+1;   
  }

  onClick(){
    this.product = {
      mid: this.mid,
      mtitle: this.mtitle,
      mdetails: this.mdetails,
      msrc: this.msrc,
      mrating: this.mrating,
      price: this.price
    }
    this.medicineservice.medicine.push(this.product);
  }
}
