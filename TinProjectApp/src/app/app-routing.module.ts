import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExamComponent } from './exam/exam.component';
import { ExamsComponent } from './exams/exams.component';

const routes: Routes = [
  { path: 'exam-component', component: ExamComponent},
  { path: 'examList-component', component: ExamsComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
