import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-datapage',
  templateUrl: './datapage.component.html',
  styleUrl: './datapage.component.css'
})
export class DatapageComponent implements OnInit{
  firstName: string | undefined;
  lastName: string | undefined;
  email: string | undefined;
  password: string | undefined;

  constructor(private route:ActivatedRoute){}

  ngOnInit(): void {
      const params: Params = this.route.snapshot.queryParams;
      this.firstName = params['firstName'],
      this.lastName = params['lastName'],
      this.email = params['email'],
      this.password = params['password']
    }
}
