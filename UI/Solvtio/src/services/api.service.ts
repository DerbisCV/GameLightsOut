import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BaseHttpService } from './base.http.service';
import { AlquilerApiService } from './controllers/alquiler.api.service';
import { CaracteristicaBaseApiService } from './controllers/caracteristicaBase.api.service';
import { EstadoApiService } from './controllers/estado.api.service';
import { ExpedienteApiService } from './controllers/expediente.api.service';
import { NomencladorApiService } from './controllers/nomenclador.api.service';

@Injectable({
  providedIn: 'root',
})
export class ApiService extends BaseHttpService {
  srvApiCaracteristicaBase: CaracteristicaBaseApiService;
  srvApiExpediente: ExpedienteApiService;
  alq: AlquilerApiService;
  srvApiNomenclador: NomencladorApiService;

  nom: NomencladorApiService;
  exp: ExpedienteApiService;
  estado: EstadoApiService;

  constructor(http: HttpClient, router: Router) {
    super(http, router);

    this.srvApiCaracteristicaBase = new CaracteristicaBaseApiService(this);
    this.srvApiNomenclador = new NomencladorApiService(this);
    this.srvApiExpediente = new ExpedienteApiService(this);
    this.alq = new AlquilerApiService(this);
    this.estado = new EstadoApiService(this);

    this.exp = this.srvApiExpediente;
    this.nom = this.srvApiNomenclador;
  }
}
