import { Component, ViewEncapsulation } from '@angular/core';
import { DialogResult } from 'src/const/dialogResult.enum';
import { CaracteristicaBaseItemComponent } from 'src/modules/caracteristicaBase/pages';
import { DialogService } from 'src/services/dialog/dialog.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent {
  constructor(private dialogService: DialogService) {}
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
}
