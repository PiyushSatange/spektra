import { Component } from '@angular/core';
import { TechpeopleService } from '../service/techpeople.service';

@Component({
  selector: 'app-people-list',
  templateUrl: './people-list.component.html',
  styleUrl: './people-list.component.css'
})
export class PeopleListComponent {
  people: Array<any> | undefined;
  constructor(private techpeople:TechpeopleService){
    this.people = techpeople.techPeople;
  }
}
