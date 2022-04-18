import 'reflect-metadata';
import { environment } from 'src/environments/environment';
import { DatePipe } from '@angular/common';
import { ValidatorFn, Validators } from '@angular/forms';
// import * as _ from 'underscore';

const symbols = {
  fieldDefinitionMetadataKey: Symbol('definition'),
  endpointDefinitionMetadataKey: Symbol('endpoint'),
};

export enum FieldTypes {
  NUMBER = 1,
  TEXT = 2,
  DATE = 3,
  SELECT = 4,
  TEXTAREA = 5,
  DATE_RANGE = 6,
  FILE = 7,
  HYPERLINK = 8,
  PHONE = 9,
  DATETIME_RANGE = 10,
  SHAREPOINT_HYPERLINK = 11,
  DATETIME = 12,
  RICHTEXT = 13,
}

export enum Alignments {
  LEFT = 'left',
  CENTER = 'center',
  RIGHT = 'right',
}

export class EndPointDefinition {
  get: string;
  post: string;
  delete: string;

  constructor(item?: Partial<EndPointDefinition>) {
    if (!!item) Object.assign(this, item);
  }
}

export class FieldDefinition {
  order: number = 1;
  tableWidth: string = '*';
  formColumn: number = 0;
  readonly: boolean = false;
  type: FieldTypes = FieldTypes.TEXT;
  alignment: Alignments = Alignments.LEFT;
  title: string = '';
  tooltip: string = '';
  pipe: { fnc: any; args?: any[] } = null;
  route: string | Function = '';
  ignoreOnEdit: boolean = false;
  breakAfter = false;
  wrap: boolean = true;
  placeholder: string = '';
  validators: Partial<{ fnc: ValidatorFn; message: string }>[] = [
    { fnc: Validators.required, message: 'ThisFieldIsRequired' },
  ];
  features: any = {};
  datasource: Partial<{
    placeholder: boolean;
    endpoint: string;
    data: { id: any; name: string }[];
  }> = {
    placeholder: true,
    endpoint: '',
    data: [],
  };
  sorteable: boolean = true;
  sortBy: string = '';

  constructor(item?: Partial<FieldDefinition>) {
    if (!!item) {
      Object.assign(this, item);
    }
  }
}

export function Definition(definition: Partial<FieldDefinition>) {
  return Reflect.metadata(
    symbols.fieldDefinitionMetadataKey,
    new FieldDefinition(definition)
  );
}

export function Endpoint(endpoint: Partial<EndPointDefinition>) {
  return function (constructor: Function) {
    constructor.prototype.endpoint = endpoint;
  };
}

export class BaseModel {
  selected = false;
  public id: string | number = '';

  @Definition({
    readonly: true,
    tableWidth: '',
    type: FieldTypes.TEXT,
    alignment: Alignments.CENTER,
    title: 'Id',
    order: 0,
  })
  @Definition({
    tableWidth: '',
    readonly: true,
    formColumn: 0,
    type: FieldTypes.DATE,
    alignment: Alignments.CENTER,
    title: 'CreateDate',
    tooltip: 'DateToolTip',
    order: 100,
    pipe: {
      fnc: DatePipe,
      args: [environment.configuration.formats.angularDate],
    },
  })
  public created: Date = new Date();

  constructor(item?: Partial<BaseModel>) {
    if (!!item) Object.assign(this, item);
  }

  public getFieldDefinition(fieldName: string): any {
    const definition = Reflect.getMetadata(
      symbols.fieldDefinitionMetadataKey,
      this,
      fieldName
    );
    return definition;
  }

  public get columnDefinitions(): any {
    let result = {};
    Object.keys(this)
      .filter((k) => !k.match(/selected/))
      .forEach((k) => {
        result[k] = this.getFieldDefinition(k);
      });
    return result;
  }

  public get columnsDefinitionKeys(): string[] {
    return _.chain(this.columnDefinitions)
      .keys()
      .sortBy((k) => (this.columnDefinitions[k] || { order: 100 }).order)
      .value();
  }
}
