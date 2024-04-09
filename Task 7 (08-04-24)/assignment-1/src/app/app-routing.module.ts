import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DatapageComponent } from './datapage/datapage.component';
import { MyformComponent } from './myform/myform.component';

const routes: Routes = [
  {
    path: "",
    component: MyformComponent
  },
  {
    path: "data",
    component: DatapageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
