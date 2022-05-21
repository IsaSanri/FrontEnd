import { Component, OnInit,Input } from '@angular/core';
import { FilmsInfoInterface } from 'src/app/models/films.model';
import { FilmsService } from 'src/app/services/films.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-films',
  templateUrl: './films.component.html',
  styleUrls: ['./films.component.scss']
})
export class FilmsComponent implements OnInit {

  form!: FormGroup;

  // @Input() film : FilmsInfoInterface ={
  // Poster: '',
  // Title: '',
  // Type: '',
  // Year: '',
  // imdbID: ''
  // }

  constructor(
    private formBuilder:FormBuilder
  ) {this.buildForm();}

  ngOnInit(): void {
  }

  private buildForm(){
    this.form=this.formBuilder.group({
      poster:[''],
      title:[''],
      type:[''],
      year:[''],
      imdbID:[''],
      comments:['']
    });
  }

}
