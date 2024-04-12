import { Component } from '@angular/core';
import { ProductsService } from '../service/products.service';

@Component({
  selector: 'app-grocery',
  templateUrl: './grocery.component.html',
  styleUrl: './grocery.component.css'
})
export class GroceryComponent {
  componentName : string = "grocery";
  slider;
  groceryArr;
  constructor(private service:ProductsService){
    this.slider = service.productSliderArr.find(product => product.path === this.componentName);
    this.groceryArr = service.groceryArr;
  }
}
