import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-list-products',
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.css'
})
export class ListProductsComponent implements OnInit{
  constructor(private productSer:ProductService){}
  productData: any = [];
  ngOnInit(): void {
    this.productSer.getAllProducts().subscribe((allData)=>{
      this.productData = allData;
    })
  }

  onDelete(id:any){
    let ask = prompt("Do you really want to delete");
    if(ask === "Yes"){
      console.log(id);
      this.productSer.deleteProduct(id).subscribe((product)=>{
        console.log(product);
        this.ngOnInit();
      })
    }
  }
}
