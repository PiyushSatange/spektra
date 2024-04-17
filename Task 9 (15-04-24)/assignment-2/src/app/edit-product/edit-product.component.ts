import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ProductService } from '../product.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrl: './edit-product.component.css'
})
export class EditProductComponent {



  constructor(private productSer:ProductService, private route:ActivatedRoute){}

  editProduct = new FormGroup({
    name: new FormControl(null),
    price: new FormControl(null),
    quantity: new FormControl(null)
  });

  ngOnInit(): void {
    this.productSer.getProductById(this.route.snapshot.paramMap.get("id")).subscribe((product)=>{
      this.editProduct = new FormGroup({
        name: new FormControl(product['name'], Validators.required),
        price: new FormControl(product['price']),
        quantity: new FormControl(product['quantity'])
      });
    })
  }


  onUpdate(){
    this.productSer.updateProduct(this.route.snapshot.paramMap.get("id"), this.editProduct.value).subscribe((product)=>{
    })
    alert("Product Updated");
  }
}
