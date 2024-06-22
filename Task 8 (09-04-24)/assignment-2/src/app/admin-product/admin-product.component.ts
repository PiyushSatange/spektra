import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MedicineService } from '../services/medicine.service';

@Component({
  selector: 'app-admin-product',
  templateUrl: './admin-product.component.html',
  styleUrl: './admin-product.component.css'
})
export class AdminProductComponent implements OnInit{
  id: number | undefined;
  item: any;
  star: any;
  Customer: any;
  constructor(private service:MedicineService, private activeroute:ActivatedRoute){}
    
  ngOnInit(): void {
    this.id = this.activeroute.snapshot.params['id'];

    this.service.getProductById(this.id).subscribe((data:any)=>{
        this.item = data
        for(let i=1; i<=data.rating; i++){
        this.star += "⭐";
      }
    });

    this.service.getCustomerByProduct(this.id).subscribe((data:any) => {
      this.Customer = data;
    })
  }
}