import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { BeautyComponent } from './beauty/beauty.component';
import { ClothsComponent } from './cloths/cloths.component';
import { ElectronicsComponent } from './electronics/electronics.component';
import { GroceryComponent } from './grocery/grocery.component';
import { HomedecoreComponent } from './homedecore/homedecore.component';
import { ItemComponent } from './item/item.component';
import { PaymentPageComponent } from './payment-page/payment-page.component';
import { SuccessPageComponent } from './success-page/success-page.component';

const routes: Routes = [
  {
    path: "",
    component: HomePageComponent
  },
  {
    path: "home",
    redirectTo: ""
  },
  {
    path: "beauty",
    component: BeautyComponent
  },
  {
    path: "cloths",
    component: ClothsComponent
  },
  {
    path: "electronics",
    component: ElectronicsComponent
  },
  {
    path: "grocery",
    component: GroceryComponent
  },
  {
    path: "homedecore",
    component: HomedecoreComponent
  },
  {
    path: ":type/:id",
    component: ItemComponent
  },
  {
    path: "payment",
    component: PaymentPageComponent
  },
  {
    path: "success",
    component: SuccessPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
