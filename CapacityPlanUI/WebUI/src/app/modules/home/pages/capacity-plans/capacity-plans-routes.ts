import { Routes } from "@angular/router";
import { ListCapacityPlansComponent } from "./components/list-capacity-plans/list-capacity-plans.component";

export const CapacityPlansRoutes: Routes = [
    {
      path: '',
      component: ListCapacityPlansComponent,
    },
];