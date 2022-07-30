import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CapacityPlansRoutes } from './capacity-plans-routes';

@NgModule({
  imports: [RouterModule.forChild(CapacityPlansRoutes)],
  exports: [RouterModule]
})
export class CapacityPlansRoutingModule { }
