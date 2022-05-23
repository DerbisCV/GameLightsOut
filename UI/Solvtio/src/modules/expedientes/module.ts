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
import { ExpedienteEstadoItemComponent } from '../components/expedienteEstado/item';
import { ExpedienteEstadoListComponent } from '../components/expedienteEstado/list';
import { ExpedienteEstadoFichaComponent } from '../components/expedienteEstado/ficha';
import { ExpedienteAlquilerListComponent } from './pages/alquiler';
import { ExpedienteHipotecarioListComponent } from './pages/hipotecario';
import { ExpedienteDataHipotecarioComponent } from './expediente-ByType/expHipotecario';
import { ExpedienteDataPenalComponent } from './expediente-ByType/expPenal';
import { ExpedienteDataAlquilerComponent } from './expediente-ByType/expAlquiler';
// import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    ExpedienteListComponent,
    ExpedienteItemComponent,
    ExpedienteNotaListComponent,
    ExpedienteNotaItemComponent,
    ExpedienteDeudorListComponent,
    ExpedienteDeudorItemComponent,
    ExpedienteEstadoListComponent,
    ExpedienteEstadoItemComponent,
    ExpedienteEstadoFichaComponent,
    ExpedienteAlquilerListComponent,
    ExpedienteHipotecarioListComponent,
    ExpedienteDataHipotecarioComponent,
    ExpedienteDataPenalComponent,
    ExpedienteDataAlquilerComponent,
  ],
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
  exports: [
    ExpedienteListComponent,
    ExpedienteItemComponent,
    ExpedienteNotaListComponent,
    ExpedienteNotaItemComponent,
    ExpedienteDeudorListComponent,
    ExpedienteDeudorItemComponent,
    ExpedienteEstadoListComponent,
    ExpedienteEstadoItemComponent,
    ExpedienteEstadoFichaComponent,
    ExpedienteAlquilerListComponent,
    ExpedienteHipotecarioListComponent,
    ExpedienteDataHipotecarioComponent,
    ExpedienteDataPenalComponent,
    ExpedienteDataAlquilerComponent,
  ],
  providers: [],
})
export class ExpedienteModule {}
