import {
  Component,
  ElementRef,
  EventEmitter,
  Input,
  OnInit,
  Output,
  ViewEncapsulation,
} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import {
  Expediente,
  ExpedienteEstadoDto,
  ExpedienteNotaDto,
  ModelDtoNombre,
} from 'src/models';
import { NotificationsService } from 'src/services/notifications.service';
import { ApiService } from '../../../services/api.service';
import { DialogService } from '../../../services/dialog/dialog.service';
import { DtoIdNombre, PersonaDto } from '../../../models/common.model';

@Component({
  selector: 'expediente-estado-ficha',
  templateUrl: './ficha.html',
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteEstadoFichaComponent implements OnInit {
  @Input() idExpedienteEstado: number = 0;
  @Input() idExpediente: number = 0;

  @Output() childChanged = new EventEmitter<string>();

  estado = new ExpedienteEstadoDto();
  expediente = new Expediente();
  formData!: FormGroup;
  tipos = new Array<ModelDtoNombre>();
  tipoSubFaseByEstado = new Array<DtoIdNombre>();
  tipoIncidenciaByEstado = new Array<DtoIdNombre>();
  tipoSubFaseCliente = new Array<ModelDtoNombre>();
  notas: Array<ExpedienteNotaDto> = [];

  public title = 'Editar Estado';
  // idProvincia = 0;

  constructor(
    private fb: FormBuilder,
    private api: ApiService,
    private route: ActivatedRoute,
    public elementRef: ElementRef,
    private dialogService: DialogService,
    private notificationsService: NotificationsService
  ) {
    this.createFormData();
  }

  async ngOnInit() {
    this.createFormData();
  }

  async createFormData() {
    this.idExpedienteEstado = this.route.snapshot.params['id'];

    console.log(this.idExpedienteEstado);

    this.estado = await this.api.srvApiExpediente.getEstadoById(
      this.idExpedienteEstado
    );
    // console.log(this.estado);
    this.expediente = await this.api.srvApiExpediente.getById(
      this.estado.idExpediente.toString()
    );
    // console.log(this.expediente);
    // if (this.idExpedienteEstado > 0) {
    //
    // } else
    this.estado.idExpediente = this.idExpediente;
    this.title =
      'Nº Exp: ' +
      this.expediente.noExpediente +
      ' - ' +
      this.estado.tipoEstado.nombre;

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.estado).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formData = this.fb.group(controlsConfig);

    this.tipoSubFaseByEstado =
      await this.api.srvApiNomenclador.getTipoSubFaseByEstado(
        this.estado.idTipoEstado
      );
    this.tipoIncidenciaByEstado =
      await this.api.srvApiNomenclador.getTipoIncidenciaByEstado(
        this.estado.idTipoEstado
      );
    this.tipoSubFaseCliente =
      await this.api.srvApiNomenclador.getCaracteristicaBaseByGrupo(
        'Estado-Subfase-Cliente',
        true
      );
    this.notas = await this.api.exp.getNotasByEstado(this.idExpedienteEstado);

    //Html.DcvSelectBootstrapCaracteristicaBaseByGrupo(, Model.IdTipoSubFaseCliente, "ExpedienteEstado.IdTipoSubFaseCliente", true, true, true))
  }

  // async onChangeProvincia(provinciaValue: number) {
  //   provinciaValue = this.formData.controls['idProvincia'].value;

  //   // console.log(provinciaValue);
  //   // console.log(this.formData.getRawValue());
  //   this.municipios = await this.api.srvApiNomenclador.municipiosByProvincia(
  //     provinciaValue
  //   );
  //   // console.table(this.municipios);
  // }

  saveData() {
    console.clear();
    console.log(this.formData.getRawValue());
    console.log(this.idExpediente);

    //this.refreshFormData();

    let resultPromise =
      // this.idExpedienteEstado == 0
      //   ? this.api.srvApiExpediente.estadoAdd(
      //       this.idExpediente,
      //       this.formData.getRawValue()
      //     )
      //   :
      this.api.srvApiExpediente.estadoUdpate(this.formData.getRawValue());

    resultPromise
      .then((x) => this.saveDataSuccessful())
      .catch((x) => this.saveDataError());

    //   this.dialogService.alert(
    //     'Error',
    //     'Ha ocurrido un error, los datos no han podido ser guardados.'
    //   )
    // );
  }

  saveDataSuccessful() {
    this.notificationsService.success('', 'Datos guardados correctamente!');
    //this.childChanged.emit('');
  }
  saveDataError() {
    this.notificationsService.error(
      'Error',
      'Ha ocurrido un error, los datos no han podido ser guardados.'
    );
    //this.childChanged.emit('');
    console.clear();
    // console.log(x);
    console.log('x.error');
  }
}
