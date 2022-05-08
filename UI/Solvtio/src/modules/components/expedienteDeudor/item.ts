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
import { DtoIdNombre } from '../../../models/common.model';

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
  formData!: FormGroup;
  tipos = new Array<ModelDtoNombre>();
  public title = 'Nuevo Deudor';

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
    console.clear();
    console.log(this.formData.getRawValue());

    //this.tipos = await this.api.srvApiNomenclador.tipoDeudorGetAll();
  }

  saveData() {
    console.clear();
    console.log(this.formData.getRawValue());
    console.log(this.idExpediente);

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
