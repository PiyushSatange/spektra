import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-buypage',
  templateUrl: './buypage.component.html',
  styleUrl: './buypage.component.css'
})
export class BuypageComponent {
  id:any;
  url:any;
  price:any;
  quantity:any;
  constructor(private router: Router, private route: ActivatedRoute, private http: HttpClient, private service: ServiceService){
    this.id = history.state.id;
    this.url = history.state.url;
    this.price = history.state.price;
    this.quantity = history.state.qnt;
    console.log(this.id, this.url, this.price, this.quantity);
  }
  buyNow(id:number, qnt:any){
    if(qnt > this.quantity){
      alert("Please reduce your quantity");
    }
    else{
      this.service.buyMethod(id, qnt).subscribe();
      this.router.navigate(['/success']);
    }
    
  }
}
