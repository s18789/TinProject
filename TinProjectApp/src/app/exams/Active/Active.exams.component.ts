import { Component, OnInit,ViewEncapsulation } from '@angular/core';
import { Exams } from '../../shared/exams.model';
import { ExamsService } from '../../shared/exams.service';

@Component({
  selector: 'app-active-exams',
  templateUrl: './Active.exams.component.html',
  styleUrls: ['./Active.exams.component.css'],
  encapsulation: ViewEncapsulation.None
})

export class ActiveExamsComponent implements OnInit {

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