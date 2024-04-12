import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  productSliderArr : Array<any> = [
    {id:1, path:"beauty", imgsrc:"https://i.ibb.co/Wvnj0Cg/Skincare-PC-3000-1200-CB560068220.jpg"},
    {id:2, path:"cloths", imgsrc:"https://i.ibb.co/Jk4xvJQ/KA-2x-CB560453769.jpg"},
    {id:3, path:"electronics", imgsrc:"https://i.ibb.co/XCWsWLC/Under-1499-Tallhero-3000x1200-CB561212093.jpg"},
    {id:4, path:"grocery", imgsrc:"https://i.ibb.co/x2HKpYs/PC-Hero-1-3000-CB582457311.jpghttps://i.ibb.co/YBgZtjY/PC-hero-1-2x-1-CB582889946.jpg"},
    {id:5, path:"homedecore", imgsrc:"https://i.ibb.co/YBgZtjY/PC-hero-1-2x-1-CB582889946.jpg"}
  ]

  productCategoryArr : Array<any> = [
    {id:1, title:"Beauty", path:"beauty", imgsrc:"https://www.puneonlineflorists.com/images/CSCSUUN695_big.webp"},
    {id:2, title:"Fashon", path:"cloths", imgsrc:"https://epiprodux.com/blog/wp-content/uploads/2023/03/mr_epiprodux_fashion_products_and_brands_under_management_9e6d2468-55a8-4f48-86cb-9b1b2841fac1.png"},
    {id:3, title:"Electronics", path:"electronics", imgsrc:"https://img.etimg.com/thumb/width-1200,height-1200,imgsize-33366,resizemode-75,msid-106289730/industry/cons-products/electronics/premiumisation-investments-to-propel-appliances-consumer-electronics-industry-in-2024.jpg"},
    {id:4, title:"Grocery", path:"grocery", imgsrc:"https://cccapi.cococa.in/public/uploads/category/rvUx6OiWUgqKnCeU_category.jpg"},
    {id:5, title:"Home Decore", path:"homedecore", imgsrc:"https://rukminim2.flixcart.com/image/850/1000/xif0q/wall-decoration/w/p/x/metal-wall-decor-wall-arts-for-home-living-room-hotel-decoration-original-imagqhzbtq8qhy4s.jpeg"}
  ]

  beautyArr : Array<any> = [
    {id:1, price:320 , imgsrc:"https://m.media-amazon.com/images/I/51lV2Pem64L._SL1000_.jpg", desc:"Simple Kind To Skin Refreshing Facial Wash 150 ml | 100% Soap-Free Facewash that doesn't dry out your skin| For All Skin Types"},
    {id:2, price:100 , imgsrc:"https://m.media-amazon.com/images/I/41YMxB8GbOL._SL1000_.jpg", desc:"NIVEA Nourishing Body Milk 600ml Body Lotion | 48 H Moisturization | With 2X Almond Oil | Smooth and Healthy Looking Skin |For Very Dry Skin"},
    {id:3, price:450 , imgsrc:"https://m.media-amazon.com/images/I/51YJWnJeCoL._SL1500_.jpg", desc:"Dot & Key Ceramides Moisturizer with Hyaluronic for Intense Moisturizing and Skin Strengthening | With Probiotic & Rice Water I Barrier Repair Cream | For Dry Skin, Normal Skin & Sensitive Skin | 100g"},
    {id:4, price:200 , imgsrc:"https://m.media-amazon.com/images/I/51l19NyctDL._SL1000_.jpg", desc:"Nivea Deodorant Roll On for Men, Deep Impact Freshness, 50ml and Deodorant Roll On for Men, Silver Protect, 50ml"},
    {id:5, price:289 , imgsrc:"https://m.media-amazon.com/images/I/41KewWs2TGL._SL1024_.jpg", desc:"The Face Shop Rice&Ceramide Moisturizing Emulsion With Rice Extracts|Light Weight Emulsion|Locks Moisture For 12 Hours,For Soft And Glowing Skin |Korean Beauty Products For All Skin,150Ml,Liquid"}
  ]

  clothsArr : Array<any> = [
    {id:1, price:560 ,  imgsrc:"https://m.media-amazon.com/images/I/61sYxulvVvL._SY879_.jpg", desc:"Lymio Men T-Shirt || Regular Fit T-Shirt for Men || Plain T Shirt || T-Shirt (Polo-06-10)"},
    {id:2, price:879 ,  imgsrc:"https://m.media-amazon.com/images/I/71-TnQTYwML._SY879_.jpg", desc:"Veirdo® Pure Cotton Oversized Loose Baggy Fit Cow & Zebra Animal Print White, Black & Lilac Round Neck T-Shirt with All Over Print for Men & Boys"},
    {id:3, price:499 ,  imgsrc:"https://m.media-amazon.com/images/I/71gD4IlNv8L._SY879_.jpg", desc:"Leriya Fashion t Shirt for Men| White t Shirt for Men| Black Drop Shoulder t-Shirt for Men"},
    {id:4, price:2000 ,  imgsrc:"https://m.media-amazon.com/images/I/718HV6Nx49L._SY879_.jpg", desc:"Lux Cozi Men's Regular Fit Polo Neck Half Sleeve Solid Casual T-Shirt | Polo T-Shirt for Men"},
    {id:5, price:999 ,  imgsrc:"https://m.media-amazon.com/images/I/71ckn-gM4UL._SY879_.jpg", desc:"EYEBOGLER Men's Trendy Polo Neck Half Sleeves Regular Fit Checkered T-Shirt"}
  ]

  electronicsArr : Array<any> = [
    {id:1, price:2000 ,  imgsrc:"https://m.media-amazon.com/images/I/61JtVmcxb0L._SL1080_.jpg", desc:"Fastrack Limitless Glide Advanced UltraVU HD Display|BT Calling|ATS Chipset|100+ Sports Modes & Watchfaces|Calculator|Voice Assistant|in-Built Games|24 * 7 HRM|IP68 Smartwatch"},
    {id:2, price:15999 ,  imgsrc:"https://m.media-amazon.com/images/I/81jeBCCEzXL._SL1500_.jpg", desc:"HONOR 90 (Emerald Green, 8GB + 256GB) | India's First Eye Risk-Free Display | 200MP Main & 50MP Selfie Camera | Segment First Quad-Curved AMOLED Screen | Without Charger"},
    {id:3, price:7000 ,  imgsrc:"https://m.media-amazon.com/images/I/41KuE9NipqL._SL1000_.jpg", desc:"Tapo TP-Link C200 360° 2MP 1080p Full HD Pan/Tilt Home Security Wi-Fi Smart Camera| Alexa Enabled| 2-Way Audio| Night Vision| Motion Detection| Sound and Light Alarm| Indoor CCTV White"},
    {id:4, price:96999 ,  imgsrc:"https://m.media-amazon.com/images/I/71iKNJ6rVIL._SL1000_.jpg", desc:"Sony Alpha ILCE 6100L 24.2 MP Mirrorless Digital SLR Camera with 16-50 mm Power Zoom Lens | APS-C Sensor | Fast Auto Focus,Real-time Eye AF,Real-time Tracking | 4K Vlogging Camera - Black"},
    {id:5, price:12999 ,  imgsrc:"https://m.media-amazon.com/images/I/61s-3q6CYxL._SL1500_.jpg", desc:"Zebronics Zeb-Storm Wired On Ear Headphone with 3.5mm Jack, Built-in Microphone for Calling, 1.5 Meter Cable, Soft Ear Cushion, Adjustable Headband, Foldable Ear Cups and Lightweight Design (Black)"}
  ]

  groceryArr : Array<any> = [
    {id:1, price:299 ,  imgsrc:"https://m.media-amazon.com/images/I/713D1eLsaqL._SL1500_.jpg", desc:"Happilo 100% Natural Premium California Dried Almonds 500g Pack Pouch | Premium Badam Giri | High in Fiber & Boost Immunity | Real Nuts | Gluten Free"},
    {id:2, price:199 ,  imgsrc:"https://m.media-amazon.com/images/I/7189G0CHFHL._SL1100_.jpg", desc:"MAGGI Masala-ae-Magic Vegetable Masala, All in One | 72grams Pouch (6gm x 12 Sachets) Powder"},
    {id:3, price:189 ,  imgsrc:"https://m.media-amazon.com/images/I/61eMslXEBgL._SL1080_.jpg", desc:"Nutri Organics Dry Fruits Natural Premium Whole Cashews 1kg | Whole Crunchy Cashew | Premium Kaju nuts Dry Fruit | Nutritious & Delicious | Gluten Free & Plant based Protein"},
    {id:4, price:399 ,  imgsrc:"https://m.media-amazon.com/images/I/71BzsxldCBL._SL1500_.jpg", desc:"Quaker Oats 2kg | Rolled Oats | 100% Natural Wholegrain | Nutritious Breakfast Cereals | Porridge | Easy to Cook"},
    {id:5, price:149 ,  imgsrc:"https://m.media-amazon.com/images/I/61AdBfnafWL._SL1000_.jpg", desc:"Tata Sampann Unpolished Toor Dal/Arhar Dal, 1kg | Nutritious Breakfast | Easy to Cook | Premium Daal"}
  ]

  decoreArr : Array<any> = [
    {id:1, price:999 ,  imgsrc:"https://m.media-amazon.com/images/I/81jaarjkZKL._SL1500_.jpg", desc:"Dime Store Wooden Wall Shelves | Corner Hanging Shelf for Living Room Stylish | Zig Zag Home Decor Floating Display Rack for Storage"},
    {id:2, price:399 ,  imgsrc:"https://m.media-amazon.com/images/I/71mP1uIKSbL._SX679_.jpg", desc:"KridayKraft Metal Ganesha ji Statue,Ganpati Wall Hanging Sculpture Lord Ganesh Idol Lucky Feng Shui Wall Decor Your Home, Office,Religious Gift Article Decorative,Showpiece Figurines"},
    {id:3, price:89 ,  imgsrc:"https://m.media-amazon.com/images/I/61+hLmdD6UL._SL1500_.jpg", desc:"Xtore Ceramic Golden Blessing Birds Figurine for Home Decor | Living Room, Bedroom, Office Desk, Cabinets - (Pack of 2, Golden)"},
    {id:4, price:499 ,  imgsrc:"https://m.media-amazon.com/images/I/81dGkYK8BlL._SL1500_.jpg", desc:"RUCON® 3D Moon lamp 7 Multi Colors Changing Touch Sensor for Adult and Kids with Wooden Stand Night Lamp for Bedroom Home Decorations Light -15cm"},
    {id:5, price:189 ,  imgsrc:"https://m.media-amazon.com/images/I/71ZDWvtoolL._SL1500_.jpg", desc:"SATYAM KRAFT 3 Pcs Artificial Flowers Small Fake Flower Faux Pampas Fluffy for Home, Office, Bedroom Decoration (Without Vase Pot) (Light Brown, Fabric)"}
  ]
}
