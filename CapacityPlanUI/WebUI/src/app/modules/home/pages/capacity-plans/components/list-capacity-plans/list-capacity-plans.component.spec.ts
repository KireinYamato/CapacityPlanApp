import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListCapacityPlansComponent } from './list-capacity-plans.component';

describe('ListCapacityPlansComponent', () => {
  let component: ListCapacityPlansComponent;
  let fixture: ComponentFixture<ListCapacityPlansComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListCapacityPlansComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListCapacityPlansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
