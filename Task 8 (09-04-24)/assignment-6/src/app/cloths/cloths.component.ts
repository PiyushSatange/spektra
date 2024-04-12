import { Component } from '@angular/core';
import { ProductsService } from '../service/products.service';

@Component({
  selector: 'app-cloths',
  templateUrl: './cloths.component.html',
  styleUrl: './cloths.component.css'
})
export class ClothsComponent {
  componentName : string = "cloths";
  slider;
  clothArr;
  constructor(private service:ProductsService){
    this.slider = service.productSliderArr.find(product => product.path === this.componentName);
    this.clothArr = service.clothsArr;
  }

}
