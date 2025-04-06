import { Routes } from '@angular/router';
import {HomeViewComponentComponent} from './components/views/home-view-component/home-view-component.component';
import {
  ProductsViewComponentComponent
} from './components/views/products-view-component/products-view-component.component';
import {
  AddProductViewComponent
} from './components/views/add-product-view-component/add-product-view.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeViewComponentComponent,
  },
  {
    path: 'products',
    component: ProductsViewComponentComponent,
  },
  {
    path: 'products/add',
    component: AddProductViewComponent,
  },
];
