// import { ApiService } from '../api.service';
// import { EmployeeSearch } from '../../models/search/employeeSearch.model';
// import { CommunitySearch, Employee, OfficeSearch } from 'src/models';
// import * as _ from 'underscore';

///api/Expediente/GetWithPagination

import {
  Expediente,
  ExpedienteEstadoDto,
  ExpedienteNotaDto,
  ExpedienteSearch,
  PaginationFilter,
} from 'src/models';
import { ApiService } from '../api.service';

export class ExpedienteApiService {
  constructor(private api: ApiService) {}
  private path = 'api/Expediente';
  private pathApi = this.api.environment.apiUrl + 'Expediente';

  public async get(search: ExpedienteSearch): Promise<ExpedienteSearch> {
    //return new ExpedienteSearch(await this.api.post(`${this.api.environment.apiUrl}${this.path}SearchEmployees`, search))

    return new ExpedienteSearch({
      ...new ExpedienteSearch(),
      ...{ result: await this.api.get(this.pathApi) },
    });
  }

  public async getPaginated(
    paginationFilter: PaginationFilter
  ): Promise<ExpedienteSearch> {
    if (paginationFilter.pagination.pageNumber === 0)
      paginationFilter.pagination.pageNumber = 1;

    return new ExpedienteSearch(
      await this.api.post(`${this.pathApi}/GetWithPagination`, paginationFilter)
    );
  }

  public async getById(id: string): Promise<Expediente> {
    const item: Expediente = await this.api.get(`${this.pathApi}/${id}`);
    return new Expediente(item);
  }

  public async create(item: Expediente) {
    return this.api.post<Expediente>(this.pathApi, item);
  }

  public async udpate(item: Expediente) {
    console.log('ready for update Expediente:');

    return this.api.put<Expediente>(
      `${this.pathApi}/${item.idExpediente}`,
      item
    );
  }
  // public async udpate(item: Expediente, id: number) {
  //   item.id = id;
  //   return this.api.put<Expediente>(`${this.pathApi}/${id}`, item);
  // }

  public async delete(id: string) {
    return this.api.delete(`${this.pathApi}/${id}`);
  }

  public async getEstadoActual(
    idExpediente: number
  ): Promise<ExpedienteEstadoDto> {
    return await this.api.get(
      `${this.pathApi}/GetEstadoActual?id=${idExpediente}`
    );
  }

  public async getNotas(idExpediente: number): Promise<ExpedienteNotaDto[]> {
    return await this.api.get(
      `${this.pathApi}/GetNotas?idExpediente=${idExpediente}`
    );
  }
}
