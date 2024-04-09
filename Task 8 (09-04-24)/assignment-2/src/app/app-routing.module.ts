import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MedicineProductsComponent } from './medicine-products/medicine-products.component';
import { ItemComponent } from './item/item.component';
import { SuccessComponent } from './success/success.component';
import { PaymentPageComponent } from './payment-page/payment-page.component';

const routes: Routes = [
  {
    path: "",
    component: MedicineProductsComponent
  },
  {
    path: "Home",
    redirectTo: ""
  },
  {
    path: "item/:id",
    component: ItemComponent
  },
  {
    path: "payment",
    component: PaymentPageComponent
  },
  {
    path: "success",
    component: SuccessComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
