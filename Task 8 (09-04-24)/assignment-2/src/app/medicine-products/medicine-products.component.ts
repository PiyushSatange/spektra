import { Component } from '@angular/core';
import { MedicineService } from '../services/medicine.service';

@Component({
  selector: 'app-medicine-products',
  templateUrl: './medicine-products.component.html',
  styleUrl: './medicine-products.component.css'
})
export class MedicineProductsComponent {
    medArr: Array<any> | undefined;
    constructor(private medicineservice: MedicineService){
      this.medArr = medicineservice.medicine;    
  }
}
