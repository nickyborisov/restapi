import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Person, PersonsService } from './persons.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  @Input() model: Person;
  @Input() isVisible: boolean;
  @Input() isEdit: boolean;
  @Output() updated = new EventEmitter(false);

  form: FormGroup;
  title = '';

  constructor(
    private personsService: PersonsService,
    private builder: FormBuilder) { }

  ngOnInit() {

    this.title = this.isEdit ? 'Edit person' : 'Add person';

    this.form = this.builder.group({
      first: ['', Validators.required],
      last: ['', Validators.required],
      phone: ['', Validators.required],
    });

  }

  onSubmit() {
    if (this.isEdit) {
      this.personsService.updatePerson(this.model).subscribe(k => {
        this.updated.emit();
      }, e => console.log(e));

    } else {

      this.personsService.insertPerson(this.model).subscribe(k => {
        this.updated.emit();
      }, e => console.log(e));
    }
  }
}
