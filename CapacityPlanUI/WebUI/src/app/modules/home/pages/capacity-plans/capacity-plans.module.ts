import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CapacityPlansRoutingModule } from './capacity-plans-routing.module';
import { ListCapacityPlansComponent } from './components/list-capacity-plans/list-capacity-plans.component';
import { AddCapacityPlansComponent } from './components/add-capacity-plans/add-capacity-plans.component';
import { EditCapacityPlansComponent } from './components/edit-capacity-plans/edit-capacity-plans.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxSpinnerModule } from 'ngx-spinner';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";


@NgModule({
  declarations: [
    ListCapacityPlansComponent,
    AddCapacityPlansComponent,
    EditCapacityPlansComponent
  ],
  imports: [
    CommonModule,
    CapacityPlansRoutingModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    NgxSpinnerModule
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class CapacityPlansModule { }
