import { Component } from '@angular/core';

@Component({
  selector: 'app-beauty',
  templateUrl: './beauty.component.html',
  styleUrl: './beauty.component.css'
})
export class BeautyComponent {
  beautyArray : Array<any> = [
    {
      title : "Blue Jacket",
      imgsrc : "https://m.media-amazon.com/images/I/31Qf+ZB1TuL._SY300_SX300_.jpg"
    },
    {
      title : "Brown Jacket",
      imgsrc : "https://m.media-amazon.com/images/I/31NhKOZb3kL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Cool Jacket",
      imgsrc : "https://m.media-amazon.com/images/I/31MLYU-IznL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Blue Hoodie",
      imgsrc : "https://m.media-amazon.com/images/I/31bgceBBkML._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Stylish Cloths",
      imgsrc : "https://m.media-amazon.com/images/I/41zRBBsIEoL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Gao Wear",
      imgsrc : "https://m.media-amazon.com/images/I/31lwoTC3hGL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Office Wear",
      imgsrc : "https://m.media-amazon.com/images/I/31X0ktajMxL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Winter Wear",
      imgsrc : "https://m.media-amazon.com/images/I/31lyZiU5UAL._SX300_SY300_QL70_FMwebp_.jpg"
    },
  ]
}
