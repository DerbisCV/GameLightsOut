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
import { TabsModule } from 'ngx-bootstrap/tabs';

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
    TabsModule.forRoot(),
  ],
  exports: [CaracteristicaBaseListComponent, CaracteristicaBaseItemComponent],
  providers: [],
})
export class CaracteristicaBaseModule {}
