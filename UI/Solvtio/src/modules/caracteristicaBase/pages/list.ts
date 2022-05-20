import {
  Component,
  OnInit,
  TemplateRef,
  ViewChild,
  ViewEncapsulation,
  ChangeDetectionStrategy,
  ChangeDetectorRef,
} from '@angular/core';
import { CaracteristicaBaseSearch } from 'src/models';
import { ApiService } from '../../../services/api.service';
// import { DefaultConfig } from 'ngx-easy-table';
import { CaracteristicaBase } from '../../../models/CaracteristicaBase.model';

// import { ChangeDetectionStrategy, Component, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { Columns, Config, DefaultConfig } from 'ngx-easy-table';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';
import { ActivatedRoute } from '@angular/router';

// import { DataTable } from 'simple-datatables';

@Component({
  selector: 'page-caracteristicaBase-list',
  templateUrl: './list.html',
  styleUrls: ['./list.scss'],
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CaracteristicaBaseListComponent implements OnInit {
  @ViewChild('actionTpl') actionTpl!: TemplateRef<any>;
  @ViewChild('tplFechaAlta') tplFechaAlta!: TemplateRef<any>;

  caracteristicaBaseSearch: CaracteristicaBaseSearch =
    new CaracteristicaBaseSearch();
  configuration = { ...DefaultConfig };
  public columns = [
    { key: 'nombre', title: 'Nombre' },
    { key: 'grupo', title: 'Grupo' },
    { key: 'orden', title: 'Orden' },
    { key: 'activo', title: 'Activo' },
    { key: 'fechaAlta', title: 'F.Alta', cellTemplate: this.tplFechaAlta },
    {
      key: 'id',
      title: 'Acciones',
      cellTemplate: this.actionTpl,
      orderEnabled: false,
      searchEnabled: false,
    },
  ];

  grupo: string = '';
  public data: CaracteristicaBase[] = [];

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private cdr: ChangeDetectorRef,
    private route: ActivatedRoute,
    private notificationsService: NotificationsService
  ) {
    //this.configTableColumns();
  }

  ngOnInit(): void {
    this.getAllCaracteristicasBase();

    this.configuration = { ...DefaultConfig };
    this.configuration.searchEnabled = true;
    this.configuration.paginationMaxSize = 15;

    // const dataTable = new DataTable('#dataTableExample');
  }

  async getAllCaracteristicasBase() {
    this.grupo = this.route.snapshot.params['id'];

    console.clear();
    console.log(this.grupo);

    if (this.grupo) {
      this.caracteristicaBaseSearch.result =
        await this.api.srvApiCaracteristicaBase.getByGrup(this.grupo);
    } else {
      this.caracteristicaBaseSearch =
        await this.api.srvApiCaracteristicaBase.get(
          new CaracteristicaBaseSearch()
        );
    }
    this.data = this.caracteristicaBaseSearch.result;

    this.configTableColumns();
    this.cdr.detectChanges();
  }

  configTableColumns() {
    this.columns = [
      { key: 'nombre', title: 'Nombre' },
      { key: 'grupo', title: 'Grupo' },
      { key: 'orden', title: 'Orden' },
      { key: 'activo', title: 'Activo' },
      { key: 'fechaAlta', title: 'F.Alta', cellTemplate: this.tplFechaAlta },
      {
        key: 'id',
        title: '',
        cellTemplate: this.actionTpl,
        orderEnabled: false,
        searchEnabled: false,
      },
    ];
  }

  remove(id: number): void {
    this.api.srvApiCaracteristicaBase
      .delete(id.toString())
      .then((x) => {
        this.notificationsService.success(
          '',
          'Registro eliminado correctamente.'
        );
        this.getAllCaracteristicasBase();
      })
      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error, el registro no han podido ser eliminado.'
        )
      );
  }
}
