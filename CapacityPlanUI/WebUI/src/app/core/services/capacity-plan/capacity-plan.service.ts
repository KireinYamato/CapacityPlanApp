import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CapacityPlanResponse } from '../../models/response/capacity-plan/capacity-plan-response.model';
import { HttpBaseService } from '../auth/http-base/http-base.service';
import { catchError } from 'rxjs';
import { CapacityPlanQueryParameters } from '../../models/request/capacity-plan/capacity-plan-query-params.model';

@Injectable({
  providedIn: 'root'
})
export class CapacityPlanService extends HttpBaseService{

  private baseURL = '';

  constructor(private http: HttpClient) {
    super();
    this.baseURL = environment.apiUrl;
   }

  getAllCapacityPlans(capacityPlanQueryParameters: CapacityPlanQueryParameters){
    const url = `${this.baseURL}/CapacityPlan`;
    return this.http.get<CapacityPlanResponse>(url, {
      params: this.convertToHttpParam(capacityPlanQueryParameters),
      observe: 'response'
    }).pipe(catchError(this.handleError));
  }

}
