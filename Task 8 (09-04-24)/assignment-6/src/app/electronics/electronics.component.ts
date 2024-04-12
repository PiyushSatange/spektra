import { Component } from '@angular/core';
import { ProductsService } from '../service/products.service';

@Component({
  selector: 'app-electronics',
  templateUrl: './electronics.component.html',
  styleUrl: './electronics.component.css'
})
export class ElectronicsComponent {
  componentName : string = "electronics";
  slider;
  electronicsArr;
  constructor(private service:ProductsService){
    this.slider = service.productSliderArr.find(product => product.path === this.componentName);
    this.electronicsArr = service.electronicsArr;
  }
}
