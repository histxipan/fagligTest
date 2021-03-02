import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { BannerComponent } from './banner/banner.component';
import { LinkComponent } from './link/link.component';
import { NewProductsComponent } from './new-products/new-products.component';
import { CartComponent } from './cart/cart.component';
import { PopularProductsComponent } from './popular-products/popular-products.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';


@NgModule({
  declarations: [
    AppComponent,
    BannerComponent,
    LinkComponent,
    NewProductsComponent,
    CartComponent,
    PopularProductsComponent,
    ProductDetailComponent
  ],
  imports: [
    BrowserModule,
    FlexLayoutModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
