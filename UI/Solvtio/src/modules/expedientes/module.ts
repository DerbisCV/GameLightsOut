import { TableModule } from 'ngx-easy-table';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExpedienteItemComponent, ExpedienteListComponent } from './pages';
import { RoutingModule } from './routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { ExpedienteDeudorListComponent } from '../components/expedienteDeudor/list';
import { ExpedienteNotaListComponent } from '../components/expedienteNota/list';
import { ExpedienteNotaItemComponent } from '../components/expedienteNota/item';
import { ExpedienteDeudorItemComponent } from '../components/expedienteDeudor/item';
// import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    ExpedienteListComponent,
    ExpedienteItemComponent,
    ExpedienteNotaListComponent,
    ExpedienteNotaItemComponent,
    ExpedienteDeudorListComponent,
    ExpedienteDeudorItemComponent,
  ],
  imports: [
    CommonModule,
    RoutingModule,
    TableModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    TabsModule.forRoot(),
    // BrowserAnimationsModule,
    BsDatepickerModule.forRoot(),
  ],
  exports: [
    ExpedienteListComponent,
    ExpedienteItemComponent,
    ExpedienteNotaListComponent,
    ExpedienteNotaItemComponent,
    ExpedienteDeudorListComponent,
    ExpedienteDeudorItemComponent,
  ],
  providers: [],
})
export class ExpedienteModule {}
