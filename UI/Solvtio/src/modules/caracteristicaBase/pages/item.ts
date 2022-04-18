import {
  Component,
  ElementRef,
  OnInit,
  ViewEncapsulation,
} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CaracteristicaBase, CaracteristicaBaseSearch } from 'src/models';
import { ApiService } from '../../../services/api.service';

@Component({
  selector: 'page-caracteristicaBase-list',
  templateUrl: './item.html',
  encapsulation: ViewEncapsulation.None,
})
export class CaracteristicaBaseItemComponent implements OnInit {
  caracteristicaBase = new CaracteristicaBase();

  constructor(
    private api: ApiService,
    private route: ActivatedRoute,
    public elementRef: ElementRef
  ) {}

  async ngOnInit() {
    const id = this.route.snapshot.params['id'];
    this.caracteristicaBase = !!id
      ? await this.api.srvApiCaracteristicaBase.getById(id)
      : new CaracteristicaBase();
  }
}
