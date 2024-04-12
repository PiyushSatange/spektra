import { TestBed } from '@angular/core/testing';

import { TechpeopleService } from './techpeople.service';

describe('TechpeopleService', () => {
  let service: TechpeopleService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TechpeopleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
