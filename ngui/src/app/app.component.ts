import { Component, OnInit } from '@angular/core';
import { PersonsService, Person } from './persons.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';

  persons: Array<Person> = [];

  constructor(public personsService: PersonsService) {
  }

  ngOnInit(): void {
    this.personsService.getAllPersons().subscribe(d => {
      this.persons = d;
    }, e => console.log(e));
  }
}
