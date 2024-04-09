import { Component } from '@angular/core';

@Component({
  selector: 'app-appliances',
  templateUrl: './appliances.component.html',
  styleUrl: './appliances.component.css'
})
export class AppliancesComponent {
  appliancesArray : Array<any> = [
    {
      title : "Blue Jacket",
      imgsrc : "https://m.media-amazon.com/images/I/31-N7Faex9L._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Brown Jacket",
      imgsrc : "https://m.media-amazon.com/images/I/51lKT7mfRwL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Cool Jacket",
      imgsrc : "https://m.media-amazon.com/images/I/315hr9MQUEL._SY300_SX300_QL70_FMwebp_.jpg"
    },
    {
      title : "Blue Hoodie",
      imgsrc : "https://m.media-amazon.com/images/I/31jFN3YUeIL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Stylish Cloths",
      imgsrc : "https://m.media-amazon.com/images/I/418987xxUJL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Gao Wear",
      imgsrc : "https://m.media-amazon.com/images/I/41TmGJw2b-L._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Office Wear",
      imgsrc : "https://m.media-amazon.com/images/I/41EYr8qKrYL._SX300_SY300_QL70_FMwebp_.jpg"
    },
    {
      title : "Winter Wear",
      imgsrc : "https://m.media-amazon.com/images/I/312IVxNxOKS._SX300_SY300_QL70_FMwebp_.jpg"
    },
  ]
}
