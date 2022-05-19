import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { ArticlesRoutingModule } from './articles-routing.module';
import { ArticlesComponent } from './articles.component';
import { FormComponent } from './components/form/form.component';
import { CardsComponent } from './components/cards/cards.component';
import { MaterialModule } from 'src/app/shared/material/material.module';


@NgModule({
  declarations: [
    ArticlesComponent,
    FormComponent,
    CardsComponent
  ],
  imports: [
    CommonModule,
    ArticlesRoutingModule,
    MaterialModule
  ]
})
export class ArticlesModule { }
