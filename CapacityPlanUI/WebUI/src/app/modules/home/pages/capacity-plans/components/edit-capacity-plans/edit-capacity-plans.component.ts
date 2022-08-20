import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ModalDismissReasons, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { NgxSpinnerService } from 'ngx-spinner';
import { Subject, takeUntil } from 'rxjs';
import { CapacityPlanStatus } from 'src/app/core/enums/capacity-plan-status.enum';
import { CapacityPlanCreate } from 'src/app/core/models/request/capacity-plan/capacity-plan-create.model';
import { CapacityPlanDetails } from 'src/app/core/models/request/capacity-plan/capacity-plan-details.model';
import { CapacityPlanUpdate } from 'src/app/core/models/request/capacity-plan/capacity-plan-update.model';
import { CapacityPlanResponse } from 'src/app/core/models/response/capacity-plan/capacity-plan-response.model';
import { CapacityPlanService } from 'src/app/core/services';

@Component({
  selector: 'app-edit-capacity-plans',
  templateUrl: './edit-capacity-plans.component.html',
  styleUrls: ['./edit-capacity-plans.component.scss']
})
export class EditCapacityPlansComponent implements OnInit, OnDestroy {

  @Input() id = '';

  capacityPlanForm: FormGroup;

  destroySubscriptions$ = new Subject();

  capacityPlansResponse: CapacityPlanResponse;

  spinner = 'spinner-capacityplan-edit';

  constructor(
    public activeModal: NgbActiveModal,
    private formBuilder: FormBuilder,
    public capacityPlanService: CapacityPlanService,
    private spinnerService: NgxSpinnerService
  ) { 
    this.initializeForm();
  }

  ngOnDestroy(): void {
    this.destroySubscriptions$.next(true);
  }

  ngOnInit(): void {
    this.populateForm();
  }

  accept(){
    this.activeModal.close(true);
  }

  dismiss() {
    this.activeModal.close(false);
  }

  submit(){
      const capacityplanUpdateModel = new CapacityPlanUpdate();
      capacityplanUpdateModel.capacityPlanDetails.capacityPlanRefId = +this.capacityPlanForm.controls['capacityPlanId'].value;
      capacityplanUpdateModel.capacityPlanDetails.name = this.capacityPlanForm.controls['capacityPlanName'].value;
      capacityplanUpdateModel.capacityPlanDetails.project.name = this.capacityPlanForm.controls['projectName'].value;
      capacityplanUpdateModel.capacityPlanDetails.language.name = this.capacityPlanForm.controls['language'].value;
      capacityplanUpdateModel.capacityPlanDetails.workStream.name = this.capacityPlanForm.controls['workStream'].value;
      capacityplanUpdateModel.capacityPlanDetails.channel.name = this.capacityPlanForm.controls['channel'].value;
      capacityplanUpdateModel.capacityPlanDetails.billingModel.name = this.capacityPlanForm.controls['billingModel'].value;
      capacityplanUpdateModel.capacityPlanDetails.locationDetails.geography.name = this.capacityPlanForm.controls['geography'].value;
      capacityplanUpdateModel.capacityPlanDetails.locationDetails.country.name = this.capacityPlanForm.controls['country'].value;
      capacityplanUpdateModel.capacityPlanDetails.locationDetails.city.name = this.capacityPlanForm.controls['city'].value;

      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.deliveryLead.firstName = this.capacityPlanForm.controls['deliveryLeadFirstName'].value;
      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.deliveryLead.middleName = this.capacityPlanForm.controls['deliveryLeadMiddleName'].value;
      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.deliveryLead.lastName = this.capacityPlanForm.controls['deliveryLeadLastName'].value;

      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.wccLead.firstName = this.capacityPlanForm.controls['wccLeadFirstName'].value;
      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.wccLead.middleName = this.capacityPlanForm.controls['wccLeadMiddleName'].value;
      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.wccLead.lastName = this.capacityPlanForm.controls['wccLeadLastName'].value;

      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.pocLead.firstName = this.capacityPlanForm.controls['pocLeadFirstName'].value;
      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.pocLead.middleName = this.capacityPlanForm.controls['pocLeadMiddleName'].value;
      capacityplanUpdateModel.capacityPlanDetails.peopleDetails.pocLead.lastName = this.capacityPlanForm.controls['pocLeadLastName'].value;
      // capacityplanUpdateModel.capacityPlanDetails.name = this.capacityPlanForm.controls['capacityPlanName'].value;
      // capacityplanUpdateModel.capacityPlanDetails.name = this.capacityPlanForm.controls['capacityPlanName'].value;

      capacityplanUpdateModel.capacityPlanDetails = capacityplanUpdateModel.capacityPlanDetails;
      console.log(this.capacityPlanForm.controls['status'].value)
      switch (this.capacityPlanForm.controls['status'].value) {
        case "0":
          capacityplanUpdateModel.status = CapacityPlanStatus.Live;
          break;
        case "1":
          capacityplanUpdateModel.status = CapacityPlanStatus.Draft;
          break;
        case "2":
          capacityplanUpdateModel.status = CapacityPlanStatus.Deactivated;
          break;
        case "3":
          capacityplanUpdateModel.status = CapacityPlanStatus.Deleted;
          break;            
      }

      this.capacityPlanService.editCapacityPlan(capacityplanUpdateModel, this.id)
      .pipe(
        takeUntil(this.destroySubscriptions$),
      ).subscribe((response)=>{
        this.activeModal.close(true);
      });

      
  }

