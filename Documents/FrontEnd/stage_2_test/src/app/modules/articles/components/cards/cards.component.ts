import { Component, Input, OnInit } from '@angular/core';
import { ArticleModel } from 'src/app/models/article.model';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.scss']
})
export class CardsComponent implements OnInit {
  @Input() article: ArticleModel;

  constructor() {
    this.article={
      id:0,
      title:'',
      journal:'',
      abstract:''
    }
  }

  ngOnInit(): void {
  }

  getImageSource(){
    return this.article.journal.toLowerCase().includes('plos one') ? 'assets/image/plos_one.png' : 'assets/image/not-found.png';
  }
}
