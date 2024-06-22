import { Component, OnInit } from '@angular/core';
import { MedicineService } from '../services/medicine.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrl: './item.component.css'
})
export class ItemComponent implements OnInit{
  id: number | undefined;
  item: any;
  star: any = "";
  constructor(private service:MedicineService, private activeroute:ActivatedRoute){}
    
  ngOnInit(): void {
    this.id = this.activeroute.snapshot.params['id'];

    this.service.getProductById(this.id).subscribe((data:any)=>{
        this.item = data
        for(let i=1; i<=data.rating; i++){
        this.star += "⭐";
      }
    });
  }
}
