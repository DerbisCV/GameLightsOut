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
import { ExpedienteEstadoDto, ModelDtoNombre } from 'src/models';
import { NotificationsService } from 'src/services/notifications.service';
import { ApiService } from '../../../services/api.service';
import { DialogService } from '../../../services/dialog/dialog.service';
import { DtoIdNombre, PersonaDto } from '../../../models/common.model';

@Component({
  selector: 'expediente-estado-item',
  templateUrl: './item.html',
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteEstadoItemComponent implements OnInit {
  @Input() idExpedienteEstado: number = 0;
  @Input() idExpediente: number = 0;

  @Output() childChanged = new EventEmitter<string>();

  estado = new ExpedienteEstadoDto();
  // persona = new PersonaDto();
  formData!: FormGroup;
  tipos = new Array<ModelDtoNombre>();
  // provincias = new Array<ModelDtoNombre>();
  // municipios = new Array<ModelDtoNombre>();
  public title = 'Nuevo Estado';
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
    if (this.idExpedienteEstado > 0) {
      this.title = 'Editar Estado';
      this.estado = await this.api.srvApiExpediente.getEstadoById(
        this.idExpedienteEstado
      );
    } else this.estado.idExpediente = this.idExpediente;

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.estado).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formData = this.fb.group(controlsConfig);
    this.tipos = await this.api.srvApiNomenclador.tipoEstadoGetAllByExpediente(
      this.idExpediente
    );
    // this.provincias = await this.api.srvApiNomenclador.provinciasGetAll();
    // if (this.estado.idProvincia > 0)
    //   this.municipios = await this.api.srvApiNomenclador.municipiosByProvincia(
    //     this.estado.idProvincia
    //   );
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
      this.idExpedienteEstado == 0
        ? this.api.srvApiExpediente.estadoAdd(
            this.idExpediente,
            this.formData.getRawValue()
          )
        : this.api.srvApiExpediente.estadoUdpate(this.formData.getRawValue());

    resultPromise
      .then((x) => this.saveDataSuccessful())
      .catch((x) => this.saveDataError(x));

    //   this.dialogService.alert(
    //     'Error',
    //     'Ha ocurrido un error, los datos no han podido ser guardados.'
    //   )
    // );
  }

  saveDataSuccessful() {
    this.notificationsService.success('', 'Datos guardados correctamente!');
    this.childChanged.emit('');
  }
  saveDataError(x: any) {
    this.notificationsService.error(
      'Error',
      'Ha ocurrido un error, los datos no han podido ser guardados.'
    );
    //this.childChanged.emit('');
    console.clear();
    console.log(x);
    console.log(x.error);
  }
}
