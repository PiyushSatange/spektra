import { Component, OnInit } from '@angular/core';
import { MedicineService } from '../services/medicine.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-medicine-products',
  templateUrl: './medicine-products.component.html',
  styleUrl: './medicine-products.component.css'
})
export class MedicineProductsComponent implements OnInit{

  medArr: any;
  constructor(private service: MedicineService){} 
  ngOnInit(): void {
    this.service.getAllProducts().subscribe((data:any) =>{
      this.medArr = data;
      console.log(this.medArr);
    })
  }
}
