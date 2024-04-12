import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomedecoreComponent } from './homedecore.component';

describe('HomedecoreComponent', () => {
  let component: HomedecoreComponent;
  let fixture: ComponentFixture<HomedecoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HomedecoreComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HomedecoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
