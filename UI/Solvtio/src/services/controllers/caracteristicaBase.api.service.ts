// import { ApiService } from '../api.service';
// import { EmployeeSearch } from '../../models/search/employeeSearch.model';
// import { CommunitySearch, Employee, OfficeSearch } from 'src/models';
// import * as _ from 'underscore';

import { CaracteristicaBase, CaracteristicaBaseSearch } from 'src/models';
import { ApiService } from '../api.service';

export class CaracteristicaBaseApiService {
  constructor(private api: ApiService) {}
  private path = 'api/CaracteristicaBase';
  private pathApi = this.api.environment.apiUrl + 'CaracteristicaBase';

  public async get(
    search: CaracteristicaBaseSearch
  ): Promise<CaracteristicaBaseSearch> {
    //return new CaracteristicaBaseSearch(await this.api.post(`${this.api.environment.apiUrl}${this.path}SearchEmployees`, search))

    return new CaracteristicaBaseSearch({
      ...new CaracteristicaBaseSearch(),
      ...{ result: await this.api.get(this.pathApi) },
    });
  }

  public async getById(id: string): Promise<CaracteristicaBase> {
    const item: CaracteristicaBase = await this.api.get(
      `${this.pathApi}/${id}`
    );
    return new CaracteristicaBase(item);
  }

  public async create(item: CaracteristicaBase) {
    return this.api.post<CaracteristicaBase>(this.pathApi, item);
  }

  public async udpate(item: CaracteristicaBase, id: number) {
    item.id = id;
    return this.api.put<CaracteristicaBase>(`${this.pathApi}/${id}`, item);
  }

  public async delete(id: string) {
    return this.api.delete(`${this.pathApi}/${id}`);
  }
}
