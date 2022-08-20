import { Component, OnDestroy, OnInit } from '@angular/core';
import { NgbModal, NgbModalOptions, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgxSpinnerService } from 'ngx-spinner';
import { Subject, takeUntil } from 'rxjs';
import { CapacityPlanTableCountPerPage } from 'src/app/core/constants/count-per-page';
import { CapacityPlanQueryParameters } from 'src/app/core/models/request/capacity-plan/capacity-plan-query-params.model';
import { HeaderPagination } from 'src/app/core/models/request/header-pagination.model';
import { CapacityPlanResponse } from 'src/app/core/models/response/capacity-plan/capacity-plan-response.model';
import { CapacityPlanService } from 'src/app/core/services';
import { AddCapacityPlansComponent } from '../add-capacity-plans/add-capacity-plans.component';
import { EditCapacityPlansComponent } from '../edit-capacity-plans/edit-capacity-plans.component';

const Swal = require('sweetalert2')

@Component({
  selector: 'app-list-capacity-plans',
  templateUrl: './list-capacity-plans.component.html',
  styleUrls: ['./list-capacity-plans.component.scss']
})
export class ListCapacityPlansComponent implements OnInit, OnDestroy {

  destroySubscriptions$ = new Subject();

  modalRef: NgbModalRef;

  currentPage = 1;
  pageSize = 5;
  paginationSize = CapacityPlanTableCountPerPage;
  totalRecords = 0;
  searchText: string;
  orderBy: string = 'id';

  spinner = 'spinner-capacityplan-table';

  capacityPlans: CapacityPlanResponse[] = [];

  constructor(
    private ngModalService: NgbModal,
    private spinnerService: NgxSpinnerService,
    private capacityPlanService: CapacityPlanService) {
  }

  ngOnDestroy(): void {
    this.destroySubscriptions$.next(true);
  }

  changePageSize(pageSize: number) {
      this.pageSize = pageSize;
      this.loadCapacityPlans();
  }

  changePage(page: number) {
      this.currentPage = page;
      this.loadCapacityPlans();
  }


  openCreateModal(){
    this.modalRef = this.ngModalService.open(AddCapacityPlansComponent);
    
    this.modalRef.result.then((result) => {
      if (result && result === true) {
        this.loadCapacityPlans();
        var Toast = Swal.mixin({
          toast: true,
          position: 'top-end',
          showConfirmButton: false,
          timer: 3000
        });
    
        Toast.fire({
          icon: 'success',
          title: 'Capacity Plan Created!'
        });
      }
    });
  }

  openEdit(id){
    this.modalRef = this.ngModalService.open(EditCapacityPlansComponent);
    // fills the edit capacity plans component input id
    this.modalRef.componentInstance.id = id;

    this.modalRef.result.then((result) => {
      if (result && result === true) {
        this.loadCapacityPlans();
        var Toast = Swal.mixin({
          toast: true,
          position: 'top-end',
          showConfirmButton: false,
          timer: 3000
        });
    
        Toast.fire({
          icon: 'success',
          title: 'Capacity Plan Updated!'
        });
      }
    });
  }

  loadCapacityPlans(){
    /** spinner starts on init */
    this.spinnerService.show(this.spinner);

    const queryParams: CapacityPlanQueryParameters = new CapacityPlanQueryParameters();
    queryParams.OrderBy = 'id';
    queryParams.pageNumber = this.currentPage;
    queryParams.pageSize = this.pageSize;
    queryParams.searchKeyword = this.searchText ?? '';
    queryParams.skipPageSize = false;
    queryParams.orderBy = this.orderBy;

    this.capacityPlanService.getAllCapacityPlans(queryParams)
    .pipe(
      takeUntil(this.destroySubscriptions$),
    )
    .subscribe((response)=>{
      this.capacityPlans = response.body;

      let headerPaginationValues = new HeaderPagination();
      headerPaginationValues = JSON.parse(response.headers.get('X-Pagination'));
      this.totalRecords = headerPaginationValues.totalCount;

    });

    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinnerService.hide(this.spinner);
    }, 2000);
  }

  ngOnInit(): void {
    this.loadCapacityPlans();
  }

}
