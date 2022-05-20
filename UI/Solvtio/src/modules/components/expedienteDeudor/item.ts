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
import { ExpedienteDeudorDto, ModelDtoNombre } from 'src/models';
import { NotificationsService } from 'src/services/notifications.service';
import { ApiService } from '../../../services/api.service';
import { DialogService } from '../../../services/dialog/dialog.service';
import { DtoIdNombre, PersonaDto } from '../../../models/common.model';

@Component({
  selector: 'expediente-deudor-item',
  templateUrl: './item.html',
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteDeudorItemComponent implements OnInit {
  @Input() idExpedienteDeudor: number = 0;
  @Input() idExpediente: number = 0;

  @Output() childChanged = new EventEmitter<string>();

  deudor = new ExpedienteDeudorDto();
  persona = new PersonaDto();
  formData!: FormGroup;
  tipos = new Array<ModelDtoNombre>();
  provincias = new Array<ModelDtoNombre>();
  municipios = new Array<ModelDtoNombre>();
  public title = 'Nuevo Deudor';
  idProvincia = 0;

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
    if (this.idExpedienteDeudor > 0) {
      this.title = 'Editar Deudor';
      this.deudor = await this.api.srvApiExpediente.getDeudorById(
        this.idExpedienteDeudor
      );
    } else this.deudor.idExpediente = this.idExpediente;

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.deudor).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formData = this.fb.group(controlsConfig);
    // console.clear();
    // console.log(this.formData.getRawValue());

    this.tipos = await this.api.srvApiNomenclador.tipoDeudorGetAll();
    this.provincias = await this.api.srvApiNomenclador.provinciasGetAll();
    if (this.deudor.idProvincia > 0)
      this.municipios = await this.api.srvApiNomenclador.municipiosByProvincia(
        this.deudor.idProvincia
      );
    // console.table(this.tipos);
  }

  async onChangeProvincia(provinciaValue: number) {
    provinciaValue = this.formData.controls['idProvincia'].value;

    // console.log(provinciaValue);
    // console.log(this.formData.getRawValue());
    this.municipios = await this.api.srvApiNomenclador.municipiosByProvincia(
      provinciaValue
    );
    // console.table(this.municipios);
  }

  refreshFormData() {
    if (this.deudor.persona.idPersona <= 0) {
      // this.formData.controls['persona'] = n
      // this.formData.controls.PersonaDto.setValue('abc');
      // personaNoDocumento: string | undefined = '';
      // personaNombre: string | undefined = '';
      // personaApellidos: string | undefined = '';
      // personaTelefono: string | undefined = '';
      // personaEmail: string | undefined = '';
      // personaIdTipoIdentidad: number | undefined = 0;
    }
  }

  saveData() {
    console.clear();
    console.log(this.formData.getRawValue());
    console.log(this.idExpediente);
    console.log(this.persona.noDocumento);

    this.refreshFormData();

    let resultPromise =
      this.idExpedienteDeudor == 0
        ? this.api.srvApiExpediente.deudorAdd(
            this.idExpediente,
            this.formData.getRawValue()
          )
        : this.api.srvApiExpediente.deudorUdpate(this.formData.getRawValue());

    resultPromise
      .then((x) => this.saveDataSuccessful())
      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error, los datos no han podido ser guardados.'
        )
      );
  }

  saveDataSuccessful() {
    this.notificationsService.success('', 'Datos guardados correctamente!');
    this.childChanged.emit('');
  }
}
