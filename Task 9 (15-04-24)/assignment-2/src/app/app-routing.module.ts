import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListProductsComponent } from './list-products/list-products.component';
import { EditProductComponent } from './edit-product/edit-product.component';
import { AddProductComponent } from './add-product/add-product.component';

const routes: Routes = [
  {
    path:"",
    component: ListProductsComponent
  },
  {
    path:"edit/:id",
    component: EditProductComponent
  },
  {
    path:"add",
    component: AddProductComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
