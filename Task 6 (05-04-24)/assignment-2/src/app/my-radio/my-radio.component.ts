import { Component } from '@angular/core';

@Component({
  selector: 'app-my-radio',
  templateUrl: './my-radio.component.html',
  styleUrl: './my-radio.component.css'
})
export class MyRadioComponent {
  isValid : boolean | undefined;

  checkValid(value:string){
    if(value=="valid"){
      this.isValid = true;
    }
    else{
      this.isValid = false;
    }
  }
}
