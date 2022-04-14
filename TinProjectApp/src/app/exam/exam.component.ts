import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-exam',
  templateUrl: './exam.component.html',
  styleUrls: ['./exam.component.css']
})
export class ExamComponent implements OnInit {

  actualIndex: number = 0;

  form = this.formBuilder.group({
    questions: this.formBuilder.array([])
  });

  constructor(private formBuilder: FormBuilder) { }

  get questions() {
    return this.form.controls["questions"] as FormArray;
  }

  addQuestion() {
    const questionForm = this.formBuilder.group({
      title: ['', Validators.required],
      questionContent: ['', Validators.required],
      description: [''],
      answer1: ['', Validators.required],
      answer2: ['', Validators.required],
      answer3: [''],
      answer4: [''],
      isCorrectAnswer1: [false, Validators.required],
      isCorrectAnswer2: [false, Validators.required],
      isCorrectAnswer3: [false],
      isCorrectAnswer4: [false],
      points: ['', [Validators.required, Validators.min(1), Validators.max(100)]],
    });

    this.actualIndex = this.questions.length - 1;
    console.log(this.questions);
    this.questions.push(questionForm);
  }

  setActualIndex(index: number) {
    this.actualIndex = index;
  }

  getActualIndex() {
    return this.actualIndex;
  }

  removeQuestion(index: number) {
    this.questions.removeAt(index);
  }

  ngOnInit(): void {
  }

}