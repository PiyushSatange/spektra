import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent implements OnInit {
  addProduct:FormGroup;

  constructor(private productSer:ProductService){}

  ngOnInit(): void {
    this.addProduct = new FormGroup(
      {
        name : new FormControl(null),
        price : new FormControl(null),
        quantity : new FormControl(null)
      }
    );
  }

  onSubmit(){
    this.productSer.addProduct(this.addProduct.value).subscribe((product)=>{
      console.log(product);
    })
    alert("Product Added successfully")
    this.ngOnInit();
  }
}
