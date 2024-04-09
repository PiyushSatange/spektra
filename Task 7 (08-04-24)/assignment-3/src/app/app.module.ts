import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ProductsCategoryComponent } from './products-category/products-category.component';
import { MobilePhonesComponent } from './mobile-phones/mobile-phones.component';
import { MenClothingComponent } from './men-clothing/men-clothing.component';
import { WomenClothingComponent } from './women-clothing/women-clothing.component';
import { AppliancesComponent } from './appliances/appliances.component';
import { BeautyComponent } from './beauty/beauty.component';
import { FurnitureComponent } from './furniture/furniture.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ProductsCategoryComponent,
    MobilePhonesComponent,
    MenClothingComponent,
    WomenClothingComponent,
    AppliancesComponent,
    BeautyComponent,
    FurnitureComponent
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
