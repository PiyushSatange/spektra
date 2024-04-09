import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrl: './child.component.css'
})
export class ChildComponent {
  @Input() TotalStudent : number | undefined;
  @Input() TotalFemale : number | undefined;
  @Input() TotalMale :number | undefined;
}
