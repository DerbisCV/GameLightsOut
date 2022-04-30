import {
  Component,
  OnInit,
  TemplateRef,
  ViewChild,
  ViewEncapsulation,
  ChangeDetectionStrategy,
} from '@angular/core';
import {
  Expediente,
  ExpedienteSearch,
  ModelExpediente,
  PaginationFilter,
} from 'src/models';
import { ApiService } from '../../../services/api.service';
import { Columns, Config, DefaultConfig } from 'ngx-easy-table';
import { DialogService } from 'src/services/dialog/dialog.service';
import { NotificationsService } from 'src/services/notifications.service';

interface EventObject {
  event: string;
  value: {
    limit: number;
    page: number;
  };
}

@Component({
  selector: 'page-Expediente-list',
  templateUrl: './list.html',
  styleUrls: ['./list.scss'],
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ExpedienteListComponent implements OnInit {
  @ViewChild('actionTpl') actionTpl!: TemplateRef<any>;
  @ViewChild('tplFechaAlta') tplFechaAlta!: TemplateRef<any>;

  expedienteSearch: ExpedienteSearch = new ExpedienteSearch();
  configuration = { ...DefaultConfig };
  public columns = [
    { key: 'noExpediente', title: 'No Exp.' },
    { key: 'referenciaExterna', title: 'Ref.Externa' },
    { key: 'clienteOficina', title: 'Oficina' },
    { key: 'tipoExpediente', title: 'Tipo' },
    { key: 'fechaAlta', title: 'F.Alta', cellTemplate: this.tplFechaAlta },
    {
      key: 'idExpediente',
      title: '',
      cellTemplate: this.actionTpl,
      orderEnabled: false,
      searchEnabled: false,
    },
  ];

  //public data: Expediente[] = [];
  public data = new Array<ModelExpediente>();
  public pagination = {
    limit: 10,
    offset: 1,
    count: -1,
  };

  constructor(
    private api: ApiService,
    private dialogService: DialogService,
    private notificationsService: NotificationsService
  ) {
    // this.page.pageNumber = 0;
    // this.page.size = 20;
  }

  ngOnInit(): void {
    this.configuration = { ...DefaultConfig };
    // this.configuration.searchEnabled = true;
    this.configuration.paginationMaxSize = 10;

    this.getPaginatedData();
    this.tableRefresh();

    // event: string;
    // value: {
    //   limit: number;
    //   page: number;
    // };

    // this.parseEvent({
    //   value: {
    //     limit: 5,
    //     page: 1,
    //   },
    // });
  }

  eventEmitted($event: { event: string; value: any }): void {
    if ($event.event !== 'onClick') {
      this.parseEvent($event);
    }
  }

  private parseEvent(obj: EventObject): void {
    this.pagination.limit = obj.value.limit
      ? obj.value.limit
      : this.pagination.limit;
    this.pagination.offset = obj.value.page
      ? obj.value.page
      : this.pagination.offset;
    this.pagination = { ...this.pagination };
    // const params = `_limit=${this.pagination.limit}&_page=${this.pagination.offset}`; // see https://github.com/typicode/json-server
    // this.getData(params);
    this.getPaginatedData();
  }

  async getPaginatedData() {
    // this.expedienteSearch = await this.api.srvApiExpediente.get(
    //   new ExpedienteSearch()
    // );
    let paginationFilter = new PaginationFilter();
    paginationFilter.pagination.pageNumber = this.pagination.offset;
    paginationFilter.pagination.pageLimit = this.pagination.limit;

    this.expedienteSearch = await this.api.srvApiExpediente.getPaginated(
      paginationFilter
    );
    console.log(this.expedienteSearch);
    console.log(this.expedienteSearch.paginationFilter.pagination);

    // this.data = this.expedienteSearch.result;
    this.tableRefresh();

    //this.pagination. = this.expedienteSearch.paginationFilter.pagination.totalElements;
    this.configTableColumns();
  }

  tableRefresh() {
    this.pagination.count =
      this.expedienteSearch.paginationFilter.pagination.totalElements;
    this.data = this.expedienteSearch.result;
  }

  // /**
  //  * Populate the table with new data based on the page number
  //  * @param page The page to select
  //  */
  // async setPage(pageInfo: { offset: number }) {
  //   this.page.pageNumber = pageInfo.offset;

  //   let expSearch = new ExpedienteSearch();
  //   expSearch.currentPage = pageInfo.offset;

  //   // this.api.srvApiExpediente.getPaginated(expSearch).subscribe(pagedData => {
  //   //   this.page = pagedData.page;
  //   //   this.rows = pagedData.data;
  //   // });

  //   this.expedienteSearch = await this.api.srvApiExpediente.getPaginated(
  //     expSearch
  //   );
  //   console.log(this.expedienteSearch);
  //   this.data = this.expedienteSearch.result;
  //   this.configTableColumns();
  // }

  configTableColumns() {
    this.columns = [
      { key: 'noExpediente', title: 'No Exp.' },
      { key: 'referenciaExterna', title: 'Ref.Externa' },
      { key: 'clienteOficina', title: 'Oficina' },
      { key: 'tipoExpediente', title: 'Tipo' },
      { key: 'fechaAlta', title: 'F.Alta', cellTemplate: this.tplFechaAlta },
      {
        key: 'idExpediente',
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
