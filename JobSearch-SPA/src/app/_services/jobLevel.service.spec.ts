/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { JobLevelService } from './jobLevel.service';

describe('Service: JobLevel', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [JobLevelService]
    });
  });

  it('should ...', inject([JobLevelService], (service: JobLevelService) => {
    expect(service).toBeTruthy();
  }));
});
