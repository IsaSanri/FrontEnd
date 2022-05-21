import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatGridListModule} from '@angular/material/grid-list';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard.component';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { FilmsComponent } from './components/films/films.component';
import { FavoritesComponent } from './components/favorites/favorites.component';
import { SearchFormComponent } from './components/search-form/search-form.component';


@NgModule({
  declarations: [
    DashboardComponent,
    FilmsComponent,
    FavoritesComponent,
    SearchFormComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    MatGridListModule,
    MaterialModule,
    ReactiveFormsModule
  ]
})
export class DashboardModule { }
