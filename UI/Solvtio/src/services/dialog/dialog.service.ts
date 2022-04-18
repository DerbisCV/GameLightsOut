import { AlertDialog, ConfirmDialog } from '.';
import { take } from 'rxjs/operators';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { Injectable, TemplateRef } from '@angular/core';
import { DialogResult } from 'src/const/dialogResult.enum';

@Injectable({ providedIn: 'root' })
export class DialogService {
    /**
     * Reference to modal window
     */
    private bsModalRef!: BsModalRef;
    /**
     * Component constructor
     * @param modalService Service to modal windows
     */
    constructor(private modalService: BsModalService) { }

    /**
     * 
     * @param page Type of page to show as modal
     * @param data Data passed to modal
     * @param cssClasses CSS classes to modal
     */
    public async show<P extends TemplateRef<P>, T>(page: P, data: T | null = null, cssClasses: string[] = []): Promise<T> {
        return new Promise<T>(resolve => {
            const initialState = {
                data: data
            };
            this.bsModalRef = this.modalService.show(page, Object.assign({
                class: [...['gray'], ...cssClasses].join(' '),
                keyboard: true,
                ignoreBackdropClick: true
            }, { initialState }));

            this.bsModalRef.content.onClose.pipe(take(1)).subscribe((value: any) => {
                resolve(value)
            });
            // this.bsModalRef.content.onClose.subscribe(result => {
            //     debugger;
            //     console.log('results', result);
            // })
        });
    }

    public async alert(title: string, message: string): Promise<DialogResult> {
        const initialState = {
            data: {
                result: DialogResult.None,
                title: title,
                message: message
            }
        };
        return new Promise<DialogResult>(resolve => {
            this.bsModalRef = this.modalService.show(AlertDialog, Object.assign({
                class: 'gray modal-md',
                keyboard: true,
                ignoreBackdropClick: true,
            }, { initialState }));

            // this.modalService.onHide.pipe(take(1)).subscribe(() => {
            //     resolve(initialState.data.result)
            // });
            this.bsModalRef.content.onClose.subscribe((result: DialogResult | PromiseLike<DialogResult>) => {
                resolve(result);
            });
        });
    }

    public async confirm(title: string, message: string, buttons: number, acceptType = 'primary'): Promise<DialogResult> {
        const initialState = {
            data: {
                result: DialogResult.None,
                title: title,
                message: message,
                buttons: buttons,
                acceptType: acceptType
            }
        };
        return new Promise<DialogResult>(resolve => {
            this.bsModalRef = this.modalService.show(ConfirmDialog, Object.assign({
                class: 'gray modal-md',
                keyboard: true,
                ignoreBackdropClick: true
            }, { initialState }));

            // this.modalService.onHide.pipe(take(1)).subscribe(() => {
            //     resolve(initialState.data.result)
            // });
            this.bsModalRef.content.onClose.subscribe((result: DialogResult | PromiseLike<DialogResult>) => {
                resolve(result);
            });
        });
    }

    public async confirmRemove(): Promise<DialogResult>{
        return this.confirm(
            'Remove',
            'RemoveSelectedItemsQuestion',
            DialogResult.Yes | DialogResult.No,
            'danger');
    }
}