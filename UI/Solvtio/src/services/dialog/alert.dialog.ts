import { Subject } from 'rxjs';
import { Component, Injectable, ViewEncapsulation } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { DialogResult } from 'src/const/dialogResult.enum';

/**
 * Component configuration
 */
 @Injectable({ providedIn: 'root' })
@Component({
    selector: 'alert-dialog',
    templateUrl: './alert.dialog.html',
    styleUrls: ['./dialogs.scss'],
    encapsulation: ViewEncapsulation.None
})


/**
 * Class to show an alert modal dialog
 */
export class AlertDialog {
    
    /**
     * Input/Output dialog data
     */
    public data!: { 
        /**
         * Output dialog result
         */
        result: DialogResult,
        /**
         * Dialog title
         */
        title: string,
        /**
         * Dialog message
         */
        message: string
     };
    
    /**
     * Class constructor
     * @param bsModalRef Injected reference to bootstrap modal reference
     */ 
    constructor(public bsModalRef: BsModalRef) {
    }

    /** */
    onClose = new Subject<DialogResult>();

    /**
     * Return the dialog action result
     */
    ok() {
        this.data.result = DialogResult.Ok;
        this.onClose.next(DialogResult.Ok);
        this.bsModalRef.hide()
    }    
}
