// import { stringFormat } from 'src/functions';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({ providedIn: 'root' })
export class NotificationsService {
  constructor(private toastr: ToastrService) {}

  success(
    title: string,
    message: string,
    ...args: any[]
  ): { onTap: Observable<any> } {
    return this.toastr.success(message, title, {
      enableHtml: true,
    });
  }

  error(
    title: string,
    message: string,
    ...args: any[]
  ): { onTap: Observable<any> } {
    return this.toastr.error(message, title, {
      enableHtml: true,
    });
  }

  info(
    title: string,
    message: string,
    ...args: any[]
  ): { onTap: Observable<any> } {
    return this.toastr.info(message, title, {
      enableHtml: true,
    });
  }

  warning(
    title: string,
    message: string,
    ...args: any[]
  ): { onTap: Observable<any> } {
    return this.toastr.warning(message, title, {
      enableHtml: true,
    });
  }

  async showRemoveElementsSuccessQuantity(qty: number) {
    this.success('Remove', 'RemovedElementsQuantity', qty);
  }

  async showAddElementSuccess() {
    this.success('AddNew', 'ElementAddSuccess');
  }

  async showUpdateElementSuccess() {
    this.success('Edit', 'ElementUpdateSuccess');
  }

  async showAddElementError() {
    this.error('AddNew', 'ElementAddError');
  }

  async showUpdateElementError() {
    this.error('Edit', 'ElementUpdateError');
  }
}
