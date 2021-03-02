import { EventEmitter, Injectable } from '@angular/core';
import { Observable, of, } from 'rxjs';
import { catchError, map, tap, retry, mergeMap } from 'rxjs/operators';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Product } from '../entity/product';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  cartCountEvent: EventEmitter<string> = new EventEmitter();
  cartTotalPriceEvent: EventEmitter<string> = new EventEmitter();

  constructor(private http: HttpClient) { }

  addCustomer() {    
    console.log("hello world products");
  }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(
      'http://localhost:5000/api/v1/products'
    );
  }

}
