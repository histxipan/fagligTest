import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../domain/repository/products.service';


@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.less']
})
export class CartComponent implements OnInit {

  cartCount: string = '0';
  cartTotalPrise: string = '0';

  constructor(
    private productsService: ProductsService
  ) { 

    this.productsService.cartCountEvent.subscribe((data: string) => {
      this.cartCount = data;
    });
    
    this.productsService.cartTotalPriceEvent.subscribe((data: string) => {
      this.cartTotalPrise = data;
    });

  }

  ngOnInit(): void {
  }

}
