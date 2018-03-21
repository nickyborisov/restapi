import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { RadioButtonModule } from 'primeng/primeng';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';


import { AppComponent } from './app.component';

// Import PrimeNG modules

import {
  PaginatorModule, ToggleButtonModule, ButtonModule, DropdownModule, DataTableModule,
  DataScrollerModule, DataListModule, DialogModule, ConfirmDialogModule, GrowlModule, CheckboxModule, InputSwitchModule,
  CalendarModule, TreeTableModule, SpinnerModule, AutoCompleteModule, ToolbarModule, PanelModule, TabViewModule,
  SelectButtonModule, FieldsetModule, TreeModule, InputTextareaModule, MultiSelectModule, PanelMenuModule,
  InputTextModule, MenuModule, OverlayPanelModule, AccordionModule, ListboxModule, AccordionTab, FileUploadModule, SlideMenuModule
} from 'primeng/primeng';
import { PersonsService } from './persons.service';
import { PersonComponent } from './person.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    AccordionModule,
    PanelModule,
    ButtonModule,
    RadioButtonModule,

    // PrimeNG
    ButtonModule, DataTableModule, DataScrollerModule, DataListModule, DialogModule, ConfirmDialogModule,
    PaginatorModule, InputSwitchModule, CheckboxModule, ToggleButtonModule, DropdownModule, GrowlModule,
    CalendarModule, InputTextModule, MultiSelectModule, PanelMenuModule, InputTextareaModule,
    TreeTableModule, TreeModule, MenuModule, PanelModule, TabViewModule, SelectButtonModule, FieldsetModule,
    SpinnerModule, AutoCompleteModule, ToolbarModule, OverlayPanelModule, AccordionModule, ListboxModule,
    FileUploadModule, SlideMenuModule
  ],
  providers: [HttpClientModule, PersonsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
