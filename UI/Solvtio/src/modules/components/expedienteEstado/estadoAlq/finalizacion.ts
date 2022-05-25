import {
  Component,
  OnInit,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  Input,
  TemplateRef,
} from '@angular/core';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Observable, Subscription } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EstadoAlqFinalizacionDto, ModelDtoNombre } from 'src/models';
import { ApiService } from 'src/services/api.service';

@Component({
  selector: 'estado-alquiler-finalizacion',
  templateUrl: './finalizacion.html',
  encapsulation: ViewEncapsulation.None,
})
export class EstadoAlqFinalizacionComponent implements OnInit {
  @Input() idEstado: number = 0;

  data = new EstadoAlqFinalizacionDto();
  formData!: FormGroup;

  idTipoEstado = 79;
  motivos = new Array<ModelDtoNombre>();

  constructor(
    private fb: FormBuilder,
    private api: ApiService,
    private dialogService: DialogService
  ) {}

  private eventsSubscription: Subscription = new Subscription();
  @Input()
  events!: Observable<void>;
  ngOnInit(): void {
    console.log('EstadoAlqFinalizacionComponent');
    this.eventsSubscription = this.events.subscribe(() => this.save());
    this.createFormData();
  }
  ngOnDestroy() {
    this.eventsSubscription.unsubscribe();
  }

  async createFormData() {
    this.data = await this.api.estado.estadoAlqFinalizacionGetById(
      this.idEstado
    );

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.data).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formData = this.fb.group(controlsConfig);

    this.loadDataAux();
  }

  async loadDataAux() {
    this.motivos = await this.api.nom.getTipoEstadoMotivoByTipoEstado(
      this.idTipoEstado
    );
  }

  save(): void {
    console.log('EstadoAlqFinalizacionUpdate.save()');
    console.log(this.formData.getRawValue());
    this.api.estado
      .estadoAlqFinalizacionUpdate(this.formData.getRawValue())
      .then((x) => this.savedSuccessfull())
      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error al guardar los datos de alquiler.'
        )
      );
  }

  savedSuccessfull() {}

  // onChildChange() {
  //   this.modalRef?.hide();
  //   this.getData();
  // }
}
