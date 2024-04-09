import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsCategoryComponent } from './products-category/products-category.component';
import { AppliancesComponent } from './appliances/appliances.component';
import { BeautyComponent } from './beauty/beauty.component';
import { FurnitureComponent } from './furniture/furniture.component';
import { MenClothingComponent } from './men-clothing/men-clothing.component';
import { WomenClothingComponent } from './women-clothing/women-clothing.component';
import { MobilePhonesComponent } from './mobile-phones/mobile-phones.component';

const routes: Routes = [
  {
    path : "",
    component : ProductsCategoryComponent
  },
  {
    path : "home",
    redirectTo : ""
  },
  {
    path : "appliances",
    component : AppliancesComponent
  },
  {
    path : "beauty",
    component : BeautyComponent
  },
  {
    path : "furniture",
    component : FurnitureComponent
  },
  {
    path : "menClothing",
    component : MenClothingComponent
  },
  {
    path : "womenClothing",
    component : WomenClothingComponent
  },
  {
    path : "mobilePhones",
    component : MobilePhonesComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
