import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { CaracteristicaBaseSearch } from 'src/models';
import { ApiService } from '../../../services/api.service';

// import { NgModule } from '@angular/core';
// import { BrowserModule } from '@angular/platform-browser';
import { DataTablesModule } from 'angular-datatables';

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

  constructor(private api: ApiService) {}

  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 2,
    };

    this.getAllCaracteristicasBase();
  }

  async getAllCaracteristicasBase() {
    this.caracteristicaBaseSearch = await this.api.srvApiCaracteristicaBase.get(
      new CaracteristicaBaseSearch()
    );

    // alert(this.caracteristicaBaseSearch.result.length);
    // $('#example').DataTable();
  }
}
