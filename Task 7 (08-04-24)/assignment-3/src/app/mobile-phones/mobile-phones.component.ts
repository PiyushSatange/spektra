import { Component } from '@angular/core';

@Component({
  selector: 'app-mobile-phones',
  templateUrl: './mobile-phones.component.html',
  styleUrl: './mobile-phones.component.css'
})
export class MobilePhonesComponent {
  mobileArray : Array<any> = [
    {
      title : "Vivo",
      imgsrc : "https://tiimg.tistatic.com/fp/1/007/574/vivo-mobile-phone-7-38mm-ultra-smooth-body-170g-light-2-5d-adjusted-outline-for-a-great-hold-703.jpg"
    },
    {
      title : "Redmi",
      imgsrc : "https://www.suryaelectronics.in/CommonImageHandler/ImageHandler.ashx?imagepath=~/img/Product/Main/VivoMobilePhonesandAccessoriesMobilePhones324.jpg"
    },
    {
      title : "Pixels",
      imgsrc : "https://tiimg.tistatic.com/fp/1/008/331/720-x-1600-pixels-64-gb-single-camera-oled-android-mobile-phone--666.jpg"
    },
    {
      title : "One Plus",
      imgsrc : "https://i.gadgets360cdn.com/products/large/Oppo-Reno-10-Pro-Plus-5G-DB-709x800-1685018454.jpg"
    },
    {
      title : "Oppo",
      imgsrc : "https://opsg-img-cdn-gl.heytapimg.com/epb/202402/20/VYh23XynbefcMeYT.png"
    },
    {
      title : "One Plus",
      imgsrc : "https://p-sg.ipricegroup.com/uploaded_f0a0be183b1ee64b7e7eb668b8bdef7b5cf7e4e3.jpg"
    },
    {
      title : "Vivo",
      imgsrc : "https://img.etimg.com/photo/msid-99080556,imgsize-32858/VivoY56BlackEngine.jpg"
    },
    {
      title : "Samsung",
      imgsrc : "https://rukminim2.flixcart.com/image/500/500/xif0q/mobile/f/n/u/-original-imagx9egm9mgmvab.jpeg"
    },
  ]
}
