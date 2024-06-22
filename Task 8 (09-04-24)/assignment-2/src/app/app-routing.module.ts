import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MedicineProductsComponent } from './medicine-products/medicine-products.component';
import { ItemComponent } from './item/item.component';
import { SuccessComponent } from './success/success.component';
import { PaymentPageComponent } from './payment-page/payment-page.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { AdminProductComponent } from './admin-product/admin-product.component';
import { AdminOrdersComponent } from './admin-orders/admin-orders.component';

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
    path: "payment/:id",
    component: PaymentPageComponent
  },
  {
    path: "success",
    component: SuccessComponent
  },
  {
    path: "admin",
    component: AdminPanelComponent,
  },
  {
    path: "admin/item/:id",
    component: AdminProductComponent
  },
  {
    path: "admin/orders",
    component: AdminOrdersComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
