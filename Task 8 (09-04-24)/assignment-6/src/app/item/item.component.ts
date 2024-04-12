import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../service/products.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrl: './item.component.css'
})
export class ItemComponent implements OnInit{
  type : any;
  id : any;
  productArr : Array<any> = [];
  productItem : any;
  constructor(private service:ProductsService, private route: ActivatedRoute, private router:Router){}

  ngOnInit(): void {
    this.type = this.route.snapshot.paramMap.get('type');
    this.id = this.route.snapshot.paramMap.get('id');
    switch (this.type) {
      case "beauty":
        this.productArr = this.service.beautyArr
        break;
      case "cloths":
        this.productArr = this.service.clothsArr
        break;
      case "electronics":
        this.productArr = this.service.electronicsArr
        break;
      case "grocery":
        this.productArr = this.service.groceryArr
        break;
      case "homedecore":
        this.productArr = this.service.decoreArr
        break;
    }
    this.productItem = this.productArr.find(product => product.id == this.id);
  }

  onBuy(){
    this.router.navigate(['payment'], {
      state:{
        item: this.productItem
      }
    })
  }
}
