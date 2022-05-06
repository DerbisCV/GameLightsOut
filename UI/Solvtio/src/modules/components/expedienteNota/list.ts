import {
  Component,
  OnInit,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  Input,
} from '@angular/core';
import { ExpedienteNotaDto } from 'src/models';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';

@Component({
  selector: 'expediente-nota-list',
  templateUrl: './list.html',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ExpedienteNotaListComponent implements OnInit {
  @Input() idExpediente: number = 0;

  notas = new Array<ExpedienteNotaDto>();

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService
  ) {
    // console.log('component expediente-nota-list - constructor');
    // console.log(this.idExpediente);
    // this.getData();
  }

  ngOnInit(): void {
    console.log('component expediente-nota-list - ngOnInit - notas:');
    // console.log(this.idExpediente);
    this.getData();
    console.log(this.notas);
  }

  async getData() {
    this.notas = await this.api.srvApiExpediente.getNotas(this.idExpediente);
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
}
