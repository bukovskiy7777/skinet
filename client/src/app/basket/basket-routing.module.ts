import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { BasketComponent } from './basket.component';

const routs: Routes = [
  {path: '', component: BasketComponent}
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routs)
  ],
  exports: [RouterModule]
})
export class BasketRoutingModule { }
