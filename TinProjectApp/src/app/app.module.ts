import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ExamsComponent } from './exams/exams.component';
import { HttpClientModule } from '@angular/common/http';
import { ExamsService } from './shared/exams.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'; 
import { MatTabsModule } from '@angular/material/tabs';
import { MatInputModule } from '@angular/material/input';  
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ActiveExamsComponent } from './exams/Active/Active.exams.component';
import { ExamComponent } from './exam/exam.component';

@NgModule({
  declarations: [
    AppComponent,
    ExamsComponent,
    ActiveExamsComponent,
    ExamComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatTabsModule,
    MatInputModule,
    BrowserAnimationsModule,
  ],
  providers: [ExamsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
