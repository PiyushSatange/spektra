import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url = "http://localhost:3000/products";
  constructor(private http:HttpClient) { }

  getAllProducts(){
    return this.http.get(this.url);
  }

  addProduct(product){
    return this.http.post(this.url, product);
  }

  deleteProduct(id){
    return this.http.delete(`${this.url}/${id}`);
  }

  getProductById(id){
    return this.http.get(`${this.url}/${id}`);
  }

  updateProduct(id, data){
    return this.http.put(`${this.url}/${id}`, data);
  }
}
