import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class ExamsService {

  constructor(private httpclient: HttpClient) { }

  getExams(): Observable<any> {
    return this.httpclient.get("https://localhost:44364/api/Exams");
  }
}
