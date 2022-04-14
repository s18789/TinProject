import { Component, OnInit,ViewEncapsulation } from '@angular/core';
import { Exams } from '../shared/exams.model';
import { ExamsService } from '../shared/exams.service';

@Component({
  selector: 'app-exams',
  templateUrl: './exams.component.html',
  styleUrls: ['./exams.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class ExamsComponent implements OnInit {

  constructor(private examsService: ExamsService ){
  }

  exams: Exams[];

  ngOnInit(){
    this.examsService.getExams()
    .subscribe
    (
      data =>{
        this.exams = data;
      }
    );
  }

}
