import { Component } from '@angular/core';

@Component({
  selector: 'app-myform',
  templateUrl: './myform.component.html',
  styleUrl: './myform.component.css'
})
export class MyformComponent {
  isDisable = true;
  name:string = "";
  age:number = 0;
  checkPress(key:any){
    var inputValue1 = (<HTMLInputElement>document.getElementById("text1")).value;
    var inputValue2 = (<HTMLInputElement>document.getElementById("text2")).value;
    if(inputValue1 != "" && inputValue2 != ""){
      this.isDisable = false;
    }
    else{
      this.isDisable = true;
    }
  }

  showData(){
    var name = (<HTMLInputElement>document.getElementById("text1")).value;
    var age = (<HTMLInputElement>document.getElementById("text2")).value;
    this.name = name;
    this.age = Number(age);
  }
}
