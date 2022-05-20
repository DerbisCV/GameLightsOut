import {
  Component,
  OnInit,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  Input,
  TemplateRef,
} from '@angular/core';
import { ExpedienteDeudorDto } from 'src/models';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'expediente-deudor-list',
  templateUrl: './list.html',
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteDeudorListComponent implements OnInit {
  @Input() idExpediente: number = 0;

  deudores = new Array<ExpedienteDeudorDto>();
  data = new Array<any>();
  modalRef?: BsModalRef;
  idToEdit: number = -1;

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService,
    private modalService: BsModalService
  ) {
    // console.log('component - constructor');
    // console.log(this.idExpediente);
    // this.getData();
  }

  ngOnInit(): void {
    // console.log('component - ngOnInit');
    // console.log(this.idExpediente);
    this.getData();
    // console.log(this.deudores);
  }

  async getData() {
    this.deudores = await this.api.srvApiExpediente.getDeudores(
      this.idExpediente
    );

    await this.api.srvApiExpediente
      .getDeudores(this.idExpediente)
      .then((x) => (this.data = x));
    // console.log('data');
    // console.log(this.data);

    this.deudores = Object.assign(this.deudores, this.data);
    // console.log('deudores:');
    // console.log(this.deudores);
    //   return Object.assign(person, {
    //     employeeId: id
    // });
  }

  remove(id: number): void {
    // this.api.srvApiCaracteristicaBase
    //   .delete(id.toString())
    //   .then((x) => {
    //     this.notificationsService.success(
    //       '',
    //       'Registro eliminado correctamente.'
    //     );
    //     this.getPaginatedData();
    //   })
    //   .catch((x) =>
    //     this.dialogService.alert(
    //       'Error',
    //       'Ha ocurrido un error, el registro no han podido ser eliminado.'
    //     )
    //   );
  }

  openModalItemNew(template: TemplateRef<any>) {
    this.openModalItemEdit(template, 0);
  }
  openModalItemEdit(template: TemplateRef<any>, idExpedienteNota: number) {
    this.idToEdit = idExpedienteNota;

    this.modalRef = this.modalService.show(
      template,
      Object.assign({}, { class: 'gray modal-lg' })
    );
  }
  onChildChange() {
    this.modalRef?.hide();
    this.getData();
  }
}
