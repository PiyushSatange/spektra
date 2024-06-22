import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  Products : any;


  constructor(private http: HttpClient) { }

  getData(): any {
    return this.http.get('https://localhost:7120/api/Product/GetAllProducts');
  };

  buyMethod(id: number, qnt: number): any {
    return this.http.put(`https://localhost:7120/api/Product/buyProduct/${id}?qnt=${qnt}`, {});
  };
}