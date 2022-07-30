import { BodyComponent } from "./layout/body/body.component";

export const HomeRoutes = [
  {
      path: '',
      component: BodyComponent,
      children: [
          {
              path: '',
              redirectTo: 'capacity-plans',
              pathMatch: 'full',
          },
          {
            path: 'capacity-plans',
            loadChildren: () => import('./pages/capacity-plans/capacity-plans.module').then(m => m.CapacityPlansModule),
          }
      ]
  }
];
