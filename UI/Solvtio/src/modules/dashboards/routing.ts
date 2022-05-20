import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
// import { ExpedienteEstadoFichaComponent } from '../components/expedienteEstado/ficha';
import { DashboradKpiComponent } from './pages';
// import { ExpedienteAlquilerListComponent } from './pages/alquiler';
// import { ExpedienteHipotecarioListComponent } from './pages/hipotecario';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: DashboradKpiComponent,
      },
      // {
      //   path: 'create',
      //   component: ExpedienteItemComponent,
      // },
      // {
      //   path: 'update/:id',
      //   component: ExpedienteItemComponent,
      // },
      // {
      //   path: 'updateEstado/:id',
      //   component: ExpedienteEstadoFichaComponent,
      // },
      // {
      //   path: 'alquiler',
      //   component: ExpedienteAlquilerListComponent,
      // },
      // {
      //   path: 'hipotecario',
      //   component: ExpedienteHipotecarioListComponent,
      // },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class RoutingModule {}
