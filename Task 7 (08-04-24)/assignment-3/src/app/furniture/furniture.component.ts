import { Component } from '@angular/core';

@Component({
  selector: 'app-furniture',
  templateUrl: './furniture.component.html',
  styleUrl: './furniture.component.css'
})
export class FurnitureComponent {
  furnitureArray : Array<any> = [
    {
      title : "Blue Sofa",
      imgsrc : "https://backgroundimages.withfloats.com/actual/5efb1e4939d66f00014845b7.jpg"
    },
    {
      title : "Black Furniture",
      imgsrc : "https://m.media-amazon.com/images/I/71lmFBWhE-L.jpg"
    },
    {
      title : "Wooden Furniture",
      imgsrc : "https://www.ikea.com/in/en/images/products/songesand-bedroom-furniture-set-of-4-brown__1102154_pe866532_s5.jpg"
    },
    {
      title : "Wooden Furniture",
      imgsrc : "https://www.mobelhomestore.com/cdn/shop/files/Untitled_design_c4e9bc56-67e6-426b-af38-58bf94a49ef2.jpg"
    },
    {
      title : "White Sofa",
      imgsrc : "https://www.huset.com.au/blog/wp-content/uploads/2023/10/2.png"
    },
    {
      title : "Blue Sofa",
      imgsrc : "https://rukminim2.flixcart.com/image/850/1000/kyoqmq80/sofa-sectional/8/t/h/right-facing-73-66-sky-blue-cotton-blend-190-5-25-twf-224-original-imagav2gwxmzpdmp.jpeg"
    },
    {
      title : "Blue Sofa",
      imgsrc : "https://www.eshopregal.in/wp-content/uploads/2017/10/02.jpg"
    },
    {
      title : "White Sofa",
      imgsrc : "https://www.godrejinterio.com/imagestore/B2C/56101515SD00576/56101515SD00576_A2_500x500.jpg"
    },
  ]
}
