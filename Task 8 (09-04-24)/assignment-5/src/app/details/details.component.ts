import { Component } from '@angular/core';
import { TechpeopleService } from '../service/techpeople.service';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {
  params: Params | undefined;
  person: any | undefined;
  id: any = "";
  constructor(private techpeopleservice:TechpeopleService, private activeroute:ActivatedRoute){}
  ngOnInit(): void {
    this.id = this.activeroute.snapshot.paramMap.get('id');
    this.person = this.techpeopleservice.techPeople.find(person => this.id == person.id);
    console.log(this.person);
  }
}
