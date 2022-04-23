import { TableModule } from 'ngx-easy-table';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  CaracteristicaBaseItemComponent,
  CaracteristicaBaseListComponent,
} from './pages';
import { RoutingModule } from './routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
  declarations: [
    CaracteristicaBaseListComponent,
    CaracteristicaBaseItemComponent,
  ],
  imports: [
    CommonModule,
    RoutingModule,
    TableModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
  ],
  exports: [CaracteristicaBaseListComponent, CaracteristicaBaseItemComponent],
  providers: [],
})
export class CaracteristicaBaseModule {}
