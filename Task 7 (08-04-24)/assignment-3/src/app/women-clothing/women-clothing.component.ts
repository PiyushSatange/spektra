import { Component } from '@angular/core';

@Component({
  selector: 'app-women-clothing',
  templateUrl: './women-clothing.component.html',
  styleUrl: './women-clothing.component.css'
})
export class WomenClothingComponent {
  ClothArray : Array<any> = [
    {
      title : "Blue Goun",
      imgsrc : "https://www.next.com.au/nxtcms/resource/blob/5791996/a2e4dff8740ae3595728abb624f07934/dresses-data.jpg"
    },
    {
      title : "White Dress",
      imgsrc : "https://cdn07.nnnow.com/web-images/medium/styles/ZHPEZ02FNX7/1697519957181/1.jpg"
    },
    {
      title : "Beach Dress",
      imgsrc : "https://www.liveabout.com/thmb/Pgxmrix9jntK_H_KK1zGBvSvdbE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/appleseeds-catalog-7ac1254097be4dda8c0a410c4afcb509.jpg"
    },
    {
      title : "White Kurta",
      imgsrc : "https://assets.myntassets.com/dpr_1.5,q_60,w_400,c_limit,fl_progressive/assets/images/25234310/2023/9/26/d6241239-dca6-4347-b0e9-f8b57181d25d1695713495036KurtaSets1.jpg"
    },
    {
      title : "Blue Shirt",
      imgsrc : "https://www.andindia.com/dw/image/v2/BGCX_PRD/on/demandware.static/-/Sites-masterCatalog_ANDIndia/default/dwda02fd54/images/hires/SS22/AND-S24AJ048TR38-BLUPRT-(21)NEW.jpg"
    },
    {
      title : "Stylish Wear",
      imgsrc : "https://img.kwcdn.com/product/Fancyalgo/VirtualModelMatting/69acd97529f1e5be6933a8ef8afb7973.jpg"
    },
    {
      title : "Summer Wear",
      imgsrc : "https://www.tomjames.com/pics/catalog/2024SP/pics/Tom-James-Spring-2024-Womens-36.jpg"
    },
    {
      title : "Orange Dress",
      imgsrc : "https://assets.myntassets.com/dpr_1.5,q_60,w_400,c_limit,fl_progressive/assets/images/22036972/2023/2/19/9cd80c40-c890-4e10-b000-6d1d3ee7a08f1676759415778Co-Ords1.jpg"
    }
  ]
}
