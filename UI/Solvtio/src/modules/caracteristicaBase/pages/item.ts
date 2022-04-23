import {
  Component,
  ElementRef,
  OnInit,
  ViewEncapsulation,
} from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { CaracteristicaBase, CaracteristicaBaseSearch } from 'src/models';
import { ApiService } from '../../../services/api.service';

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
    public elementRef: ElementRef
  ) {
    console.log('constructor id=' + this.route.snapshot.params['id']);
    this.createFormData();
  }

  async ngOnInit() {
    console.log('ngOnInit id=' + this.route.snapshot.params['id']);
    const id = this.route.snapshot.params['id'];
    this.caracteristicaBase = !!id
      ? await this.api.srvApiCaracteristicaBase.getById(id)
      : new CaracteristicaBase();
  }

  async createFormData() {
    const id = this.route.snapshot.params['id'];
    this.caracteristicaBase = !!id
      ? await this.api.srvApiCaracteristicaBase.getById(id)
      : new CaracteristicaBase();

    // let controlsConfig = {
    //   nombre: [this.caracteristicaBase.nombre],
    //   apellidos: [''],
    // };
    let controlsConfig = this.caracteristicaBase;
    this.formData = this.fb.group(controlsConfig);
  }

  saveData() {
    console.log(this.formData);
  }
}
