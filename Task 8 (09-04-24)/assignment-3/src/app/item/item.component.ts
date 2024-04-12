import { Component, OnInit } from '@angular/core';
import { MedicineService } from '../services/medicine.service';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
    selector: 'app-item',
    templateUrl: './item.component.html',
    styleUrl: './item.component.css',
    standalone: true,
    imports: [NavbarComponent, RouterLink]
})
export class ItemComponent implements OnInit{
  id: number | undefined;
  item: any | undefined;
  star: string = "";
  constructor(private medicineservice:MedicineService, private activeroute:ActivatedRoute){}
    
  ngOnInit(): void {
    this.id = this.activeroute.snapshot.params['id'];
    this.item = this.medicineservice.medicine.find(med => med.mid == this.id);
    for(let i=1; i<=this.item.mrating; i++){
      this.star += "⭐";
    }
    console.log(this.item);
  }
}
