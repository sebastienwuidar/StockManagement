import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductsViewComponentComponent } from './products-view-component.component';

describe('ProductsViewComponentComponent', () => {
  let component: ProductsViewComponentComponent;
  let fixture: ComponentFixture<ProductsViewComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductsViewComponentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductsViewComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
