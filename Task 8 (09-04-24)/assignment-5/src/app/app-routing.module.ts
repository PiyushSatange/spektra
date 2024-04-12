import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PeopleListComponent } from './people-list/people-list.component';
import { DetailsComponent } from './details/details.component';

const routes: Routes = [
  {
    path: "",
    component: PeopleListComponent
  },
  {
    path: "detail/:id",
    component: DetailsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
