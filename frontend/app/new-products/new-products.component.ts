import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../domain/repository/products.service';
import { Product } from '../domain/entity/product';


@Component({
  selector: 'app-new-products',
  templateUrl: './new-products.component.html',
  styleUrls: ['./new-products.component.less']
})
export class NewProductsComponent implements OnInit {

  products: Product[];
  cartCount: number = 0;
  cartTotalPrice: number = 0;


  constructor(
    private productsService: ProductsService
  ) { }

  ngOnInit(): void {

    this.productsService.getProducts().subscribe(data=>{
      this.products = data;
    });

  }

  addCart(product: Product): void{
    this.cartCount = this.cartCount + 1;
    this.cartTotalPrice = this.cartTotalPrice + product.price;
    console.log("on click");
    console.log(this.cartCount);
    this.productsService.cartCountEvent.emit(this.cartCount.toString());
    this.productsService.cartTotalPriceEvent.emit(this.cartTotalPrice.toString());
  }

}
