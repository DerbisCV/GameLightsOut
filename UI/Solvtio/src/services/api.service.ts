import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BaseHttpService } from './base.http.service';
import { CaracteristicaBaseApiService } from './controllers/caracteristicaBase.api.service';

@Injectable({
  providedIn: 'root',
})
export class ApiService extends BaseHttpService {
  srvApiCaracteristicaBase: CaracteristicaBaseApiService;

  constructor(http: HttpClient, router: Router) {
    super(http, router);

    this.srvApiCaracteristicaBase = new CaracteristicaBaseApiService(this);
  }
}
