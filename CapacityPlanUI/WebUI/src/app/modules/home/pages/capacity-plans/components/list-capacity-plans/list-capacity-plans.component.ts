import { Component, OnInit } from '@angular/core';
import { CapacityPlanTableCountPerPage } from 'src/app/core/constants/count-per-page';
import { CapacityPlanQueryParameters } from 'src/app/core/models/request/capacity-plan/capacity-plan-query-params.model';
import { HeaderPagination } from 'src/app/core/models/request/header-pagination.model';
import { CapacityPlanResponse } from 'src/app/core/models/response/capacity-plan/capacity-plan-response.model';
import { CapacityPlanService } from 'src/app/core/services';


@Component({
  selector: 'app-list-capacity-plans',
  templateUrl: './list-capacity-plans.component.html',
  styleUrls: ['./list-capacity-plans.component.scss']
})
export class ListCapacityPlansComponent implements OnInit {

  currentPage = 1;
  pageSize = 5;
  paginationSize = CapacityPlanTableCountPerPage;
  totalRecords = 0;
  searchText: string;
  orderBy: string = 'id';

  capacityPlans: CapacityPlanResponse[] = [];

  constructor(private capacityPlanService: CapacityPlanService) {
  }

  changePageSize(pageSize: number) {
      this.pageSize = pageSize;
      this.loadCapacityPlans();
  }

  changePage(page: number) {
      this.currentPage = page;
      this.loadCapacityPlans();
  }


  loadCapacityPlans(){
    const queryParams: CapacityPlanQueryParameters = new CapacityPlanQueryParameters();
    queryParams.OrderBy = 'id';
    queryParams.pageNumber = this.currentPage;
    queryParams.pageSize = this.pageSize;
    queryParams.searchKeyword = this.searchText ?? '';
    queryParams.skipPageSize = false;
    queryParams.orderBy = this.orderBy;

    this.capacityPlanService.getAllCapacityPlans(queryParams).subscribe((response)=>{
      this.capacityPlans = response.body;

      let headerPaginationValues = new HeaderPagination();
      headerPaginationValues = JSON.parse(response.headers.get('X-Pagination'));
      this.totalRecords = headerPaginationValues.totalCount;

    })
  }

  ngOnInit(): void {
    this.loadCapacityPlans();
  }

}
