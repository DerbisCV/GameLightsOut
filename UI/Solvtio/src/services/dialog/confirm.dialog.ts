import { Component, ViewEncapsulation } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { Subject } from 'rxjs';
import { DialogResult } from 'src/const/dialogResult.enum';

/**
 * Component configuration
 */
@Component({
    selector: 'confirm-dialog',
    templateUrl: './confirm.dialog.html',
    styleUrls: ['./dialogs.scss'],
    encapsulation: ViewEncapsulation.None
})


/**
 * Class to show an confirmation modal dialog
 */
export class ConfirmDialog {
    
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
        message: string,
        /**
         * Flag buttons to show
         */
        buttons: number,
        /**
         * Set if true action is dangerous
         */
        acceptType: string
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
    action(action: DialogResult) {
        this.data.result = action;
        this.onClose.next(action);
        this.bsModalRef.hide()
    }

    /**
     * Checks if dialog contains button
     * @param button Button to check
     */
    hasButton(button: DialogResult): boolean{
        return (this.data.buttons & button) == button;
    }
}
