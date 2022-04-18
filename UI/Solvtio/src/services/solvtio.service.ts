import { Injectable, NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rx';
import { CaracteristicaBase } from '../models/CaracteristicaBase.model';

@Injectable({
  providedIn: 'root',
})
export class SolvtioService {
  baseUrl = 'http://localhost:40274/api/';

  constructor(private http: HttpClient) {}

  getAllCaracteristicasBase() {
    return this.http.get<CaracteristicaBase[]>(
      'http://localhost:40274/api/CaracteristicaBase'
    );
  }

  //Get all CaracteristicasBase
  // getAllCaracteristicasBase(): Observable<CaracteristicasBase[]> {
  //   // let url = this.baseUrl + '';
  //   // var result = this.http.get<CaracteristicasBase[]>(
  //   //   'https://localhost:40274/api/CaracteristicaBase'
  //   // );
  //   // return result;
  //   return this.http.get<CaracteristicasBase[]>(
  //     'http://localhost:40274/api/CaracteristicaBase'
  //   );
  //   // .subscribe((response) => {
  //   //   console.log(response);
  //   // })
  // }
}
