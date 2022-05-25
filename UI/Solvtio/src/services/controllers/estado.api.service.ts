// import { ApiService } from '../api.service';
import { FilterBase } from '../../models/search/baseSearch.model';
// import { EmployeeSearch } from '../../models/search/employeeSearch.model';
// import { CommunitySearch, Employee, OfficeSearch } from 'src/models';
// import * as _ from 'underscore';

///api/Expediente/GetWithPagination

import {
  EstadoAlqFinalizacionDto,
  Expediente,
  ExpedienteDeudorDto,
  ExpedienteEstadoDto,
  ExpedienteNotaDto,
  ExpedienteSearch,
  KpiInfo,
  PaginationFilter,
} from 'src/models';
import { ApiService } from '../api.service';

export class EstadoApiService {
  constructor(private api: ApiService) {}
  private pathApi = this.api.environment.apiUrl + 'Estado';

  public async estadoAlqFinalizacionGetById(
    id: number
  ): Promise<EstadoAlqFinalizacionDto> {
    const item: EstadoAlqFinalizacionDto = await this.api.get(
      `${this.pathApi}/GetEstadoAlqFinalizacion?id=${id}`
    );
    return new EstadoAlqFinalizacionDto(item);
  }

  public async estadoAlqFinalizacionUpdate(item: EstadoAlqFinalizacionDto) {
    return this.api.put<EstadoAlqFinalizacionDto>(
      `${this.pathApi}/EstadoAlqFinalizacionUpdate`,
      item
    );
  }
}
