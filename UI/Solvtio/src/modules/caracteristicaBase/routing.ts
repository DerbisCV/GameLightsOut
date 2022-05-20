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
      {
        path: 'byGroup/:id',
        component: CaracteristicaBaseListComponent,
      },
      //https://solvtio.tarsso.com/Nomenclador/Caracteristica/Pais?Area=
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class RoutingModule {}
