import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ExpedienteSearch, PaginationFilter, PaginationPage } from 'src/models';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DtoIdNombre, KpiInfo } from '../../../models/common.model';
import { ModelDtoNombre } from '../../../models/CaracteristicaBase.model';
import { ActivatedRoute } from '@angular/router';
import { FilterBase } from 'src/models/search/baseSearch.model';

@Component({
  selector: 'page-Dashboard-kpi',
  templateUrl: './kpi.html',
  styleUrls: ['./kpi.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class DashboradKpiComponent implements OnInit {
  formGroupFilter: FormGroup = this.fb.group({});
  data: KpiInfo[] = new Array<KpiInfo>();

  tipoExpediente = new Array<ModelDtoNombre>();
  oficinas = new Array<ModelDtoNombre>();
  abogados = new Array<ModelDtoNombre>();
  idTipoExpediente = 1;

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService,
    private route: ActivatedRoute,
    private fb: FormBuilder
  ) {
    //this.createFormGroup();
  }

  ngOnInit(): void {
    this.loadDataAux();
    this.createFormGroup();
    this.getData();
  }

  async loadDataAux() {
    this.oficinas = await this.api.nom.clienteOficinaGetAll();
    this.abogados = await this.api.nom.abogadoGetAll();
    this.tipoExpediente = await this.api.nom.tipoExpedienteGetAll();
  }

  createFormGroup() {
    this.idTipoExpediente = this.route.snapshot.params['id'];
    // console.log(this.idTipoExpediente);

    // this.formGroupFilter = this.fb.group({
    //   code1: [''],
    //   code2: [''],
    //   code3: [''],
    //   idTipo1: [this.idTipoExpediente],
    //   idTipo2: [],
    //   idTipo3: [],
    //   idTipo4: [],
    //   idTipo5: [],
    //   isOnOff1: [],
    // });
    // console.log(this.formGroupFilter.getRawValue());

    let filter = new FilterBase();
    filter.idTipo1 = this.idTipoExpediente;

    const validations: any = {
      //nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(filter).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    this.formGroupFilter = this.fb.group(controlsConfig);
    console.log(this.formGroupFilter.getRawValue());
  }

  async getData() {
    let filter = new FilterBase();
    filter.idTipo1 = this.formGroupFilter.controls['idTipo1'].value;
    filter.idTipo2 = this.formGroupFilter.controls['idTipo2'].value;
    filter.idTipo3 = this.formGroupFilter.controls['idTipo3'].value;

    //console.clear();
    console.log(this.formGroupFilter.getRawValue());

    this.data = await this.api.srvApiExpediente.getDashboardKpi(filter);

    // for (let i = 0; i < 15; i++) {
    //   this.data.push(
    //     new KpiInfo({ id: i + 1, name: 'Knp Info ' + i.toString(), count: 150 })
    //   );
    //console.log ("Block statement execution no." + i);
    // }

    //console.clear();
    console.log(this.data);
    // this.expedienteSearch = await this.api.srvApiExpediente.getPaginated(
    //   this.expedienteSearch.paginationFilter
    // );
    // console.log(this.expedienteSearch);
    // console.log(this.expedienteSearch.paginationFilter.pagination);
  }
}
