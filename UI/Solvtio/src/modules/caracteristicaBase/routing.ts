import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {
  CaracteristicaBaseListComponent,
  CaracteristicaBaseItemComponent,
} from './pages';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: CaracteristicaBaseListComponent,
      },
      {
        path: 'create',
        component: CaracteristicaBaseItemComponent,
      },
      {
        path: 'update/:id',
        component: CaracteristicaBaseItemComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class RoutingModule {}
