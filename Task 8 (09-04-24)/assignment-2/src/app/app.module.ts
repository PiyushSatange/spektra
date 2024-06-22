import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ItemComponent } from './item/item.component';
import { NavbarComponent } from './navbar/navbar.component';
import { MedicineProductsComponent } from './medicine-products/medicine-products.component';
import { PaymentPageComponent } from './payment-page/payment-page.component';
import { SuccessComponent } from './success/success.component';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { AdminProductComponent } from './admin-product/admin-product.component';
import { AdminOrdersComponent } from './admin-orders/admin-orders.component';


@NgModule({
  declarations: [
    AppComponent,
    ItemComponent,
    NavbarComponent,
    MedicineProductsComponent,
    PaymentPageComponent,
    SuccessComponent,
    AdminPanelComponent,
    AdminProductComponent,
    AdminOrdersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
