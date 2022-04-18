import { CaracteristicaBase } from '../CaracteristicaBase.model';
import { BaseSearch } from './baseSearch.model';

export class CaracteristicaBaseSearch extends BaseSearch<CaracteristicaBase> {
  constructor(item?: Partial<CaracteristicaBaseSearch>) {
    super();
    if (!!item) {
      Object.assign(this, item);
      this.filter = new CaracteristicaBaseSearchFilter(item.filter);
      this.result = (item.result || []).map((r) => new CaracteristicaBase(r));
    } else {
      this.filter = new CaracteristicaBaseSearchFilter();
    }
    this.sortBy = this.sortBy || 'name';
  }
}

export class CaracteristicaBaseSearchFilter {
  public name: string = '';
  public surname1: string = '';
  public surname2: string = '';
  public id: string = '';
  public email: string = '';
  public phone: string = '';
  public idState?: number;
  public officeId: string = '';
  // public ivnosysStatus: IvnosysStatuses = IvnosysStatuses.ALL;

  constructor(item?: Partial<CaracteristicaBaseSearchFilter>) {
    if (!!item) Object.assign(this, item);
  }
}
