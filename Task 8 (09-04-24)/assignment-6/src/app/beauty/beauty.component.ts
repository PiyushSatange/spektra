import { Component } from '@angular/core';
import { ProductsService } from '../service/products.service';

@Component({
  selector: 'app-beauty',
  templateUrl: './beauty.component.html',
  styleUrl: './beauty.component.css'
})
export class BeautyComponent {
  componentName : string = "beauty";
  slider;
  beautyArr;
  constructor(private service:ProductsService){
    this.slider = service.productSliderArr.find(product => product.path === this.componentName);
    this.beautyArr = service.beautyArr;
  }
}
