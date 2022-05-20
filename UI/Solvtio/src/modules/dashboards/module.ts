import { TableModule } from 'ngx-easy-table';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboradKpiComponent } from './pages';
import { RoutingModule } from './routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { CardKpiComponent } from '../components/cardKpi/cardKpi';

@NgModule({
  declarations: [DashboradKpiComponent, CardKpiComponent],
  imports: [
    CommonModule,
    RoutingModule,
    TableModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    TabsModule.forRoot(),
    BsDatepickerModule.forRoot(),
  ],
  exports: [DashboradKpiComponent, CardKpiComponent],
  providers: [],
})
export class DashboardModule {}
