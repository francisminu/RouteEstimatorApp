import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpErrorResponse, HttpResponse } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { RouteSchedule } from '../response-models/route.schedule';
import { GetRouteScheduleRequestModel } from '../request-models/route-schedule-request-model';

export interface Config {
  heroesUrl: string;
  textfile: string;
  date: any;
}

@Injectable()
export class ApiService {
  configUrl = 'assets/config.json';

  constructor(private http: HttpClient) { }

  getConfigResponse(requestModel: GetRouteScheduleRequestModel): Observable<HttpResponse<any>> {
    console.log(`Date time being passed is ${requestModel.currentTime}`)
      var returnVal = this.http.put<RouteSchedule>(
      "https://localhost:44328/api",  requestModel, { observe: 'response' });
      return returnVal;
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // Return an observable with a user-facing error message.
    return throwError(
      'Something bad happened; please try again later.');
  }
}
