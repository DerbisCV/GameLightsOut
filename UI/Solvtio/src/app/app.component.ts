import { Component, ViewEncapsulation } from '@angular/core';
import { NgForm } from '@angular/forms';
import { DialogResult } from 'src/const/dialogResult.enum';
import { CaracteristicaBaseItemComponent } from 'src/modules/caracteristicaBase/pages';
import { ApiService } from 'src/services/api.service';
import { DialogService } from 'src/services/dialog/dialog.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class AppComponent {
  constructor(private dialogService: DialogService, private api: ApiService) {}
  title = 'Solvtio';

  async preguntar(): Promise<DialogResult> {
    const result = await this.dialogService.confirm(
      'titulo',
      'mensaje',
      DialogResult.Ok |
        DialogResult.Yes |
        DialogResult.No |
        DialogResult.Cancel,
      'danger'
    );
    if (result == DialogResult.Ok)
      this.dialogService.alert('Resultado', result.toString());
    return result;
  }

  async alerta() {
    this.dialogService.show(CaracteristicaBaseItemComponent as any, {});
  }

  async buscarExpediente(forma: NgForm) {
    const noExp = forma.value['noExp'];
    console.log(noExp);

    const idExpediente = await this.api.srvApiExpediente.getIdExpedienteByNo(
      noExp
    );
    console.log(idExpediente);
    if (idExpediente > 0) {
      console.log('vavegar a ....');
      window.location.replace('/expediente/update/' + idExpediente.toString());
    }
  }
}
