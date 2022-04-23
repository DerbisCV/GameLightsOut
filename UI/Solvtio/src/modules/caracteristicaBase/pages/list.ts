import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { CaracteristicaBaseSearch } from 'src/models';
import { ApiService } from '../../../services/api.service';

// import { NgModule } from '@angular/core';
// import { BrowserModule } from '@angular/platform-browser';
import { DataTablesModule } from 'angular-datatables';

import { Columns, Config, DefaultConfig } from 'ngx-easy-table';

@Component({
  selector: 'page-caracteristicaBase-list',
  templateUrl: './list.html',
  styleUrls: ['./list.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class CaracteristicaBaseListComponent implements OnInit {
  caracteristicaBaseSearch!: CaracteristicaBaseSearch;
  public dtOptions: DataTables.Settings = {
    pagingType: 'full_numbers',
    pageLength: 2,
  };

  public configuration: Config;
  public columns: Columns[];

  public data = [
    {
      phone: '+1 (934) 551-2224',
      age: 20,
      address: { street: 'North street', number: 12 },
      company: 'ZILLANET',
      name: 'Valentine Webb',
      isActive: false,
    },
    {
      phone: '+1 (948) 460-3627',
      age: 31,
      address: { street: 'South street', number: 12 },
      company: 'KNOWLYSIS',
      name: 'Heidi Duncan',
      isActive: true,
    },
  ];

  constructor(private api: ApiService) {
    this.columns = [
      { key: 'phone', title: 'Phone' },
      { key: 'age', title: 'Age' },
      { key: 'company', title: 'Company' },
      { key: 'name', title: 'Name' },
      { key: 'isActive', title: 'STATUS' },
    ];
    this.configuration = { ...DefaultConfig };
    this.configuration.searchEnabled = true;
  }

  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 2,
    };

    this.getAllCaracteristicasBase();

    this.configuration = { ...DefaultConfig };
    this.configuration.searchEnabled = true;
    // ... etc.
    this.columns = [
      { key: 'phone', title: 'Phone' },
      { key: 'age', title: 'Age' },
      { key: 'company', title: 'Company' },
      { key: 'name', title: 'Name' },
      { key: 'isActive', title: 'STATUS' },
    ];
  }

  async getAllCaracteristicasBase() {
    this.caracteristicaBaseSearch = await this.api.srvApiCaracteristicaBase.get(
      new CaracteristicaBaseSearch()
    );

    // alert(this.caracteristicaBaseSearch.result.length);
    // $('#example').DataTable();
  }
}
