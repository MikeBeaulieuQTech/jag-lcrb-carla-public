import { Injectable } from '@angular/core';
import { Response, Http } from '@angular/http';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { AdoxioWorker } from '../models/adoxio-worker.model';
import { Observable } from 'rxjs';
import { of } from 'rxjs/observable/of';

@Injectable()
export class WorkerDataService {

  headers: HttpHeaders = new HttpHeaders({
    'Content-Type': 'application/json'
  });

  constructor(private http: HttpClient) { }

  /**
   * Get legal entities from Dynamics filtered by position
   * @param positionType
   */
  getWorker(accountId: string) {
    const apiPath = `api/worker/${accountId}`;
    return this.http.get<AdoxioWorker>(apiPath, { headers: this.headers })
      .pipe(catchError(this.handleError("getWorker", null)));
  }

  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createWorker(data: any) {
    return this.http.post<AdoxioWorker>('api/worker/', data, { headers: this.headers })
      .pipe(catchError(this.handleError("createWorker", null)));
  }

  /**
   * update a  legal entity in Dynamics
   * @param data - legal entity data
   */
  updateWorker(data: any, id: string) {
    return this.http.put<AdoxioWorker>(`api/worker/${id}`, data, { headers: this.headers })
      .pipe(catchError(this.handleError("updateWorker", null)));
  }

  /**
   * delete a  legal entity in Dynamics
   * @param data - legal entity data
   */
  deleteWorker(id: string) {
    return this.http.post<AdoxioWorker>(`api/worker/${id}/delete`, {}, { headers: this.headers })
      .pipe(catchError(this.handleError("deleteWorker", null)));
  }

  /**
   * Handle error
   * @param error
   */

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(`${operation} failed: ${error.message}`); // log to console instead


      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}