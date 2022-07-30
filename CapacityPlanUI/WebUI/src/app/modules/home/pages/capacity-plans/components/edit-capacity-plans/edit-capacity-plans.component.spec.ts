import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCapacityPlansComponent } from './edit-capacity-plans.component';

describe('EditCapacityPlansComponent', () => {
  let component: EditCapacityPlansComponent;
  let fixture: ComponentFixture<EditCapacityPlansComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditCapacityPlansComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditCapacityPlansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
