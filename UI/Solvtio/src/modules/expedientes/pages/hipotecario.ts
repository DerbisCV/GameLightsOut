import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ExpedienteSearch, PaginationFilter, PaginationPage } from 'src/models';
import { ApiService } from '../../../services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DtoIdNombre } from '../../../models/common.model';
import { ModelDtoNombre } from '../../../models/CaracteristicaBase.model';

@Component({
  selector: 'page-Expediente-hipotecario',
  templateUrl: './hipotecario.html',
  styleUrls: ['./list.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class ExpedienteHipotecarioListComponent implements OnInit {
  formGroupFilter: FormGroup = this.fb.group({});
  expedienteSearch: ExpedienteSearch = new ExpedienteSearch();

  oficinas = new Array<ModelDtoNombre>();
  carteras = new Array<ModelDtoNombre>();
  procuradores = new Array<ModelDtoNombre>();
  tipoArea = new Array<ModelDtoNombre>();

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService,
    private fb: FormBuilder
  ) {
    this.createFormGroup();
  }

  ngOnInit(): void {
    this.getPaginatedData();
    this.loadDataAux();
  }

  async loadDataAux() {
    this.oficinas = await this.api.nom.clienteOficinaGetAll();
    this.procuradores = await this.api.nom.procuradorGetAll();
    this.tipoArea = await this.api.nom.tipoAreaGetAll();
    this.carteras = await this.api.nom.carteraGetAll();
  }

  createFormGroup() {
    this.expedienteSearch = new ExpedienteSearch({
      paginationFilter: new PaginationFilter(),
    });

    this.formGroupFilter = this.fb.group({
      code1: [''],
      code2: [''],
      code3: [''],
      idTipo1: [],
      idTipo2: [],
      idTipo3: [],
      idTipo4: [1],
      idTipo5: [],
      isOnOff1: [],
    });
  }

  goToPage(noPage: number) {
    this.expedienteSearch.paginationFilter.pagination.pageNumber = noPage;
    this.getPaginatedData();
  }

  async filtrar() {
    //console.log(this.formGroupFilter.getRawValue());

    this.expedienteSearch.paginationFilter.pagination.pageNumber = 1;
    let filter = this.expedienteSearch.paginationFilter.filter;
    filter.code1 = this.formGroupFilter.controls['code1'].value;
    filter.code2 = this.formGroupFilter.controls['code2'].value;
    filter.code3 = this.formGroupFilter.controls['code3'].value;
    filter.idTipo1 = this.formGroupFilter.controls['idTipo1'].value;
    filter.idTipo2 = this.formGroupFilter.controls['idTipo2'].value;
    filter.idTipo3 = this.formGroupFilter.controls['idTipo3'].value;
    //this.expedienteSearch.paginationFilter.filter.idTipo4 = 1;
    filter.idTipo5 = this.formGroupFilter.controls['idTipo5'].value;
    filter.isOnOff1 = this.formGroupFilter.controls['isOnOff1'].value;

    this.getPaginatedData();
  }

  async getPaginatedData() {
    this.expedienteSearch.paginationFilter.filter.idTipo4 = 1;

    // console.clear();
    // console.log(this.expedienteSearch.paginationFilter);
    this.expedienteSearch = await this.api.srvApiExpediente.getPaginated(
      this.expedienteSearch.paginationFilter
    );
    // console.log(this.expedienteSearch);
  }

  getPaginationBtnToShow() {
    var result = new Array<PaginationPage>();

    let firstPage = new PaginationPage({
      noPage: 1,
      isEnabled:
        this.expedienteSearch.paginationFilter.pagination.pageNumber != 1,
    });
    result.push(firstPage);
    if (this.expedienteSearch.paginationFilter.pagination.totalPages > 1) {
      for (let i = 2; i < 9; i++) {
        if (this.expedienteSearch.paginationFilter.pagination.totalPages >= i) {
          let newPage = new PaginationPage();
          newPage.noPage = i;
          newPage.isEnabled =
            newPage.noPage !=
            this.expedienteSearch.paginationFilter.pagination.pageNumber;
          result.push(newPage);
        }
      }
    }
    if (this.expedienteSearch.paginationFilter.pagination.totalPages > 9) {
      let lastPage = new PaginationPage({
        noPage: this.expedienteSearch.paginationFilter.pagination.totalPages,
        isEnabled:
          this.expedienteSearch.paginationFilter.pagination.totalPages !=
          this.expedienteSearch.paginationFilter.pagination.pageNumber,
      });
      result.push(lastPage);
    }

    return result;
  }

  remove(id: number): void {
    this.api.srvApiCaracteristicaBase
      .delete(id.toString())
      .then((x) => {
        this.notificationsService.success(
          '',
          'Registro eliminado correctamente.'
        );
        this.getPaginatedData();
      })
      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error, el registro no han podido ser eliminado.'
        )
      );
  }
}
