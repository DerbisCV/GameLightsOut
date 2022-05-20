import { HasEnvironment } from './../environments/hasEnvironment.class';
import { Injectable } from '@angular/core';
import {
  HttpClient,
  HttpParams,
  HttpResponse,
  HttpHeaders,
} from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable()
export abstract class BaseHttpService extends HasEnvironment {
  public headers = new HttpHeaders()
    .set('Access-Control-Allow-Headers', '*')
    .set('Access-Control-Allow-Methods', '*')
    .set('Access-Control-Allow-Origin', '*');

  constructor(
    public http: HttpClient,

    public router: Router
  ) {
    super();
  }

  public send_loading(loading: boolean = true): void {}

  private get_params(data?: any): HttpParams | null {
    if (!data) return null;
    let params = new HttpParams();
    Object.keys(data).forEach((k) => {
      params.set(k, data[k]);
    });
    return params;
  }

  public post<T>(
    url: string,
    data: any,
    show_loading: boolean = true
  ): Promise<T> {
    if (!!show_loading) this.send_loading(true);

    //var option = { headers: { 'Content-Type': undefined } };

    return new Promise((resolve, reject) => {
      this.http.post(url, data).subscribe(
        (d) => {
          if (!!show_loading) this.send_loading(false);
          resolve(d as T);
        },
        (err) => {
          if (err.status == 200) return resolve({} as T);
          this.get_reject(reject, err);
        }
      );
    });
  }

  public put<T>(
    url: string,
    data: any,
    show_loading: boolean = true
  ): Promise<T> {
    if (!!show_loading) this.send_loading(true);
    return new Promise((resolve, reject) => {
      this.http.put(url, data).subscribe(
        (d) => {
          if (!!show_loading) this.send_loading(false);
          resolve(d as T);
        },
        (err) => {
          if (err.status == 200) return resolve({} as T);
          this.get_reject(reject, err);
        }
      );
    });
  }

  public get<T>(
    url: string,
    data?: any,
    show_loading: boolean = true
  ): Promise<T> {
    !!show_loading && this.send_loading(true);
    return new Promise((resolve, reject) => {
      this.http.get(url, { params: data }).subscribe(
        (d) => {
          !!show_loading && this.send_loading(false);
          resolve(d as T);
        },
        (err) => {
          if (err.status == 200) return resolve({} as T);
          this.get_reject(reject, err);
        }
      );
    });
  }

  public patch<T>(
    url: string,
    data?: any,
    show_loading: boolean = true
  ): Promise<T> {
    if (!!show_loading) this.send_loading(true);
    return new Promise((resolve, reject) => {
      this.http.patch(url, data, { headers: this.headers }).subscribe(
        (d) => {
          if (!!show_loading) this.send_loading(false);
          resolve(d as T);
        },
        (err) => {
          if (err.status == 200) return resolve({} as T);
          this.get_reject(reject, err);
        }
      );
    });
  }

  public delete<T>(
    url: string,
    observeResponde?: any,
    show_loading: boolean = true
  ): Promise<any> {
    if (!!show_loading) this.send_loading(true);
    return new Promise((resolve, reject) => {
      this.http.delete(url, observeResponde).subscribe(
        (d) => {
          if (!!show_loading) this.send_loading(false);
          resolve(d);
        },
        (err) => this.get_reject(reject, err)
      );
    });
  }

  private get_reject(reject: any, ex: any) {
    throw ex;
  }
}
