import { FilterBase } from '../../models/search/baseSearch.model';

import {
  AlqExpedienteDto,
  Expediente,
  ExpedienteSearch,
  PaginationFilter,
} from 'src/models';
import { ApiService } from '../api.service';

export class AlquilerApiService {
  constructor(private api: ApiService) {}
  private pathApi = this.api.environment.apiUrl + 'Alquiler';

  public async get(search: ExpedienteSearch): Promise<ExpedienteSearch> {
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

  public async getById(id: number): Promise<AlqExpedienteDto> {
    console.log(id);
    const item: AlqExpedienteDto = await this.api.get(`${this.pathApi}/${id}`);
    return new AlqExpedienteDto(item);
  }

  public async udpate(item: AlqExpedienteDto) {
    console.log('ready for update Expediente Alquiler:');

    return this.api.put<AlqExpedienteDto>(
      `${this.pathApi}/${item.idExpediente}`,
      item
    );
  }
}
