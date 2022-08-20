import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ModalDismissReasons, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Subject, takeUntil } from 'rxjs';
import { CapacityPlanStatus } from 'src/app/core/enums/capacity-plan-status.enum';
import { CapacityPlanCreate } from 'src/app/core/models/request/capacity-plan/capacity-plan-create.model';
import { CapacityPlanDetails } from 'src/app/core/models/request/capacity-plan/capacity-plan-details.model';
import { CapacityPlanService } from 'src/app/core/services';

@Component({
  selector: 'app-add-capacity-plans',
  templateUrl: './add-capacity-plans.component.html',
  styleUrls: ['./add-capacity-plans.component.scss']
})
export class AddCapacityPlansComponent implements OnInit, OnDestroy {

  capacityPlanForm: FormGroup;

  destroySubscriptions$ = new Subject();

  constructor(
    public activeModal: NgbActiveModal,
    private formBuilder: FormBuilder,
    public capacityPlanService: CapacityPlanService
  ) { }

  ngOnDestroy(): void {
    this.destroySubscriptions$.next(true);
  }

  ngOnInit(): void {
    this.initializeForm();
  }

  accept(){
    this.activeModal.close(true);
  }

  dismiss() {
    this.activeModal.close(false);
  }

  submit(){
      const capacityplanCreateModel = new CapacityPlanCreate();
      capacityplanCreateModel.capacityPlanDetails.capacityPlanRefId = +this.capacityPlanForm.controls['capacityPlanId'].value;
      capacityplanCreateModel.capacityPlanDetails.name = this.capacityPlanForm.controls['capacityPlanName'].value;
      capacityplanCreateModel.capacityPlanDetails.project.name = this.capacityPlanForm.controls['projectName'].value;
      capacityplanCreateModel.capacityPlanDetails.language.name = this.capacityPlanForm.controls['language'].value;
      capacityplanCreateModel.capacityPlanDetails.workStream.name = this.capacityPlanForm.controls['workStream'].value;
      capacityplanCreateModel.capacityPlanDetails.channel.name = this.capacityPlanForm.controls['channel'].value;
      capacityplanCreateModel.capacityPlanDetails.billingModel.name = this.capacityPlanForm.controls['billingModel'].value;
      capacityplanCreateModel.capacityPlanDetails.locationDetails.geography.name = this.capacityPlanForm.controls['geography'].value;
      capacityplanCreateModel.capacityPlanDetails.locationDetails.country.name = this.capacityPlanForm.controls['country'].value;
      capacityplanCreateModel.capacityPlanDetails.locationDetails.city.name = this.capacityPlanForm.controls['city'].value;

      capacityplanCreateModel.capacityPlanDetails.peopleDetails.deliveryLead.firstName = this.capacityPlanForm.controls['deliveryLeadFirstName'].value;
      capacityplanCreateModel.capacityPlanDetails.peopleDetails.deliveryLead.middleName = this.capacityPlanForm.controls['deliveryLeadMiddleName'].value;
      capacityplanCreateModel.capacityPlanDetails.peopleDetails.deliveryLead.lastName = this.capacityPlanForm.controls['deliveryLeadLastName'].value;

      capacityplanCreateModel.capacityPlanDetails.peopleDetails.wccLead.firstName = this.capacityPlanForm.controls['wccLeadFirstName'].value;
      capacityplanCreateModel.capacityPlanDetails.peopleDetails.wccLead.middleName = this.capacityPlanForm.controls['wccLeadMiddleName'].value;
      capacityplanCreateModel.capacityPlanDetails.peopleDetails.wccLead.lastName = this.capacityPlanForm.controls['wccLeadLastName'].value;

      capacityplanCreateModel.capacityPlanDetails.peopleDetails.pocLead.firstName = this.capacityPlanForm.controls['pocLeadFirstName'].value;
      capacityplanCreateModel.capacityPlanDetails.peopleDetails.pocLead.middleName = this.capacityPlanForm.controls['pocLeadMiddleName'].value;
      capacityplanCreateModel.capacityPlanDetails.peopleDetails.pocLead.lastName = this.capacityPlanForm.controls['pocLeadLastName'].value;
      // capacityplanCreateModel.capacityPlanDetails.name = this.capacityPlanForm.controls['capacityPlanName'].value;
      // capacityplanCreateModel.capacityPlanDetails.name = this.capacityPlanForm.controls['capacityPlanName'].value;

      capacityplanCreateModel.capacityPlanDetails = capacityplanCreateModel.capacityPlanDetails;
      console.log(this.capacityPlanForm.controls['status'].value)
      switch (this.capacityPlanForm.controls['status'].value) {
        case "0":
          capacityplanCreateModel.status = CapacityPlanStatus.Live;
          break;
        case "1":
          capacityplanCreateModel.status = CapacityPlanStatus.Draft;
          break;
        case "2":
          capacityplanCreateModel.status = CapacityPlanStatus.Deactivated;
          break;
        case "3":
          capacityplanCreateModel.status = CapacityPlanStatus.Deleted;
          break;            
      }

      this.capacityPlanService.addCapacityPlan(capacityplanCreateModel)
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

}
