import { Expediente, ModelExpediente } from '../Expediente.model';
import { BaseSearch, FilterBase, PaginationFilter } from './baseSearch.model';

export class ExpedienteSearch extends BaseSearch<Expediente> {
  public paginationFilter: PaginationFilter = new PaginationFilter();

  constructor(item?: Partial<ExpedienteSearch>) {
    super();
    if (!!item) {
      Object.assign(this, item);
      // this.filter = new CaracteristicaBaseSearchFilter(item.filter);
      this.filterBase = new FilterBase(item.filterBase);
      this.result = (item.result || []).map((r) => new ModelExpediente(r));
    } else {
      this.filterBase = new FilterBase();
    }
    this.sortBy = this.sortBy || 'name';
  }
}

// export class CaracteristicaBaseSearchFilter {
//   public name: string = '';
//   public surname1: string = '';
//   public surname2: string = '';
//   public id: string = '';
//   public email: string = '';
//   public phone: string = '';
//   public idState?: number;
//   public officeId: string = '';
//   // public ivnosysStatus: IvnosysStatuses = IvnosysStatuses.ALL;

//   constructor(item?: Partial<CaracteristicaBaseSearchFilter>) {
//     if (!!item) Object.assign(this, item);
//   }
// }
