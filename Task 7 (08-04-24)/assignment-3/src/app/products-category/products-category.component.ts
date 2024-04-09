import { Component } from '@angular/core';

@Component({
  selector: 'app-products-category',
  templateUrl: './products-category.component.html',
  styleUrl: './products-category.component.css'
})
export class ProductsCategoryComponent {
  categoryArray : Array<any> = [
    {
      title : "Mobile Phones",
      imgsrc : "https://www.kindpng.com/picc/m/109-1097440_latest-mobile-banner-png-transparent-png.png",
      link : "mobilePhones"
    },
    {
      title : "Men Clothing",
      imgsrc : "https://www.bestmenswear.com/Images/Homepages/mobile/ss24/NewArrivals24-PBP.jpg",
      link : "menClothing"
    },
    {
      title : "Women Clothing",
      imgsrc : "https://www.beyoung.in/api/cache/catalog/products/banner_desktop/Women-clothing-banner-mobile-view_28_07_2023_767x430.jpg",
      link : "womenClothing"
    },
    {
      title : "Appliances & Tools",
      imgsrc : "https://promova.com/content/kitchen_appliances_names_c099006f30.png",
      link : "appliances"
    },
    {
      title : "Beauty & Grooming",
      imgsrc : "https://etimg.etb2bimg.com/thumb/msid-86771640,imgsize-189454,width-1200,height=765,overlay-etretail/health-and-beauty/cosmetics-and-fragrances/lakme-wont-carry-tests-on-animals-for-its-cosmetics-products.jpg",
      link : "beauty"
    },
    {
      title : "Home Furniture",
      imgsrc : "https://media.designcafe.com/wp-content/uploads/2023/07/05120637/modern-furniture-designs.jpg",
      link : "furniture"
    }
  ];
}
