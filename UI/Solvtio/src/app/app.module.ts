import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { BsModalService } from 'ngx-bootstrap/modal';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ConfirmDialog } from '../services/dialog/confirm.dialog';
import { AlertDialog } from '../services/dialog/alert.dialog';

import { TableModule } from 'ngx-easy-table';

  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
    TableModule,
  ],
  providers: [BsModalService],
  bootstrap: [AppComponent],
})
export class AppModule {}
