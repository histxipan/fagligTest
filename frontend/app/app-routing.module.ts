import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { NewProductsComponent } from './new-products/new-products.component';

const routes: Routes = [
  { path: '', component: NewProductsComponent },
  { path: 'product-detail', component: ProductDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
