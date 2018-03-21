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
  isVisible: boolean;
  currentPerson: Person = <any>{};
  isEdit: boolean;

  constructor(private personsService: PersonsService) {
  }

  ngOnInit(): void {
    this.personsService.getAllPersons().subscribe(d => {
      this.persons = d;
    }, e => console.log(e));
  }

  onAdd() {

    this.isEdit = false;
    this.currentPerson = <any>{};
    this.isVisible = true;
  }

  onEdit(person: Person) {

    this.isEdit = true;
    this.currentPerson = person;
    this.isVisible = true;
  }

  onDelete(person: Person) {

    this.personsService.deletePerson(person.id).subscribe(d => {
      alert(person.first + ' is deleted');
    }, e => console.log(e));
  }

  onUpdated() {
    this.isVisible = false;

    this.personsService.getAllPersons().subscribe(d => {
      this.persons = d;
    }, e => console.log(e));
  }
}
