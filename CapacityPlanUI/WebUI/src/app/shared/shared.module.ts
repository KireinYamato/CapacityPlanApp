import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuListComponent } from './components/menu-list/menu-list.component';
import { SharedRoutingModule } from './shared-routing.module';



@NgModule({
  declarations: [
    MenuListComponent
  ],
  imports: [
    CommonModule,
    SharedRoutingModule
  ],
  exports: [
    MenuListComponent,
  ]
})
export class SharedModule { }
