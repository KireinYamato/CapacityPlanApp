import { TestBed } from '@angular/core/testing';

import { CapacityPlanService } from './capacity-plan.service';

describe('CapacityPlanService', () => {
  let service: CapacityPlanService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CapacityPlanService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
