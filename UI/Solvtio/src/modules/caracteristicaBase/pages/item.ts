import {
  Component,
  ElementRef,
  OnInit,
  ViewEncapsulation,
} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { CaracteristicaBase, CaracteristicaBaseSearch } from 'src/models';
import { NotificationsService } from 'src/services/notifications.service';
import { ApiService } from '../../../services/api.service';
import { DialogService } from '../../../services/dialog/dialog.service';

@Component({
  selector: 'page-caracteristicaBase-list',
  templateUrl: './item.html',
  encapsulation: ViewEncapsulation.None,
})
export class CaracteristicaBaseItemComponent implements OnInit {
  caracteristicaBase = new CaracteristicaBase();
  formData!: FormGroup;

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
    // console.log('ngOnInit id=' + this.route.snapshot.params['id']);
    // const id = this.route.snapshot.params['id'];
    // this.caracteristicaBase = !!id
    //   ? await this.api.srvApiCaracteristicaBase.getById(id)
    //   : new CaracteristicaBase();
  }

  async createFormData() {
    const id = this.route.snapshot.params['id'];
    this.caracteristicaBase = !!id
      ? await this.api.srvApiCaracteristicaBase.getById(id)
      : new CaracteristicaBase();

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.caracteristicaBase).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formData = this.fb.group(controlsConfig);
  }

  saveData() {
    console.log(this.formData.getRawValue());
    this.api.srvApiCaracteristicaBase
      .udpate(this.formData.getRawValue())
      .then((x) =>
        this.notificationsService.success('', 'Datos guardados correctamente!')
      )
      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error, los datos no han podido ser guardados.'
        )
      );
  }
}
