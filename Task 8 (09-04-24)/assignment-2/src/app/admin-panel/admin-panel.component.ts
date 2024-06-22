import { Component, OnInit } from '@angular/core';
import { MedicineService } from '../services/medicine.service';

@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrl: './admin-panel.component.css'
})
export class AdminPanelComponent implements OnInit{

  medArr: any;
  constructor(private service: MedicineService){} 
  ngOnInit(): void {
    this.service.getAllProducts().subscribe((data:any) =>{
      this.medArr = data;
      console.log(this.medArr);
    })
  }
}
