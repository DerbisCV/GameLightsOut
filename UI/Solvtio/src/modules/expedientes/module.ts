import { TableModule } from 'ngx-easy-table';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExpedienteItemComponent, ExpedienteListComponent } from './pages';
import { RoutingModule } from './routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
  declarations: [ExpedienteListComponent, ExpedienteItemComponent],
  imports: [
    CommonModule,
    RoutingModule,
    TableModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
  ],
  exports: [ExpedienteListComponent, ExpedienteItemComponent],
  providers: [],
})
export class ExpedienteModule {}
