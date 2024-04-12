import { Component } from '@angular/core';
import { MedicineService } from '../services/medicine.service';
import { RouterLink } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
    selector: 'app-mobile-products',
    templateUrl: './mobile-products.component.html',
    styleUrl: './mobile-products.component.css',
    standalone: true,
    imports: [NavbarComponent, RouterLink]
})
export class MobileProductsComponent {
    medArr: Array<any> | undefined;
    constructor(private medicineservice: MedicineService){
      this.medArr = medicineservice.medicine;    
  }
}
