using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace CapacityPlanApp.Database
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CapacityPlanTarget",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    asa = table.Column<double>(type: "double", nullable: false),
                    sl_target = table.Column<double>(type: "double", nullable: false),
                    service_time = table.Column<double>(type: "double", nullable: false),
                    answer_rate = table.Column<double>(type: "double", nullable: false),
                    aba_rate = table.Column<double>(type: "double", nullable: false),
                    aht_cap = table.Column<double>(type: "double", nullable: false),
                    ticket_per_hr = table.Column<double>(type: "double", nullable: false),
                    ideal_occ = table.Column<double>(type: "double", nullable: false),
                    utilization = table.Column<double>(type: "double", nullable: false),
                    res_rate = table.Column<double>(type: "double", nullable: false),
                    line_adh = table.Column<double>(type: "double", nullable: false),
                    date_from = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_to = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacityPlanTarget", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CapacityPlanWorkload",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fte_time_conv = table.Column<double>(type: "double", nullable: false),
                    plan_aht = table.Column<double>(type: "double", nullable: false),
                    concurency = table.Column<double>(type: "double", nullable: false),
                    billable_fte = table.Column<double>(type: "double", nullable: false),
                    hc_req = table.Column<double>(type: "double", nullable: false),
                    prod_hr_req = table.Column<double>(type: "double", nullable: false),
                    sched_res_fac = table.Column<double>(type: "double", nullable: false),
                    plan_agent_fte = table.Column<double>(type: "double", nullable: false),
                    plan_nes_fte = table.Column<double>(type: "double", nullable: false),
                    date_from = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_to = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacityPlanWorkload", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryLead",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(200)", nullable: true),
                    middle_name = table.Column<string>(type: "varchar(200)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLead", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ForVolume",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date = table.Column<string>(type: "varchar(200)", nullable: true),
                    volume = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForVolume", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Geography",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geography", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "InShrinkage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    planned_leave = table.Column<double>(type: "double", nullable: false),
                    fix_holiday = table.Column<double>(type: "double", nullable: false),
                    opt_holiday = table.Column<double>(type: "double", nullable: false),
                    sick_leave = table.Column<double>(type: "double", nullable: false),
                    unplanned_leave = table.Column<double>(type: "double", nullable: false),
                    date_from = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_to = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InShrinkage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OutShrinkage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    planned_break = table.Column<double>(type: "double", nullable: false),
                    planned_huddle = table.Column<double>(type: "double", nullable: false),
                    planned_coaching = table.Column<double>(type: "double", nullable: false),
                    planned_training = table.Column<double>(type: "double", nullable: false),
                    planned_sys_issue = table.Column<double>(type: "double", nullable: false),
                    planned_outbound_call = table.Column<double>(type: "double", nullable: false),
                    planned_wellness = table.Column<double>(type: "double", nullable: false),
                    date_from = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_to = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutShrinkage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PocLead",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(200)", nullable: true),
                    middle_name = table.Column<string>(type: "varchar(200)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PocLead", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WccLead",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(200)", nullable: true),
                    middle_name = table.Column<string>(type: "varchar(200)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WccLead", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Workstream",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workstream", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LocationDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    geography_id = table.Column<int>(type: "int", nullable: true),
                    country_id = table.Column<int>(type: "int", nullable: true),
                    city_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_LocationDetails_City_city_id",
                        column: x => x.city_id,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Country_country_id",
                        column: x => x.country_id,
                        principalTable: "Country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Geography_geography_id",
                        column: x => x.geography_id,
                        principalTable: "Geography",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeopleDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    delivery_lead = table.Column<int>(type: "int", nullable: true),
                    wcc_lead = table.Column<int>(type: "int", nullable: true),
                    poc_lead = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_PeopleDetails_DeliveryLead_delivery_lead",
                        column: x => x.delivery_lead,
                        principalTable: "DeliveryLead",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeopleDetails_PocLead_poc_lead",
                        column: x => x.poc_lead,
                        principalTable: "PocLead",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeopleDetails_WccLead_wcc_lead",
                        column: x => x.wcc_lead,
                        principalTable: "WccLead",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capacity_plan_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    capacity_plan_ref_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_from = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_to = table.Column<string>(type: "varchar(200)", nullable: true),
                    project_id = table.Column<int>(type: "int", nullable: true),
                    workstream_id = table.Column<int>(type: "int", nullable: true),
                    language_id = table.Column<int>(type: "int", nullable: true),
                    channel_id = table.Column<int>(type: "int", nullable: true),
                    billing_model_id = table.Column<int>(type: "int", nullable: true),
                    location_id = table.Column<int>(type: "int", nullable: true),
                    people_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capacity_plan_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_BillingModel_billing_model_id",
                        column: x => x.billing_model_id,
                        principalTable: "BillingModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_Channel_channel_id",
                        column: x => x.channel_id,
                        principalTable: "Channel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_Language_language_id",
                        column: x => x.language_id,
                        principalTable: "Language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_LocationDetails_location_id",
                        column: x => x.location_id,
                        principalTable: "LocationDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_PeopleDetails_people_id",
                        column: x => x.people_id,
                        principalTable: "PeopleDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_Project_project_id",
                        column: x => x.project_id,
                        principalTable: "Project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_Workstream_workstream_id",
                        column: x => x.workstream_id,
                        principalTable: "Workstream",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capacity_plan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    week_start = table.Column<string>(type: "varchar(200)", nullable: true),
                    status = table.Column<int>(type: "int(11)", nullable: false),
                    cp_details_id = table.Column<int>(type: "int", nullable: true),
                    cp_workload_id = table.Column<int>(type: "int", nullable: true),
                    cp_target_id = table.Column<int>(type: "int", nullable: true),
                    cp_in_shrink_id = table.Column<int>(type: "int", nullable: true),
                    cp_out_shrink_id = table.Column<int>(type: "int", nullable: true),
                    cp_volume_id = table.Column<int>(type: "int", nullable: true),
                    is_deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capacity_plan", x => x.id);
                    table.ForeignKey(
                        name: "FK_capacity_plan_capacity_plan_details_cp_details_id",
                        column: x => x.cp_details_id,
                        principalTable: "capacity_plan_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_CapacityPlanTarget_cp_target_id",
                        column: x => x.cp_target_id,
                        principalTable: "CapacityPlanTarget",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_CapacityPlanWorkload_cp_workload_id",
                        column: x => x.cp_workload_id,
                        principalTable: "CapacityPlanWorkload",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_ForVolume_cp_volume_id",
                        column: x => x.cp_volume_id,
                        principalTable: "ForVolume",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_InShrinkage_cp_in_shrink_id",
                        column: x => x.cp_in_shrink_id,
                        principalTable: "InShrinkage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capacity_plan_OutShrinkage_cp_out_shrink_id",
                        column: x => x.cp_out_shrink_id,
                        principalTable: "OutShrinkage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_details_id",
                table: "capacity_plan",
                column: "cp_details_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_in_shrink_id",
                table: "capacity_plan",
                column: "cp_in_shrink_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_out_shrink_id",
                table: "capacity_plan",
                column: "cp_out_shrink_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_target_id",
                table: "capacity_plan",
                column: "cp_target_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_volume_id",
                table: "capacity_plan",
                column: "cp_volume_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_workload_id",
                table: "capacity_plan",
                column: "cp_workload_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_billing_model_id",
                table: "capacity_plan_details",
                column: "billing_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_channel_id",
                table: "capacity_plan_details",
                column: "channel_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_language_id",
                table: "capacity_plan_details",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_location_id",
                table: "capacity_plan_details",
                column: "location_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_people_id",
                table: "capacity_plan_details",
                column: "people_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_project_id",
                table: "capacity_plan_details",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_workstream_id",
                table: "capacity_plan_details",
                column: "workstream_id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_city_id",
                table: "LocationDetails",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_country_id",
                table: "LocationDetails",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_geography_id",
                table: "LocationDetails",
                column: "geography_id");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleDetails_delivery_lead",
                table: "PeopleDetails",
                column: "delivery_lead");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleDetails_poc_lead",
                table: "PeopleDetails",
                column: "poc_lead");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleDetails_wcc_lead",
                table: "PeopleDetails",
                column: "wcc_lead");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "capacity_plan");

            migrationBuilder.DropTable(
                name: "capacity_plan_details");

            migrationBuilder.DropTable(
                name: "CapacityPlanTarget");

            migrationBuilder.DropTable(
                name: "CapacityPlanWorkload");

            migrationBuilder.DropTable(
                name: "ForVolume");

            migrationBuilder.DropTable(
                name: "InShrinkage");

            migrationBuilder.DropTable(
                name: "OutShrinkage");

            migrationBuilder.DropTable(
                name: "BillingModel");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "LocationDetails");

            migrationBuilder.DropTable(
                name: "PeopleDetails");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Workstream");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Geography");

            migrationBuilder.DropTable(
                name: "DeliveryLead");

            migrationBuilder.DropTable(
                name: "PocLead");

            migrationBuilder.DropTable(
                name: "WccLead");
        }
    }
}
