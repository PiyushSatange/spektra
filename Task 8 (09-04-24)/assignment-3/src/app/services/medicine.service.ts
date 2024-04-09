import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MedicineService {
  medicine: Array<any> = [
    {mid:1, mtitle:"Samsung Galaxy M34 5G", mdetails:"Samsung Galaxy M34 5G (Prism Silver,6GB,128GB)|120Hz sAMOLED Display|50MP Triple No Shake Cam|6000 mAh Battery|4 Gen OS Upgrade & 5 Year Security Update|12GB RAM with RAM+|Android 13|Without Charger", msrc:"https://m.media-amazon.com/images/I/91ItZJh1FDL._SX679_.jpg", mrating:4, price:15999},
    {mid:2, mtitle:"Pova 5 Pro 5G", mdetails:"Pova 5 Pro 5G (Dark Illusion, 8GB RAM,128GB Storage)| Segment 1st 68W Ultra Fast Charging | 50MP AI Dual Camera | India's 1st Multi-Colored Backlit ARC Interface | 6.78”FHD+ Dot-in Display", msrc:"https://m.media-amazon.com/images/I/4105IiC5tDL._SX300_SY300_QL70_FMwebp_.jpg", mrating:3, price:14999},
    {mid:3, mtitle:"OPPO A59 5G", mdetails:"OPPO A59 5G (Starry Black, 4GB RAM, 128GB Storage) | 5000 mAh Battery with 33W SUPERVOOC Charger | 6.56 HD+ 90Hz Display | with No Cost EMI/Additional Exchange Offers", msrc:"https://m.media-amazon.com/images/I/81tb1u-uIGL._SX679_.jpg", mrating:4, price:13999},
    {mid:4, mtitle:"Samsung Galaxy M14", mdetails:"Samsung Galaxy M14 4G (Sapphire Blue,4GB,64GB) | 50MP Triple Cam | 5000mAh Battery | Snapdragon 680 Processor | 2 Gen. OS Upgrade & 4 Year Security Update | 8GB RAM with RAM Plus | Without Charger", msrc:"https://m.media-amazon.com/images/I/41OtlIrnUbL._SX300_SY300_QL70_FMwebp_.jpg", mrating:5, price:8999},
    {mid:5, mtitle:"Redmi Note 13 5G", mdetails:"Redmi Note 13 5G (Stealth Black, 6GB RAM, 128GB Storage) | 5G Ready | 120Hz Bezel-Less AMOLED | 7.mm Slimmest Note Ever | 108MP Pro-Grade Camera", msrc:"https://m.media-amazon.com/images/I/71NnrsYP63L._SX679_.jpg", mrating:3, price:17999},
    {mid:6, mtitle:"Nokia G42 5G", mdetails:"Nokia G42 5G Powered by Snapdragon® 480 Plus 5G | 50MP Triple Rear AI Camera | 6GB RAM (4GB RAM + 2GB Virtual RAM) | 128GB Storage | 3-Day Battery Life | 2 Years of Android Upgrades | SO Pink", msrc:"https://m.media-amazon.com/images/I/41dEcQR7UnL._SX300_SY300_QL70_FMwebp_.jpg", mrating:3, price:9999}
  ]
}
