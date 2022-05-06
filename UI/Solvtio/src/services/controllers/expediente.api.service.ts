// import { ApiService } from '../api.service';
// import { EmployeeSearch } from '../../models/search/employeeSearch.model';
// import { CommunitySearch, Employee, OfficeSearch } from 'src/models';
// import * as _ from 'underscore';

///api/Expediente/GetWithPagination

import {
  Expediente,
  ExpedienteDeudorDto,
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

  public async getIdExpedienteByNo(noExp: string): Promise<number> {
    return await this.api.get(
      `${this.pathApi}/GetIdExpedienteByNo?noExpediente=${noExp}`
    );
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

  public async getDeudores(
    idExpediente: number
  ): Promise<ExpedienteDeudorDto[]> {
    const url = `${this.pathApi}/GetDeudores?idExpediente=${idExpediente}`;
    console.log(url);
    return await this.api.get(url);

    //.then(function (clientData) {
    //     let clientWithType = Object.assign(new Array<ExpedienteDeudorDto>(), clientData);
    //     retutn clientWithType;
    //   });

    // this.api.get(url)
    // // .fetch("data.json")
    // // .then(response => response.json())
    // .then((data: ExpedienteDeudorDto[]) => {
    //   data.forEach(agency => (agency.steps = mapLoadedSteps(agency.steps)));

    //   this.agencies = data;
    // });

    // service.getClientFromAPI().then(clientData => {

    //   // Here the client data from API only have the "name" field
    //   // If we want to use the Client class methods on this data object we need to:
    //   let clientWithType = Object.assign(new Client(), clientData)

    //   clientWithType.displayName()
    // })
  }
}
