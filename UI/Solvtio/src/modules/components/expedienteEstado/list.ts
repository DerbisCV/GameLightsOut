import {
  Component,
  OnInit,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  Input,
  TemplateRef,
} from '@angular/core';
import { ExpedienteEstadoDto } from 'src/models';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'expediente-estado-list',
  templateUrl: './list.html',
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteEstadoListComponent implements OnInit {
  @Input() idExpediente: number = 0;

  dataRows = new Array<ExpedienteEstadoDto>();
  // data = new Array<any>();
  modalRef?: BsModalRef;
  idToEdit: number = -1;

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService,
    private modalService: BsModalService
  ) {}

  ngOnInit(): void {
    this.getData();
  }

  async getData() {
    this.dataRows = await this.api.srvApiExpediente.getEstados(
      this.idExpediente
    );

    // await this.api.srvApiExpediente
    //   .getEstadoes(this.idExpediente)
    //   .then((x) => (this.data = x));

    // this.deudores = Object.assign(this.deudores, this.data);
  }

  remove(id: number): void {
    this.api.srvApiExpediente
      .estadoDelete(id)
      .then((x) => {
        this.notificationsService.success(
          '',
          'Registro eliminado correctamente.'
        );
        this.getData();
      })
      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error, el registro no han podido ser eliminado.'
        )
      );
  }

  openModalItemNew(template: TemplateRef<any>) {
    this.openModalItemEdit(template, 0);
  }
  openModalItemEdit(template: TemplateRef<any>, idToEdit: number) {
    this.idToEdit = idToEdit;

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
