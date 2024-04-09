import { Component } from '@angular/core';

@Component({
  selector: 'app-men-clothing',
  templateUrl: './men-clothing.component.html',
  styleUrl: './men-clothing.component.css'
})
export class MenClothingComponent {
  mobileArray : Array<any> = [
    {
      title : "Blue Jacket",
      imgsrc : "https://www.nextdirect.com/nxtcms/resource/blob/5821500/e62e1d85d444c992f222485ababad4b1/coats-data.jpg"
    },
    {
      title : "Brown Jacket",
      imgsrc : "https://www.nextdirect.com/nxtcms/resource/blob/5821518/d114a8023263017f86b11c206949508e/shackets-data.jpg"
    },
    {
      title : "Cool Jacket",
      imgsrc : "https://i.pinimg.com/736x/31/b1/c2/31b1c2775652516389dce74a012c9dd8.jpg"
    },
    {
      title : "Blue Hoodie",
      imgsrc : "https://www.nextdirect.com/nxtcms/resource/blob/5821504/ee0fc6a294be647924fa5f5e7e3df8e9/hoodies-data.jpg"
    },
    {
      title : "Stylish Cloths",
      imgsrc : "https://www.axul.com/cdn/shop/collections/39_1024x1024.png"
    },
    {
      title : "Gao Wear",
      imgsrc : "https://i.pinimg.com/736x/4b/ea/c1/4beac1a2ceb6ff197cd14c57547d5356.jpg"
    },
    {
      title : "Office Wear",
      imgsrc : "https://images.bestsellerclothing.in/data/selected/04-mar-2024/104576701_g1.jpg"
    },
    {
      title : "Winter Wear",
      imgsrc : "https://wearemonochromatic.com/cdn/shop/files/AFKN543-1_49967089-da45-4f29-b294-d1c63fccf22e_600x.webp"
    },
  ]
}
