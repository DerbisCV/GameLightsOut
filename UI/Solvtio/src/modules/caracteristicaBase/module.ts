import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  CaracteristicaBaseItemComponent,
  CaracteristicaBaseListComponent,
} from './pages';
import { RoutingModule } from './routing';

@NgModule({
  declarations: [
    CaracteristicaBaseListComponent,
    CaracteristicaBaseItemComponent,
  ],
  imports: [CommonModule, RoutingModule],
  exports: [CaracteristicaBaseListComponent, CaracteristicaBaseItemComponent],
  providers: [],
})
export class CaracteristicaBaseModule {}
