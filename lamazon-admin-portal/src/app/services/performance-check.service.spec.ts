import { TestBed } from '@angular/core/testing';

import { PerformanceCheckService } from './performance-check.service';

describe('PerformanceCheckService', () => {
  let service: PerformanceCheckService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PerformanceCheckService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
