import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';

export interface Person {
  id: number;
  first: string;
  last: string;
  phone: string;
  version: number;
}

const serverUri = 'http://localhost:50443/api/persons';

@Injectable()
export class PersonsService {

  constructor(private http: HttpClient) { }

  getAllPersons(): Observable<Person[]> {
    return this.http.get<Person[]>(serverUri);
  }

  getPerson(id: number): Observable<Person> {
    return this.http.get<Person>(serverUri + id);
  }

  insertCat(person: Person): Observable<Person> {
    return this.http.post<Person>(serverUri, person);
  }

  updateCat(person: Person): Observable<void> {
    return this.http.put<void>(serverUri + person.id, person);
  }

  deleteCat(id: number) {
    return this.http.delete(serverUri + id);
  }
}
