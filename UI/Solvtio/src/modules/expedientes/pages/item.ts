import {
  Component,
  ElementRef,
  OnInit,
  ViewEncapsulation,
} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Expediente, ExpedienteEstadoDto, ModelDtoNombre } from 'src/models';
import { NotificationsService } from 'src/services/notifications.service';
import { ApiService } from '../../../services/api.service';
import { DialogService } from '../../../services/dialog/dialog.service';
// import { DatePipe } from '@angular/common';
import { ExpedienteNotaDto } from '../../../models/expedienteChildren/expChildren.model';

@Component({
  selector: 'page-expediente-list',
  templateUrl: './item.html',
  encapsulation: ViewEncapsulation.None,
  // providers: [DatePipe]
})
export class ExpedienteItemComponent implements OnInit {
  idExpediente: number = 0;
  expediente = new Expediente();
  formData!: FormGroup;

  estadoActual = new ExpedienteEstadoDto();
  notas = new Array<ExpedienteNotaDto>();

  oficinas = new Array<ModelDtoNombre>();
  abogados = new Array<ModelDtoNombre>();
  procuradores = new Array<ModelDtoNombre>();
  juzgados = new Array<ModelDtoNombre>();
  partidosJudiciales = new Array<ModelDtoNombre>();
  carteras = new Array<ModelDtoNombre>();
  pagadores = new Array<ModelDtoNombre>();
  hitosFacturacion = new Array<ModelDtoNombre>();
  subTipoProcedimiento = new Array<ModelDtoNombre>();

  constructor(
    private fb: FormBuilder,
    private api: ApiService,
    private route: ActivatedRoute,
    public elementRef: ElementRef,
    private dialogService: DialogService,
    private notificationsService: NotificationsService
  ) {
    this.idExpediente = this.route.snapshot.params['id'];

    this.createFormData();
    this.getDataAux();
    this.getDataChild();
  }

  async ngOnInit() {
    // console.log('ngOnInit id=' + this.route.snapshot.params['id']);
    // const id = this.route.snapshot.params['id'];
    // this.expediente = !!id
    //   ? await this.api.srvApiExpediente.getById(id)
    //   : new Expediente();
  }

  async createFormData() {
    const id = this.route.snapshot.params['id'];
    this.expediente = !!id
      ? await this.api.srvApiExpediente.getById(id)
      : new Expediente();

    const validations: any = {
      nombre: [Validators.required, Validators.minLength(3)],
    };
    let controlsConfig = Object.entries(this.expediente).reduce(
      (o, k) => ({ ...o, ...{ [k[0]]: [k[1], validations[k[0]] ?? []] } }),
      {}
    );

    // this.expediente.inicio = this.datePipe.transform(this.expediente.inicio, 'dd-MM-yyyy');
    this.formData = this.fb.group(controlsConfig);

    console.log(this.expediente);
  }

  async getDataAux() {
    this.oficinas = await this.api.srvApiNomenclador.clienteOficinaGetAll();
    this.abogados = await this.api.srvApiNomenclador.abogadoGetAll();
    this.procuradores = await this.api.srvApiNomenclador.procuradorGetAll();

    this.juzgados = await this.api.srvApiNomenclador.juzgadoGetAll();
    this.partidosJudiciales =
      await this.api.srvApiNomenclador.partidoJudicialGetAll();
    this.carteras = await this.api.srvApiNomenclador.carteraGetAll();

    this.pagadores = await this.api.srvApiNomenclador.getPagadoresPorOficina(
      this.expediente.idClienteOficina
    );
    this.hitosFacturacion =
      await this.api.srvApiNomenclador.getCaracteristicaBaseByGrupo(
        'Exp-VeniadoHitoFacturacion',
        true
      );
    this.subTipoProcedimiento =
      await this.api.srvApiNomenclador.getCaracteristicaBaseByGrupo(
        'Exp-Subtipo-Procedimiento',
        true
      );
  }

  async getDataChild() {
    this.estadoActual = await this.api.srvApiExpediente.getEstadoActual(
      this.idExpediente
    );
    this.notas = await this.api.srvApiExpediente.getNotas(this.idExpediente);
  }

  saveData() {
    console.log(this.formData.getRawValue());
    this.api.srvApiExpediente
      .udpate(this.formData.getRawValue())
      .then((x) => this.savedSuccessfull())

      // function(value) {
      //   console.log(value); // "Success!"
      //   throw new Error('oh, no!');
      // }

      .catch((x) =>
        this.dialogService.alert(
          'Error',
          'Ha ocurrido un error, los datos no han podido ser guardados.'
        )
      );
  }

  savedSuccessfull() {
    this.notificationsService.success('', 'Datos guardados correctamente!');
    console.log('saveData OK');

    this.createFormData();
    this.getDataAux();
  }
}
