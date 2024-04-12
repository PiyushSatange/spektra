import { Component } from '@angular/core';
import { ProductsService } from '../service/products.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {
  sliderArr;
  categoryArr;
  constructor(private service:ProductsService){
    this.sliderArr = service.productSliderArr;
    this.categoryArr = service.productCategoryArr;
  }
}
