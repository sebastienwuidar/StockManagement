import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';

@Component({
  selector: 'app-add-product-view-component',
  imports: [
    FormsModule,
    ReactiveFormsModule
  ],
  templateUrl: './add-product-view.component.html',
  styleUrl: './add-product-view.component.css'
})
export class AddProductViewComponent implements OnInit {
  productForm!: FormGroup;

  constructor(private formBuilder: FormBuilder) {
  }

  ngOnInit() {
    this.productForm = this.formBuilder.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      quantity: ['', [Validators.required]],
      price: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.productForm.valid) {

    }
  }
}
