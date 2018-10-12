import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Obra } from '../../models/obra/obra.model';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';

@Injectable()
export class ObrasService {

  private base_url: string;

  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.base_url = baseUrl;
    
  }

  public getObras(): Observable<Obra[]>{

    return this.http
      .get<Obra[]>(this.base_url + 'api/Work/GetWorks');
  }

}
