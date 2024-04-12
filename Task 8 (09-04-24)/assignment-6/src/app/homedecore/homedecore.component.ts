import { Component } from '@angular/core';
import { ProductsService } from '../service/products.service';

@Component({
  selector: 'app-homedecore',
  templateUrl: './homedecore.component.html',
  styleUrl: './homedecore.component.css'
})
export class HomedecoreComponent {
  componentName : string = "homedecore";
  slider;
  decoreArr;
  constructor(private service:ProductsService){
    this.slider = service.productSliderArr.find(product => product.path === this.componentName);
    this.decoreArr = service.decoreArr;
  }
}
