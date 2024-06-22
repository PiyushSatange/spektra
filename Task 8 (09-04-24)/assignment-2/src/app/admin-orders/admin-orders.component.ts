import { Component, OnInit } from '@angular/core';
import { MedicineService } from '../services/medicine.service';

@Component({
  selector: 'app-admin-orders',
  templateUrl: './admin-orders.component.html',
  styleUrl: './admin-orders.component.css'
})
export class AdminOrdersComponent implements OnInit{
  orders : any;
  constructor(private service: MedicineService){}
  ngOnInit(): void {
    this.service.getAllOrderDetails().subscribe((data:any) => {
      this.orders = data;
      console.log(this.orders);
    })
  }
}
