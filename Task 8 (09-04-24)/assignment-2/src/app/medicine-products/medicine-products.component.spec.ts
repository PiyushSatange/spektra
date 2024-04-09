import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MedicineProductsComponent } from './medicine-products.component';

describe('MedicineProductsComponent', () => {
  let component: MedicineProductsComponent;
  let fixture: ComponentFixture<MedicineProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MedicineProductsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MedicineProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
