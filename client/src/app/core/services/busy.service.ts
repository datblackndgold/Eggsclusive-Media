/*import { Injectable } from '@angular/core';
import {NgxSpinnerService} from 'ngx-spinner'

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequestCount = 0;

  constructor(private spinnerService: NgxSpinnerService) { }

  busy() {
    this.busyRequestCount++;
    this.spinnerService.show(undefined, {
      bdColor: 'rgba(255,255,255,0.7)',
      template:"<img src='https://media.giphy.com/media/3oEdvdEl6fCc53I0Za/giphy.gif' />" 
    });
  }

  idle() {
    this.busyRequestCount--;
    if (this.busyRequestCount <=0) {
      this.busyRequestCount = 0;
      this.spinnerService.hide();
    }
  }
}
*/