import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent implements OnInit{
  constructor(private http: HttpClient,private router: Router, private service:ServiceService) {}

  Products: any=[];

  ngOnInit(): void {
    this.getData();
  }

  getData() {
    this.service.getData().subscribe((data:any) => {
      this.Products = data;     
      console.log(this.Products);
    });
  }

  buyNow(id: number, url:string, price: number, qnt: number){
    this.router.navigate(['buypage',id],{
      state: { id,  url, price, qnt}
    })
  }
}