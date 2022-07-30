import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCapacityPlansComponent } from './add-capacity-plans.component';

describe('AddCapacityPlansComponent', () => {
  let component: AddCapacityPlansComponent;
  let fixture: ComponentFixture<AddCapacityPlansComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCapacityPlansComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCapacityPlansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
