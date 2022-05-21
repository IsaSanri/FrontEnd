import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl,FormGroup,Validators } from '@angular/forms';
import { EventEmitter,OnChanges,Input,SimpleChanges,Output } from '@angular/core';
import { debounceTime, switchMap } from "rxjs/operators";
import { FilmsService } from 'src/app/services/films.service';


@Component({
  selector: 'app-search-form',
  templateUrl: './search-form.component.html',
  styleUrls: ['./search-form.component.scss']
})
export class SearchFormComponent implements OnInit {
  @Input() searching: boolean;
  @Output() searchFilmEmitter = new EventEmitter<string>();
  filmForm:FormGroup;

    movies='Movies';
    series='Series';
    episodes='Episodes';
    search='Buscar';
    year='Año';


  constructor(private filmsService:FilmsService, private fb:FormBuilder) {
    this.filmForm=this.fb.group({
      movies:[''],
      series:[''],
      episodes:[''],
      nameField:['',Validators.required],
      yearField:['']
    });

    this.searching = false;
  }

 

  ngOnInit(): void {
  }

}
