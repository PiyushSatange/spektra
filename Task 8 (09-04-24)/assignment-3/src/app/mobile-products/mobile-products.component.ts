import { Component } from '@angular/core';
import { MedicineService } from '../services/medicine.service';

@Component({
  selector: 'app-mobile-products',
  templateUrl: './mobile-products.component.html',
  styleUrl: './mobile-products.component.css'
})
export class MobileProductsComponent {
    medArr: Array<any> | undefined;
    constructor(private medicineservice: MedicineService){
      this.medArr = medicineservice.medicine;    
  }
}
