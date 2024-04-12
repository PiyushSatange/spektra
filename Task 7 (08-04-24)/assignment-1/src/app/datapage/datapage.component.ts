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
      this.firstName = history.state.first;
      this.lastName = history.state.last;
      this.email = history.state.email;
      this.password = history.state.pass;
    }
  }
