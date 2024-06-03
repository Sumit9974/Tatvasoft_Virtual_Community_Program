import { Component, Input, OnInit } from '@angular/core';
import { Todo } from 'src/app/Todo';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css'],
})


export class TodosComponent implements OnInit {
  deleteTodo(event: Todo) {
    const index = this.todos.indexOf(event);
    this.todos.splice(index, 1);
    console.log(event);
    // localStorage.setItem('todos', JSON.stringify(this.todos));
  }

  addTodo(event: Todo) {
    console.log(event);
    this.todos.push(event);
    // localStorage.setItem('todos', JSON.stringify(this.todos));
  }

  todos: Todo[];
  // localItem: string | null;

  constructor() {
    // this.localItem = localStorage.getItem('todos');
    // if (this.localItem == null) {
    //   this.todos = [];
    // } else {
    //   this.todos = JSON.parse(this.localItem);
    // }
    this.todos = [
      {
        sno: 1,
        title: 'Homework',
        desc: 'Phad le bhai',
        active: true,
      },
      {
        sno: 2,
        title: 'Homework 2',
        desc: 'Complete Your Homework',
        active: false,
      },
    ];
  }

  ngOnInit(): void {}
}
