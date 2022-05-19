import { Component, OnInit } from '@angular/core';
import { ArticleModel, ArticleResponseModel } from 'src/app/models/article.model';



@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {

  articleList:ArticleModel[];


  constructor() {
    this.articleList=[];
  }

  ngOnInit(): void {
    this.getArticleList();
  }
  async  getArticleList() {
    return await fetch('https://api.plos.org/search?q=title:DNA')
      .then((response) => response.json())
      .then((result) => {
        //docs = json.response.docs;
        this.articleList=result.response.docs.map((element: ArticleResponseModel, index:number)=>{
          const payload={
            id:index,
            title: element.title_display,
            journal:element.journal,
            abstract:element.abstract[0]
          }
          //return payload;
          return Object.assign({},payload);
        })
        console.log('json',result);
        console.log('articleList',this.articleList);
      });
  }


  }


