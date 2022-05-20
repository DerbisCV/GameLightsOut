import * as moment from 'moment';
import { HasEnvironment } from './../../environments/hasEnvironment.class';

export class BaseSearch<TResult> extends HasEnvironment {
  constructor(item?: Partial<BaseSearch<TResult>>) {
    super();
    if (!!item) Object.assign(this, item);
  }

  public totalItems: number = 0;
  public totalPages: number = 0;
  public currentPage: number = 1;
  public itemsPerPage: number | 'infinite' = 25;
  public result: TResult[] = [];
  public sortBy: string = '';
  public sortAsc: boolean = true;
  public filter: any = {};
  public filterBase: FilterBase = new FilterBase();

  protected clear(obj: any) {
    delete obj.environment;
    delete obj.totalPages;
    delete obj.totalItems;
    delete obj.result;
    Object.keys(obj).forEach(
      (k) => (!obj[k] || typeof obj[k] == 'function') && delete obj[k]
    );
    return obj;
  }

  protected asQueryParams(obj: any): string {
    return Object.keys(this.clear(obj))
      .map((k) => `${k}=${obj[k]}`)
      .join('&');
  }

  protected asStringArray(value: any) {
    return !!value && typeof value == 'string'
      ? value.split(/,/g).map((o) => o.trim())
      : value || [];
  }
  protected asServerDate(value: any) {
    return !!value && value instanceof Date
      ? moment(value).format(
          this.environment.configuration.formats.serverDateAndTime
        )
      : value || null;
  }

  public get selectedItems(): TResult[] {
    return this.result?.filter((r: any) => r.selected);
  }
}

export class SearchPageActionModel {
  constructor(
    public label: string,
    public action: any | Promise<any>,
    public enableMode: SearchPageActionEnableMode = 'always'
  ) {}
}

export type SearchPageActionEnableMode = 'one' | 'many' | 'always';

export class SearchPageActionsModel {
  public create?: SearchPageActionModel;
  public edit?: SearchPageActionModel;
  public delete?: SearchPageActionModel;
  public import?: SearchPageActionModel;
  public export?: SearchPageActionModel;
  public anotherActions: SearchPageActionModel[] = [];

  constructor(item?: Partial<SearchPageActionsModel>) {
    if (!!item) {
      Object.assign(this, item);
      this.anotherActions = (item.anotherActions || []).map(
        (a) => new SearchPageActionModel(a.label, a.action, a.enableMode)
      );
    }
  }
}
export class FilterBase {
  public code1: string = '';
  public code2: string = '';
  public code3: string = '';
  public code4: string = '';
  public code5: string = '';

  public idTipo1?: number | null = null;
  public idTipo2?: number | null = null;
  public idTipo3?: number | null = null;
  public idTipo4?: number | null = null;
  public idTipo5?: number | null = null;

  public isOnOff1?: boolean | null = null;
  public isOnOff2?: boolean | null = null;
  public isOnOff3?: boolean | null = null;

  constructor(item?: Partial<FilterBase>) {
    if (!!item) Object.assign(this, item);
  }
}

export class PaginationBase {
  pageNumber: number = 1;
  pageLimit: number = 15;
  totalElements: number = 0;
  totalPages: number = 0;
}

export class PaginationFilter {
  public filter: FilterBase = new FilterBase();
  public pagination: PaginationBase = new PaginationBase();
}
