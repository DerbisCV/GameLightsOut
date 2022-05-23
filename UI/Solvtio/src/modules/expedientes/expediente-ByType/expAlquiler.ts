import {
  Component,
  OnInit,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  Input,
  TemplateRef,
} from '@angular/core';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Observable, Subscription } from 'rxjs';
import { AlqExpedienteDto } from '../../../models/Expediente.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'expediente-data-alquiler',
  templateUrl: './expAlquiler.html',
  styleUrls: ['./styles.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteDataAlquilerComponent implements OnInit {
  @Input() idExpediente: number = 0;

  data = new AlqExpedienteDto();
  formData!: FormGroup;

  // dataRows = new Array<ExpedienteEstadoDto>();
  // data = new Array<any>();
  // modalRef?: BsModalRef;
  // idToEdit: number = -1;

  constructor(
    private fb: FormBuilder,
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService,
    private modalService: BsModalService
  ) {}

  private eventsSubscription: Subscription = new Subscription();
  @Input()
  events!: Observable<void>;
  ngOnInit(): void {
    this.eventsSubscription = this.events.subscribe(() => this.save());
    this.createFormData();
  }
  ngOnDestroy() {
    this.eventsSubscription.unsubscribe();
  }

  async createFormData() {
    this.data = await this.api.alq.getById(this.idExpediente);

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.data).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formData = this.fb.group(controlsConfig);

    // console.log(this.expediente);
    // console.log(this.formData);
  }

  save(): void {
    console.log('ExpedienteDataAlquilerComponent.save()');
    console.log(this.formData.getRawValue());
    this.api.alq
      .udpate(this.formData.getRawValue())
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
