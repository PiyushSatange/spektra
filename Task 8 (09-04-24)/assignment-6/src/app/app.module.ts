import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ElectronicsComponent } from './electronics/electronics.component';
import { ClothsComponent } from './cloths/cloths.component';
import { GroceryComponent } from './grocery/grocery.component';
import { BeautyComponent } from './beauty/beauty.component';
import { HomedecoreComponent } from './homedecore/homedecore.component';
import { HomePageComponent } from './home-page/home-page.component';
import { SuccessPageComponent } from './success-page/success-page.component';
import { PaymentPageComponent } from './payment-page/payment-page.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ItemComponent } from './item/item.component';

@NgModule({
  declarations: [
    AppComponent,
    ElectronicsComponent,
    ClothsComponent,
    GroceryComponent,
    BeautyComponent,
    HomedecoreComponent,
    HomePageComponent,
    SuccessPageComponent,
    PaymentPageComponent,
    NavbarComponent,
    ItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
