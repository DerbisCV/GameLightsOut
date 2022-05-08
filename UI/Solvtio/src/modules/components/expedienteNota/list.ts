import {
  Component,
  OnInit,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  Input,
  ChangeDetectorRef,
  TemplateRef,
} from '@angular/core';
import { ExpedienteNotaDto } from 'src/models';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { BsModalRef, BsModalService, ModalOptions } from 'ngx-bootstrap/modal';

@Component({
  selector: 'expediente-nota-list',
  templateUrl: './list.html',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ExpedienteNotaListComponent implements OnInit {
  @Input() idExpediente: number = 0;

  notas: Array<ExpedienteNotaDto> = [];

  modalRef?: BsModalRef;
  idToEdit: number = -1;

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService,
    private cdr: ChangeDetectorRef,
    private modalService: BsModalService
  ) {}

  ngOnInit(): void {
    this.getData();
  }

  async getData() {
    this.notas = await this.api.srvApiExpediente.getNotas(this.idExpediente);
    // console.table(this.notas);
    this.cdr.detectChanges();
  }

  remove(id: number): void {
    this.api.srvApiExpediente
      .notaDelete(id)
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
