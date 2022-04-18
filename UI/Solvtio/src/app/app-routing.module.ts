import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'caracteristicabase',
    loadChildren: () =>
      import('../modules/caracteristicaBase/module').then(
        (m) => m.CaracteristicaBaseModule
      ),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