  initializeForm(){

    this.capacityPlanForm = this.formBuilder.group({
      capacityPlanId: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      capacityPlanName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      projectName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      language: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      workStream: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      channel: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      billingModel: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      geography: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      country: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      city: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      deliveryLeadFirstName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      deliveryLeadMiddleName: new FormControl(''), 
      deliveryLeadLastName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      wccLeadFirstName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      wccLeadMiddleName: new FormControl(''), 
      wccLeadLastName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      pocLeadFirstName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      pocLeadMiddleName: new FormControl(''), 
      pocLeadLastName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(45)])),
      status: new FormControl(0, Validators.compose([Validators.required, Validators.maxLength(45)])),
    });
  }

  populateForm(){
    /** spinner starts on init */
    this.spinnerService.show(this.spinner);

    // get the capacity plan first by id to fetch all the details needed
    this.capacityPlanService.getCapacityPlanById(this.id)
    .pipe(
      takeUntil(this.destroySubscriptions$),
    ).subscribe((response)=>{
        this.capacityPlansResponse = response;
        this.capacityPlanForm.setValue({
          capacityPlanId: this.capacityPlansResponse.capacityPlanDetails.capacityPlanRefId,
          capacityPlanName: this.capacityPlansResponse.capacityPlanDetails.name,
          projectName: this.capacityPlansResponse.capacityPlanDetails.project.name,
          language: this.capacityPlansResponse.capacityPlanDetails.language.name,
          workStream: this.capacityPlansResponse.capacityPlanDetails.workstream.name,
          channel: this.capacityPlansResponse.capacityPlanDetails.channel.name,
          billingModel: this.capacityPlansResponse.capacityPlanDetails.billingModel.name,
          geography: this.capacityPlansResponse.capacityPlanDetails.locationDetails.geography.name,
          country: this.capacityPlansResponse.capacityPlanDetails.locationDetails.country.name,
          city: this.capacityPlansResponse.capacityPlanDetails.locationDetails.city.name,
          deliveryLeadFirstName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.deliveryLead.firstName,
          deliveryLeadMiddleName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.deliveryLead.middleName,
          deliveryLeadLastName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.deliveryLead.lastName,
          wccLeadFirstName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.wccLead.firstName,
          wccLeadMiddleName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.wccLead.middleName,
          wccLeadLastName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.wccLead.lastName,
          pocLeadFirstName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.pocLead.firstName,
          pocLeadMiddleName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.pocLead.middleName,
          pocLeadLastName: this.capacityPlansResponse.capacityPlanDetails.peopleDetails.pocLead.lastName,
          status: this.capacityPlansResponse.status,          
        });
    });

    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinnerService.hide(this.spinner);
    }, 2000);

  }
}
