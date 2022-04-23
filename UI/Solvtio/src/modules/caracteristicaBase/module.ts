import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  CaracteristicaBaseItemComponent,
  CaracteristicaBaseListComponent,
} from './pages';
import { RoutingModule } from './routing';
import { TableModule } from 'ngx-easy-table';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

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
  ],
  exports: [CaracteristicaBaseListComponent, CaracteristicaBaseItemComponent],
  providers: [],
})
export class CaracteristicaBaseModule {}
