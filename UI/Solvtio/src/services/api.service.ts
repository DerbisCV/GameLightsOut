import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BaseHttpService } from './base.http.service';
import { CaracteristicaBaseApiService } from './controllers/caracteristicaBase.api.service';
import { ExpedienteApiService } from './controllers/expediente.api.service';
import { NomencladorApiService } from './controllers/nomenclador.api.service';

@Injectable({
  providedIn: 'root',
})
export class ApiService extends BaseHttpService {
  srvApiCaracteristicaBase: CaracteristicaBaseApiService;
  srvApiExpediente: ExpedienteApiService;
  srvApiNomenclador: NomencladorApiService;

  exp: ExpedienteApiService;
  nom: NomencladorApiService;

  constructor(http: HttpClient, router: Router) {
    super(http, router);

    this.srvApiCaracteristicaBase = new CaracteristicaBaseApiService(this);
    this.srvApiExpediente = new ExpedienteApiService(this);
    this.srvApiNomenclador = new NomencladorApiService(this);

    this.exp = this.srvApiExpediente;
    this.nom = this.srvApiNomenclador;
  }
}
