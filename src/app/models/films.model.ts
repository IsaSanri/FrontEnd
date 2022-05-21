export interface FilmsListResponse {
  Response: string;
  Search: FilmsInfoInterface[];
  totalResults: string;
}

export interface FilmsInfoInterface {
  Poster: string;
  Title: string;
  Type: string;
  Year: string;
  imdbID: string;
}

export interface FilmsInterface {
  Title: string;
  Type: string;
  Year: string;
}
