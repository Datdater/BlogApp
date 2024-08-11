import { Component } from '@angular/core';
import {AddCategoryRequestModel} from "../models/add-category-request.model";

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent {

  model: AddCategoryRequestModel;

  constructor() {
    this.model = {
      name: '',
      urlHandle: 'dammm'
    }
  }
  onFormSubmit(){
    console.log(this.model)
  }
}
