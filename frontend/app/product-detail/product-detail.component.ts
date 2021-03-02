import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.less']
})
export class ProductDetailComponent implements OnInit {

  test: string = "wait";
  constructor(
    private _route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this._route.queryParams.subscribe(params => {
      //this.test = JSON.parse(params.record) as string;
      this.test = params.record as string;
      console.log(params);
      console.log('params');
  });
  }

}
