import { Component, OnInit } from '@angular/core';
import { FilmsService } from 'src/app/services/films.service';
import { FilmsInfoInterface, FilmsInterface,FilmsListResponse } from 'src/app/models/films.model';



@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})

export class DashboardComponent implements OnInit{


  filmsList:FilmsInterface[];
  favoriteShow:FilmsInterface[];
  searchingFilm=false;


constructor(private filmsService:FilmsService) {
  this.filmsList=[];
  this.favoriteShow=[];

}

ngOnInit(): void {

}


searchFilm(filmsTitle: string) {

  this.filmsService.getFilmList(filmsTitle).subscribe(
    (result: FilmsListResponse) => {
      console.log("result", result);
      if (result.Response) {
        this.filmsList = result.Search;
      } else {
        alert("too many results, write more!");
      }
    },
    () => (this.searchingFilm = false)
  );
}

}
