import { Component } from '@angular/core';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrl: './product-details.component.css'
})
export class ProductDetailsComponent {
  Products : Array<any> = [
    {id:1, title:"Table", price:2500, quantity:8},
    {id:2, title:"Chair", price:7000, quantity:12},
    {id:3, title:"Bag", price:950, quantity:20},
    {id:4, title:"Pen", price:12, quantity:50},
    {id:5, title:"Mobile", price:20000, quantity:13},
    {id:6, title:"Charger", price:800, quantity:23},
    {id:7, title:"TV", price:55000, quantity:7},
    {id:8, title:"Laptop", price:75000, quantity:10},
    {id:9, title:"Mouse", price:500, quantity:20},
    {id:10, title:"Keyboard", price:700, quantity:15}
]

}
