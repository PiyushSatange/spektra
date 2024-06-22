import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuypageComponent } from './buypage/buypage.component';
import { SuccessComponent } from './success/success.component';
import { ProductsComponent } from './products/products.component';

const routes: Routes = [
  {path:'', component:ProductsComponent},
  {path:"buypage/:id", component:BuypageComponent},
  {path:"success", component:SuccessComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
