import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MedicineService {
  constructor(private http:HttpClient){}
  getAllProducts() : any {
    return this.http.get('https://localhost:7000/api/Product');
  }

  getProductById(id:any) : any {
    return this.http.get(`https://localhost:7000/api/Product/${id}`);
  }

  addUser(user: any) : any {
    return this.http.post('https://localhost:7000/api/Customer', user);
  }

  getAllOrderDetails(): any{
    return this.http.get('https://localhost:7000/api/Order/Procedure');
  }

  getCustomerByProduct(id:any) : any{
    return this.http.get(`https://localhost:7000/api/Customer/GetCustomerbyProductId/${id}`)
  }

  addOrder(order:any): any{
    return this.http.post("https://localhost:7000/api/Order", order);
  }

  reduceQuantity(id:any, qnt:any){
    return this.http.put(`https://localhost:7000/api/Product/reduceQuantity/${id}?quantity=${qnt}`,{});
  }
}
