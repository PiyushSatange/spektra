import { Component, OnInit } from '@angular/core';
import { UserService } from './service/user.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  userData: any | undefined;

  constructor(private userService: UserService) {}

  ngOnInit(){
    this.userService.getAllUsers().subscribe((allUsers) => {
      this.userData = allUsers;
    });
  }
}