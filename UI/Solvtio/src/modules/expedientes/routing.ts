import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExpedienteListComponent, ExpedienteItemComponent } from './pages';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: ExpedienteListComponent,
      },
      {
        path: 'create',
        component: ExpedienteItemComponent,
      },
      {
        path: 'update/:id',
        component: ExpedienteItemComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class RoutingModule {}
