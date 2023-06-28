using System;
using System.Collections.Generic;
using Creative.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccAccAnalysis> AccAccAnalyses { get; set; }

    public virtual DbSet<AccAccCat> AccAccCats { get; set; }

    public virtual DbSet<AccAccCost> AccAccCosts { get; set; }

    public virtual DbSet<AccAccExp> AccAccExps { get; set; }

    public virtual DbSet<AccAccount> AccAccounts { get; set; }

    public virtual DbSet<AccAnalysis> AccAnalyses { get; set; }

    public virtual DbSet<AccAnalysisBudget> AccAnalysisBudgets { get; set; }

    public virtual DbSet<AccBudget> AccBudgets { get; set; }

    public virtual DbSet<AccCategory> AccCategories { get; set; }

    public virtual DbSet<AccCheque> AccCheques { get; set; }

    public virtual DbSet<AccCostBudget> AccCostBudgets { get; set; }

    public virtual DbSet<AccCostCenter> AccCostCenters { get; set; }

    public virtual DbSet<AccCurrency> AccCurrencies { get; set; }

    public virtual DbSet<AccDocType> AccDocTypes { get; set; }

    public virtual DbSet<AccExchangeRate> AccExchangeRates { get; set; }

    public virtual DbSet<AccExpBudget> AccExpBudgets { get; set; }

    public virtual DbSet<AccExpense> AccExpenses { get; set; }

    public virtual DbSet<AccJournal> AccJournals { get; set; }

    public virtual DbSet<AccPariodD> AccPariodDs { get; set; }

    public virtual DbSet<AccPariodH> AccPariodHs { get; set; }

    public virtual DbSet<AccRetransD> AccRetransDs { get; set; }

    public virtual DbSet<AccRetransDoc> AccRetransDocs { get; set; }

    public virtual DbSet<AccRetransH> AccRetransHes { get; set; }

    public virtual DbSet<AccTransCheque> AccTransCheques { get; set; }

    public virtual DbSet<AccTransD> AccTransDs { get; set; }

    public virtual DbSet<AccTransDoc> AccTransDocs { get; set; }

    public virtual DbSet<AccTransH> AccTransHes { get; set; }

    public virtual DbSet<AcpExam> AcpExams { get; set; }

    public virtual DbSet<AcpExamType> AcpExamTypes { get; set; }

    public virtual DbSet<AcpExaminer> AcpExaminers { get; set; }

    public virtual DbSet<AcpExmRoom> AcpExmRooms { get; set; }

    public virtual DbSet<AcpExmSchedule> AcpExmSchedules { get; set; }

    public virtual DbSet<AcpResponsibile> AcpResponsibiles { get; set; }

    public virtual DbSet<AcpResponsibile1> AcpResponsibile1s { get; set; }

    public virtual DbSet<AcpStuExm> AcpStuExms { get; set; }

    public virtual DbSet<AcpStudent> AcpStudents { get; set; }

    public virtual DbSet<AcpStudent1> AcpStudent1s { get; set; }

    public virtual DbSet<AdlArea> AdlAreas { get; set; }

    public virtual DbSet<AdlConExp> AdlConExps { get; set; }

    public virtual DbSet<AdlConTerm> AdlConTerms { get; set; }

    public virtual DbSet<AdlConType> AdlConTypes { get; set; }

    public virtual DbSet<AdlCustomer> AdlCustomers { get; set; }

    public virtual DbSet<AdlGover> AdlGovers { get; set; }

    public virtual DbSet<AdlPayExp> AdlPayExps { get; set; }

    public virtual DbSet<AdlTransD> AdlTransDs { get; set; }

    public virtual DbSet<AdlTransExp> AdlTransExps { get; set; }

    public virtual DbSet<AdlTransH> AdlTransHes { get; set; }

    public virtual DbSet<AdlTransTerm> AdlTransTerms { get; set; }

    public virtual DbSet<AstAsset> AstAssets { get; set; }

    public virtual DbSet<AstAssetBranch> AstAssetBranches { get; set; }

    public virtual DbSet<AstAssetClass> AstAssetClasses { get; set; }

    public virtual DbSet<AstAssetComponent> AstAssetComponents { get; set; }

    public virtual DbSet<AstAssetDepreciation> AstAssetDepreciations { get; set; }

    public virtual DbSet<AstAssetDoc> AstAssetDocs { get; set; }

    public virtual DbSet<AstAssetEmp> AstAssetEmps { get; set; }

    public virtual DbSet<AstAssetGroup> AstAssetGroups { get; set; }

    public virtual DbSet<AstAssetType> AstAssetTypes { get; set; }

    public virtual DbSet<AstBranch> AstBranches { get; set; }

    public virtual DbSet<AstCompanyInsurance> AstCompanyInsurances { get; set; }

    public virtual DbSet<AstComponentLabel> AstComponentLabels { get; set; }

    public virtual DbSet<AstDepartment> AstDepartments { get; set; }

    public virtual DbSet<AstDivision> AstDivisions { get; set; }

    public virtual DbSet<AstDocType> AstDocTypes { get; set; }

    public virtual DbSet<AstEmploy> AstEmploys { get; set; }

    public virtual DbSet<AstLocation> AstLocations { get; set; }

    public virtual DbSet<AstReason> AstReasons { get; set; }

    public virtual DbSet<AstTransAllocationD> AstTransAllocationDs { get; set; }

    public virtual DbSet<AstTransAllocationDoc> AstTransAllocationDocs { get; set; }

    public virtual DbSet<AstTransAllocationH> AstTransAllocationHs { get; set; }

    public virtual DbSet<AstTransD> AstTransDs { get; set; }

    public virtual DbSet<AstTransDoc> AstTransDocs { get; set; }

    public virtual DbSet<AstTransH> AstTransHes { get; set; }

    public virtual DbSet<AstTransType> AstTransTypes { get; set; }

    public virtual DbSet<BusAssistant> BusAssistants { get; set; }

    public virtual DbSet<BusBu> BusBus { get; set; }

    public virtual DbSet<BusCar> BusCars { get; set; }

    public virtual DbSet<BusDriver> BusDrivers { get; set; }

    public virtual DbSet<BusResponser> BusResponsers { get; set; }

    public virtual DbSet<BusTransD> BusTransDs { get; set; }

    public virtual DbSet<BusTransDoc> BusTransDocs { get; set; }

    public virtual DbSet<BusTransH> BusTransHes { get; set; }

    public virtual DbSet<CBynActivity> CBynActivities { get; set; }

    public virtual DbSet<CBynCompany> CBynCompanies { get; set; }

    public virtual DbSet<CBynGroup> CBynGroups { get; set; }

    public virtual DbSet<CBynMain> CBynMains { get; set; }

    public virtual DbSet<CBynOther> CBynOthers { get; set; }

    public virtual DbSet<CBynProduct> CBynProducts { get; set; }

    public virtual DbSet<CBynQuation> CBynQuations { get; set; }

    public virtual DbSet<CBynTransD> CBynTransDs { get; set; }

    public virtual DbSet<CBynTransH> CBynTransHes { get; set; }

    public virtual DbSet<CCarCar> CCarCars { get; set; }

    public virtual DbSet<CCarCustGroup> CCarCustGroups { get; set; }

    public virtual DbSet<CCarCustomer> CCarCustomers { get; set; }

    public virtual DbSet<CCarDiscount> CCarDiscounts { get; set; }

    public virtual DbSet<CCarEmp> CCarEmps { get; set; }

    public virtual DbSet<CCarGroup> CCarGroups { get; set; }

    public virtual DbSet<CCarMaintenanceItem> CCarMaintenanceItems { get; set; }

    public virtual DbSet<CCarMarka> CCarMarkas { get; set; }

    public virtual DbSet<CCarRent> CCarRents { get; set; }

    public virtual DbSet<CCarService> CCarServices { get; set; }

    public virtual DbSet<CCarTcontract> CCarTcontracts { get; set; }

    public virtual DbSet<CCarTcontractService> CCarTcontractServices { get; set; }

    public virtual DbSet<CCarTicket> CCarTickets { get; set; }

    public virtual DbSet<CCarTmaintanance> CCarTmaintanances { get; set; }

    public virtual DbSet<CCarTpayment> CCarTpayments { get; set; }

    public virtual DbSet<CCarTreasury> CCarTreasuries { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartAddress> CartAddresses { get; set; }

    public virtual DbSet<CartPayment> CartPayments { get; set; }

    public virtual DbSet<CiepChecklist> CiepChecklists { get; set; }

    public virtual DbSet<CiepChecklistClass> CiepChecklistClasses { get; set; }

    public virtual DbSet<CiepClassTeacher> CiepClassTeachers { get; set; }

    public virtual DbSet<CiepCourse> CiepCourses { get; set; }

    public virtual DbSet<CiepCourseObjective> CiepCourseObjectives { get; set; }

    public virtual DbSet<CiepObjective> CiepObjectives { get; set; }

    public virtual DbSet<CiepRowType> CiepRowTypes { get; set; }

    public virtual DbSet<CiepStudent> CiepStudents { get; set; }

    public virtual DbSet<CiepTeacher> CiepTeachers { get; set; }

    public virtual DbSet<CiepTransChecklist> CiepTransChecklists { get; set; }

    public virtual DbSet<CiepTransDatum> CiepTransData { get; set; }

    public virtual DbSet<CiepTransIep> CiepTransIeps { get; set; }

    public virtual DbSet<CiepTransNote> CiepTransNotes { get; set; }

    public virtual DbSet<ClthCust> ClthCusts { get; set; }

    public virtual DbSet<ClthCustOrder> ClthCustOrders { get; set; }

    public virtual DbSet<ClthEmp> ClthEmps { get; set; }

    public virtual DbSet<ClthItem> ClthItems { get; set; }

    public virtual DbSet<ClthPur> ClthPurs { get; set; }

    public virtual DbSet<ClthSalary> ClthSalaries { get; set; }

    public virtual DbSet<ClthTran> ClthTrans { get; set; }

    public virtual DbSet<ClthUnit> ClthUnits { get; set; }

    public virtual DbSet<ClthWh> ClthWhs { get; set; }

    public virtual DbSet<CnsArea> CnsAreas { get; set; }

    public virtual DbSet<CnsBranch> CnsBranches { get; set; }

    public virtual DbSet<CnsCategory> CnsCategories { get; set; }

    public virtual DbSet<CnsContCat> CnsContCats { get; set; }

    public virtual DbSet<CnsContractor> CnsContractors { get; set; }

    public virtual DbSet<CnsCountry> CnsCountries { get; set; }

    public virtual DbSet<CnsDepartment> CnsDepartments { get; set; }

    public virtual DbSet<CnsExpItem> CnsExpItems { get; set; }

    public virtual DbSet<CnsGroup> CnsGroups { get; set; }

    public virtual DbSet<CnsProjItem> CnsProjItems { get; set; }

    public virtual DbSet<CnsProject> CnsProjects { get; set; }

    public virtual DbSet<CnsResponser> CnsResponsers { get; set; }

    public virtual DbSet<CnsState> CnsStates { get; set; }

    public virtual DbSet<CnsTcontractD> CnsTcontractDs { get; set; }

    public virtual DbSet<CnsTcontractH> CnsTcontractHs { get; set; }

    public virtual DbSet<CnsTinvoiceD> CnsTinvoiceDs { get; set; }

    public virtual DbSet<CnsTinvoiceDoc> CnsTinvoiceDocs { get; set; }

    public virtual DbSet<CnsTinvoiceExp> CnsTinvoiceExps { get; set; }

    public virtual DbSet<CnsTinvoiceH> CnsTinvoiceHs { get; set; }

    public virtual DbSet<CnsTorderD> CnsTorderDs { get; set; }

    public virtual DbSet<CnsTorderDoc> CnsTorderDocs { get; set; }

    public virtual DbSet<CnsTorderExp> CnsTorderExps { get; set; }

    public virtual DbSet<CnsTorderH> CnsTorderHs { get; set; }

    public virtual DbSet<CnsTqoutationDoc> CnsTqoutationDocs { get; set; }

    public virtual DbSet<CnsTqoutationExp> CnsTqoutationExps { get; set; }

    public virtual DbSet<CnsTquotationD> CnsTquotationDs { get; set; }

    public virtual DbSet<CnsTquotationH> CnsTquotationHs { get; set; }

    public virtual DbSet<CntArea> CntAreas { get; set; }

    public virtual DbSet<CntBranch> CntBranches { get; set; }

    public virtual DbSet<CntCar> CntCars { get; set; }

    public virtual DbSet<CntCarEquipment> CntCarEquipments { get; set; }

    public virtual DbSet<CntCarGroup> CntCarGroups { get; set; }

    public virtual DbSet<CntCarMarka> CntCarMarkas { get; set; }

    public virtual DbSet<CntCarPermeation> CntCarPermeations { get; set; }

    public virtual DbSet<CntCategory> CntCategories { get; set; }

    public virtual DbSet<CntContCat> CntContCats { get; set; }

    public virtual DbSet<CntContractor> CntContractors { get; set; }

    public virtual DbSet<CntCountry> CntCountries { get; set; }

    public virtual DbSet<CntDocType> CntDocTypes { get; set; }

    public virtual DbSet<CntEmp> CntEmps { get; set; }

    public virtual DbSet<CntEmpDoc> CntEmpDocs { get; set; }

    public virtual DbSet<CntEmpGroup> CntEmpGroups { get; set; }

    public virtual DbSet<CntEmpPermeation> CntEmpPermeations { get; set; }

    public virtual DbSet<CntEmpVacation> CntEmpVacations { get; set; }

    public virtual DbSet<CntExpItem> CntExpItems { get; set; }

    public virtual DbSet<CntLocation> CntLocations { get; set; }

    public virtual DbSet<CntMaintananceItem> CntMaintananceItems { get; set; }

    public virtual DbSet<CntPermeation> CntPermeations { get; set; }

    public virtual DbSet<CntResponser> CntResponsers { get; set; }

    public virtual DbSet<CntState> CntStates { get; set; }

    public virtual DbSet<CntTconDoc> CntTconDocs { get; set; }

    public virtual DbSet<CntTconEmp> CntTconEmps { get; set; }

    public virtual DbSet<CntTconExp> CntTconExps { get; set; }

    public virtual DbSet<CntTconPurOrder> CntTconPurOrders { get; set; }

    public virtual DbSet<CntTconTrem> CntTconTrems { get; set; }

    public virtual DbSet<CntTcontractH> CntTcontractHs { get; set; }

    public virtual DbSet<CntTjobOrder> CntTjobOrders { get; set; }

    public virtual DbSet<CntTmaintanance> CntTmaintanances { get; set; }

    public virtual DbSet<CntTpayment> CntTpayments { get; set; }

    public virtual DbSet<CntTreasury> CntTreasuries { get; set; }

    public virtual DbSet<CntTworkCard> CntTworkCards { get; set; }

    public virtual DbSet<CrgBorder> CrgBorders { get; set; }

    public virtual DbSet<CrgCargoType> CrgCargoTypes { get; set; }

    public virtual DbSet<CrgDeliveryNote> CrgDeliveryNotes { get; set; }

    public virtual DbSet<CrgDispatch> CrgDispatches { get; set; }

    public virtual DbSet<CrgDispatchDoc> CrgDispatchDocs { get; set; }

    public virtual DbSet<CrgEmployee> CrgEmployees { get; set; }

    public virtual DbSet<CrgExpD> CrgExpDs { get; set; }

    public virtual DbSet<CrgExpDoc> CrgExpDocs { get; set; }

    public virtual DbSet<CrgExpH> CrgExpHs { get; set; }

    public virtual DbSet<CrgExpItem> CrgExpItems { get; set; }

    public virtual DbSet<CrgInvoiceItem> CrgInvoiceItems { get; set; }

    public virtual DbSet<CrgPayD> CrgPayDs { get; set; }

    public virtual DbSet<CrgPayDoc> CrgPayDocs { get; set; }

    public virtual DbSet<CrgPayH> CrgPayHs { get; set; }

    public virtual DbSet<CrgShipment> CrgShipments { get; set; }

    public virtual DbSet<CrgShipmentDoc> CrgShipmentDocs { get; set; }

    public virtual DbSet<CrgStage> CrgStages { get; set; }

    public virtual DbSet<CrgTinvoiceD> CrgTinvoiceDs { get; set; }

    public virtual DbSet<CrgTinvoiceDoc> CrgTinvoiceDocs { get; set; }

    public virtual DbSet<CrgTinvoiceExp> CrgTinvoiceExps { get; set; }

    public virtual DbSet<CrgTinvoiceH> CrgTinvoiceHs { get; set; }

    public virtual DbSet<CrgTorderD> CrgTorderDs { get; set; }

    public virtual DbSet<CrgTorderDoc> CrgTorderDocs { get; set; }

    public virtual DbSet<CrgTorderExp> CrgTorderExps { get; set; }

    public virtual DbSet<CrgTorderH> CrgTorderHs { get; set; }

    public virtual DbSet<CrgTquotationD> CrgTquotationDs { get; set; }

    public virtual DbSet<CrgTquotationDoc> CrgTquotationDocs { get; set; }

    public virtual DbSet<CrgTquotationExp> CrgTquotationExps { get; set; }

    public virtual DbSet<CrgTquotationH> CrgTquotationHs { get; set; }

    public virtual DbSet<CrgTran> CrgTrans { get; set; }

    public virtual DbSet<CrgTransDoc> CrgTransDocs { get; set; }

    public virtual DbSet<CrgTreasury> CrgTreasuries { get; set; }

    public virtual DbSet<CrgVendor> CrgVendors { get; set; }

    public virtual DbSet<CstDocTran> CstDocTrans { get; set; }

    public virtual DbSet<CstOm> CstOms { get; set; }

    public virtual DbSet<CstOrg> CstOrgs { get; set; }

    public virtual DbSet<CstTel> CstTels { get; set; }

    public virtual DbSet<CurCourse> CurCourses { get; set; }

    public virtual DbSet<CurCourseUnit> CurCourseUnits { get; set; }

    public virtual DbSet<CurCourseUnitWeek> CurCourseUnitWeeks { get; set; }

    public virtual DbSet<CurDocType> CurDocTypes { get; set; }

    public virtual DbSet<CurTerm> CurTerms { get; set; }

    public virtual DbSet<CurTransDoc> CurTransDocs { get; set; }

    public virtual DbSet<CurUnitType> CurUnitTypes { get; set; }

    public virtual DbSet<CurWeek> CurWeeks { get; set; }

    public virtual DbSet<CurrCategory> CurrCategories { get; set; }

    public virtual DbSet<CurrChecklist> CurrChecklists { get; set; }

    public virtual DbSet<CurrChecklistTran> CurrChecklistTrans { get; set; }

    public virtual DbSet<CurrClass> CurrClasses { get; set; }

    public virtual DbSet<CurrCourse> CurrCourses { get; set; }

    public virtual DbSet<CurrCourseObjective> CurrCourseObjectives { get; set; }

    public virtual DbSet<CurrCourseTechStu> CurrCourseTechStus { get; set; }

    public virtual DbSet<CurrExam> CurrExams { get; set; }

    public virtual DbSet<CurrItem> CurrItems { get; set; }

    public virtual DbSet<CurrLevel> CurrLevels { get; set; }

    public virtual DbSet<CurrMAssessment> CurrMAssessments { get; set; }

    public virtual DbSet<CurrMAssessmentStrategy> CurrMAssessmentStrategies { get; set; }

    public virtual DbSet<CurrMComment> CurrMComments { get; set; }

    public virtual DbSet<CurrMEnvironmental> CurrMEnvironmentals { get; set; }

    public virtual DbSet<CurrMInstructional> CurrMInstructionals { get; set; }

    public virtual DbSet<CurrMNeed> CurrMNeeds { get; set; }

    public virtual DbSet<CurrMStrength> CurrMStrengths { get; set; }

    public virtual DbSet<CurrMTeachingStrategy> CurrMTeachingStrategies { get; set; }

    public virtual DbSet<CurrObjective> CurrObjectives { get; set; }

    public virtual DbSet<CurrStuInsEnvAss> CurrStuInsEnvAsses { get; set; }

    public virtual DbSet<CurrStuRelevant> CurrStuRelevants { get; set; }

    public virtual DbSet<CurrStuStrengthNeed> CurrStuStrengthNeeds { get; set; }

    public virtual DbSet<CurrStuSub> CurrStuSubs { get; set; }

    public virtual DbSet<CurrStuTeacherNote> CurrStuTeacherNotes { get; set; }

    public virtual DbSet<CurrStudent> CurrStudents { get; set; }

    public virtual DbSet<CurrSubCategory> CurrSubCategories { get; set; }

    public virtual DbSet<CurrTeacher> CurrTeachers { get; set; }

    public virtual DbSet<CurrTransAssessement> CurrTransAssessements { get; set; }

    public virtual DbSet<CurrTransPlan> CurrTransPlans { get; set; }

    public virtual DbSet<CurrYearAcademy> CurrYearAcademies { get; set; }

    public virtual DbSet<CursClass> CursClasses { get; set; }

    public virtual DbSet<CursConcept> CursConcepts { get; set; }

    public virtual DbSet<CursCourse> CursCourses { get; set; }

    public virtual DbSet<CursDisability> CursDisabilities { get; set; }

    public virtual DbSet<CursEmp> CursEmps { get; set; }

    public virtual DbSet<CursExam> CursExams { get; set; }

    public virtual DbSet<CursItem> CursItems { get; set; }

    public virtual DbSet<CursLevel> CursLevels { get; set; }

    public virtual DbSet<CursLevelCourse> CursLevelCourses { get; set; }

    public virtual DbSet<CursLevelUnit> CursLevelUnits { get; set; }

    public virtual DbSet<CursObjective> CursObjectives { get; set; }

    public virtual DbSet<CursStage> CursStages { get; set; }

    public virtual DbSet<CursStageCourse> CursStageCourses { get; set; }

    public virtual DbSet<CursStageUnit> CursStageUnits { get; set; }

    public virtual DbSet<CursStudent> CursStudents { get; set; }

    public virtual DbSet<CursSubstage> CursSubstages { get; set; }

    public virtual DbSet<CursTool> CursTools { get; set; }

    public virtual DbSet<CursTransD> CursTransDs { get; set; }

    public virtual DbSet<CursTransH> CursTransHes { get; set; }

    public virtual DbSet<CursUnit> CursUnits { get; set; }

    public virtual DbSet<DspAircraftConfig> DspAircraftConfigs { get; set; }

    public virtual DbSet<DspAircraftConfigCharge> DspAircraftConfigCharges { get; set; }

    public virtual DbSet<DspAircraftConfigGalleyPlan> DspAircraftConfigGalleyPlans { get; set; }

    public virtual DbSet<DspBomH> DspBomHs { get; set; }

    public virtual DbSet<DspBomRouting> DspBomRoutings { get; set; }

    public virtual DbSet<DspBoomD> DspBoomDs { get; set; }

    public virtual DbSet<DspDepartment> DspDepartments { get; set; }

    public virtual DbSet<DspDish> DspDishes { get; set; }

    public virtual DbSet<DspDispatch> DspDispatches { get; set; }

    public virtual DbSet<DspDispatchCharge> DspDispatchCharges { get; set; }

    public virtual DbSet<DspDispatchD> DspDispatchDs { get; set; }

    public virtual DbSet<DspDispatchReduction> DspDispatchReductions { get; set; }

    public virtual DbSet<DspDispatchSpl> DspDispatchSpls { get; set; }

    public virtual DbSet<DspLoadingScale> DspLoadingScales { get; set; }

    public virtual DbSet<DspLoadingScaleDish> DspLoadingScaleDishes { get; set; }

    public virtual DbSet<DspPriceMatrix> DspPriceMatrices { get; set; }

    public virtual DbSet<DspProcess> DspProcesses { get; set; }

    public virtual DbSet<DspSchedule> DspSchedules { get; set; }

    public virtual DbSet<DspScheduleFlight> DspScheduleFlights { get; set; }

    public virtual DbSet<DspScheduleMeal> DspScheduleMeals { get; set; }

    public virtual DbSet<DspScheduleMealReduction> DspScheduleMealReductions { get; set; }

    public virtual DbSet<DspSector> DspSectors { get; set; }

    public virtual DbSet<DspStorageType> DspStorageTypes { get; set; }

    public virtual DbSet<DspWorkcenter> DspWorkcenters { get; set; }

    public virtual DbSet<EeeResponsibile> EeeResponsibiles { get; set; }

    public virtual DbSet<Eexp> Eexps { get; set; }

    public virtual DbSet<EquCar> EquCars { get; set; }

    public virtual DbSet<EquCarsCategory> EquCarsCategories { get; set; }

    public virtual DbSet<EquCarsClass> EquCarsClasses { get; set; }

    public virtual DbSet<EquCarsDoc> EquCarsDocs { get; set; }

    public virtual DbSet<EquCarsMarka> EquCarsMarkas { get; set; }

    public virtual DbSet<EquDepartment> EquDepartments { get; set; }

    public virtual DbSet<EquDocType> EquDocTypes { get; set; }

    public virtual DbSet<EquEmploy> EquEmploys { get; set; }

    public virtual DbSet<EquMaintananceItem> EquMaintananceItems { get; set; }

    public virtual DbSet<EquTcontractD> EquTcontractDs { get; set; }

    public virtual DbSet<EquTcontrctCar> EquTcontrctCars { get; set; }

    public virtual DbSet<EquTcontrctCarsDoc> EquTcontrctCarsDocs { get; set; }

    public virtual DbSet<EquTcontrctDoc> EquTcontrctDocs { get; set; }

    public virtual DbSet<EquTcontrctH> EquTcontrctHs { get; set; }

    public virtual DbSet<EquTmaintananceD> EquTmaintananceDs { get; set; }

    public virtual DbSet<EquTmaintananceDoc> EquTmaintananceDocs { get; set; }

    public virtual DbSet<EquTmaintananceH> EquTmaintananceHs { get; set; }

    public virtual DbSet<ExgAgent> ExgAgents { get; set; }

    public virtual DbSet<ExgAgentBranch> ExgAgentBranches { get; set; }

    public virtual DbSet<ExgAgentType> ExgAgentTypes { get; set; }

    public virtual DbSet<ExgBanck> ExgBancks { get; set; }

    public virtual DbSet<ExgBanckBranch> ExgBanckBranches { get; set; }

    public virtual DbSet<ExgBlackList> ExgBlackLists { get; set; }

    public virtual DbSet<ExgBranch> ExgBranches { get; set; }

    public virtual DbSet<ExgCountry> ExgCountries { get; set; }

    public virtual DbSet<ExgCountryCurrency> ExgCountryCurrencies { get; set; }

    public virtual DbSet<ExgCurrency> ExgCurrencies { get; set; }

    public virtual DbSet<ExgCustGroup> ExgCustGroups { get; set; }

    public virtual DbSet<ExgCustRecipient> ExgCustRecipients { get; set; }

    public virtual DbSet<ExgCustomer> ExgCustomers { get; set; }

    public virtual DbSet<ExgEmploy> ExgEmploys { get; set; }

    public virtual DbSet<ExgExchangeRate> ExgExchangeRates { get; set; }

    public virtual DbSet<ExgIdType> ExgIdTypes { get; set; }

    public virtual DbSet<ExgNationality> ExgNationalities { get; set; }

    public virtual DbSet<ExgPayType> ExgPayTypes { get; set; }

    public virtual DbSet<ExgReason> ExgReasons { get; set; }

    public virtual DbSet<ExgRecipient> ExgRecipients { get; set; }

    public virtual DbSet<ExgService> ExgServices { get; set; }

    public virtual DbSet<ExgTransH> ExgTransHes { get; set; }

    public virtual DbSet<ExgTransType> ExgTransTypes { get; set; }

    public virtual DbSet<ExgTreasury> ExgTreasuries { get; set; }

    public virtual DbSet<ExmAttendance> ExmAttendances { get; set; }

    public virtual DbSet<ExmCalendarBranch> ExmCalendarBranches { get; set; }

    public virtual DbSet<ExmCalendarMain> ExmCalendarMains { get; set; }

    public virtual DbSet<ExmCalendarMaster> ExmCalendarMasters { get; set; }

    public virtual DbSet<ExmComment> ExmComments { get; set; }

    public virtual DbSet<ExmCourse> ExmCourses { get; set; }

    public virtual DbSet<ExmCourseClassTeacher> ExmCourseClassTeachers { get; set; }

    public virtual DbSet<ExmCourseGread> ExmCourseGreads { get; set; }

    public virtual DbSet<ExmGroup> ExmGroups { get; set; }

    public virtual DbSet<ExmSkill> ExmSkills { get; set; }

    public virtual DbSet<ExmSkillsItem> ExmSkillsItems { get; set; }

    public virtual DbSet<ExmStudentAttendance> ExmStudentAttendances { get; set; }

    public virtual DbSet<ExmTeacher> ExmTeachers { get; set; }

    public virtual DbSet<ExmTerm> ExmTerms { get; set; }

    public virtual DbSet<ExmTermExam> ExmTermExams { get; set; }

    public virtual DbSet<ExmTran> ExmTrans { get; set; }

    public virtual DbSet<ExmTranscript> ExmTranscripts { get; set; }

    public virtual DbSet<ExmdCategory> ExmdCategories { get; set; }

    public virtual DbSet<ExmdExam> ExmdExams { get; set; }

    public virtual DbSet<ExmdExamCat> ExmdExamCats { get; set; }

    public virtual DbSet<ExmdExamClass> ExmdExamClasses { get; set; }

    public virtual DbSet<ExmdTran> ExmdTrans { get; set; }

    public virtual DbSet<ExmdType> ExmdTypes { get; set; }

    public virtual DbSet<ExpDiscItem> ExpDiscItems { get; set; }

    public virtual DbSet<ExpExpItem> ExpExpItems { get; set; }

    public virtual DbSet<ExpGreadExp> ExpGreadExps { get; set; }

    public virtual DbSet<ExpPayD> ExpPayDs { get; set; }

    public virtual DbSet<ExpPayDWeb> ExpPayDWebs { get; set; }

    public virtual DbSet<ExpPayH> ExpPayHs { get; set; }

    public virtual DbSet<ExpPayHWeb> ExpPayHWebs { get; set; }

    public virtual DbSet<ExpPayItem> ExpPayItems { get; set; }

    public virtual DbSet<ExpPayType> ExpPayTypes { get; set; }

    public virtual DbSet<ExpPayTypeWeb> ExpPayTypeWebs { get; set; }

    public virtual DbSet<ExpPayWay> ExpPayWays { get; set; }

    public virtual DbSet<ExpStuAccount> ExpStuAccounts { get; set; }

    public virtual DbSet<ExpTreasury> ExpTreasuries { get; set; }

    public virtual DbSet<ExpTreasuryItem> ExpTreasuryItems { get; set; }

    public virtual DbSet<GenAlarm> GenAlarms { get; set; }

    public virtual DbSet<GenAnalysisRep> GenAnalysisReps { get; set; }

    public virtual DbSet<GenCrosstab> GenCrosstabs { get; set; }

    public virtual DbSet<GenCrosstabH> GenCrosstabHs { get; set; }

    public virtual DbSet<GenGraphD> GenGraphDs { get; set; }

    public virtual DbSet<GenGraphH> GenGraphHs { get; set; }

    public virtual DbSet<GenRconCon> GenRconCons { get; set; }

    public virtual DbSet<GenRepAcc> GenRepAccs { get; set; }

    public virtual DbSet<GenRepAcp> GenRepAcps { get; set; }

    public virtual DbSet<GenRepAcpStu> GenRepAcpStus { get; set; }

    public virtual DbSet<GenRepCntEmp> GenRepCntEmps { get; set; }

    public virtual DbSet<GenRepEqu> GenRepEqus { get; set; }

    public virtual DbSet<GenRepEquCon> GenRepEquCons { get; set; }

    public virtual DbSet<GenRepExp> GenRepExps { get; set; }

    public virtual DbSet<GenRepExpPay> GenRepExpPays { get; set; }

    public virtual DbSet<GenRepHrAtd> GenRepHrAtds { get; set; }

    public virtual DbSet<GenRepHrEmp> GenRepHrEmps { get; set; }

    public virtual DbSet<GenRepHrEmp1> GenRepHrEmps1 { get; set; }

    public virtual DbSet<GenRepHrEmp11> GenRepHrEmp1s { get; set; }

    public virtual DbSet<GenRepHrEmpRep> GenRepHrEmpReps { get; set; }

    public virtual DbSet<GenRepHrEmpRep1> GenRepHrEmpReps1 { get; set; }

    public virtual DbSet<GenRepInv> GenRepInvs { get; set; }

    public virtual DbSet<GenRepPad> GenRepPads { get; set; }

    public virtual DbSet<GenRepPur> GenRepPurs { get; set; }

    public virtual DbSet<GenRepReg> GenRepRegs { get; set; }

    public virtual DbSet<GenRepReg1> GenRepRegs1 { get; set; }

    public virtual DbSet<GenRepReg2016> GenRepReg2016s { get; set; }

    public virtual DbSet<GenRepRegStu> GenRepRegStus { get; set; }

    public virtual DbSet<GenRepRegStu1> GenRepRegStus1 { get; set; }

    public virtual DbSet<GenRepSal> GenRepSals { get; set; }

    public virtual DbSet<GenRepWcn> GenRepWcns { get; set; }

    public virtual DbSet<GenRfid> GenRfids { get; set; }

    public virtual DbSet<GenSysParm> GenSysParms { get; set; }

    public virtual DbSet<GenTranslation> GenTranslations { get; set; }

    public virtual DbSet<GenWcnRep> GenWcnReps { get; set; }

    public virtual DbSet<GovArea> GovAreas { get; set; }

    public virtual DbSet<GovDocType> GovDocTypes { get; set; }

    public virtual DbSet<GovGover> GovGovers { get; set; }

    public virtual DbSet<GovOrg> GovOrgs { get; set; }

    public virtual DbSet<GovPersson> GovPerssons { get; set; }

    public virtual DbSet<GovTransH> GovTransHes { get; set; }

    public virtual DbSet<HaptAppiontment> HaptAppiontments { get; set; }

    public virtual DbSet<HaptDoctor> HaptDoctors { get; set; }

    public virtual DbSet<HaptPatient> HaptPatients { get; set; }

    public virtual DbSet<HaptPatientDoc> HaptPatientDocs { get; set; }

    public virtual DbSet<HrAcdmcQulfc> HrAcdmcQulfcs { get; set; }

    public virtual DbSet<HrArea> HrAreas { get; set; }

    public virtual DbSet<HrAtdCalendarD> HrAtdCalendarDs { get; set; }

    public virtual DbSet<HrAtdCalendarH> HrAtdCalendarHs { get; set; }

    public virtual DbSet<HrAtdEmpTimetable> HrAtdEmpTimetables { get; set; }

    public virtual DbSet<HrAtdImport> HrAtdImports { get; set; }

    public virtual DbSet<HrAtdMachine> HrAtdMachines { get; set; }

    public virtual DbSet<HrAtdTran> HrAtdTrans { get; set; }

    public virtual DbSet<HrBank> HrBanks { get; set; }

    public virtual DbSet<HrBankAcc> HrBankAccs { get; set; }

    public virtual DbSet<HrBankBranch> HrBankBranches { get; set; }

    public virtual DbSet<HrBranch> HrBranches { get; set; }

    public virtual DbSet<HrCalendarD> HrCalendarDs { get; set; }

    public virtual DbSet<HrCalenderH> HrCalenderHs { get; set; }

    public virtual DbSet<HrCategry> HrCategries { get; set; }

    public virtual DbSet<HrCompanyLicense> HrCompanyLicenses { get; set; }

    public virtual DbSet<HrDeprt> HrDeprts { get; set; }

    public virtual DbSet<HrDocType> HrDocTypes { get; set; }

    public virtual DbSet<HrEmpClass> HrEmpClasses { get; set; }

    public virtual DbSet<HrEmpGroup> HrEmpGroups { get; set; }

    public virtual DbSet<HrEmpSalary> HrEmpSalaries { get; set; }

    public virtual DbSet<HrEmpTimetable> HrEmpTimetables { get; set; }

    public virtual DbSet<HrEmpType> HrEmpTypes { get; set; }

    public virtual DbSet<HrEmployAcdmcQulfc> HrEmployAcdmcQulfcs { get; set; }

    public virtual DbSet<HrEmployCalender> HrEmployCalenders { get; set; }

    public virtual DbSet<HrEmployClass> HrEmployClasses { get; set; }

    public virtual DbSet<HrEmployClass2> HrEmployClass2s { get; set; }

    public virtual DbSet<HrEmployDoc> HrEmployDocs { get; set; }

    public virtual DbSet<HrEmployVacation> HrEmployVacations { get; set; }

    public virtual DbSet<HrEmply> HrEmplies { get; set; }

    public virtual DbSet<HrEmply2> HrEmply2s { get; set; }

    public virtual DbSet<HrEmply3> HrEmply3s { get; set; }

    public virtual DbSet<HrEmply4> HrEmply4s { get; set; }

    public virtual DbSet<HrEmplySalaryPlan> HrEmplySalaryPlans { get; set; }

    public virtual DbSet<HrGover> HrGovers { get; set; }

    public virtual DbSet<HrJob> HrJobs { get; set; }

    public virtual DbSet<HrNationalty> HrNationalties { get; set; }

    public virtual DbSet<HrPayIndemnity> HrPayIndemnities { get; set; }

    public virtual DbSet<HrRegonal> HrRegonals { get; set; }

    public virtual DbSet<HrSignature> HrSignatures { get; set; }

    public virtual DbSet<HrTransH> HrTransHes { get; set; }

    public virtual DbSet<HraBonusType> HraBonusTypes { get; set; }

    public virtual DbSet<HraDegree> HraDegrees { get; set; }

    public virtual DbSet<HraPenaltiesType> HraPenaltiesTypes { get; set; }

    public virtual DbSet<HraPromotedType> HraPromotedTypes { get; set; }

    public virtual DbSet<HraTbonu> HraTbonus { get; set; }

    public virtual DbSet<HraTpromotion> HraTpromotions { get; set; }

    public virtual DbSet<HraTran> HraTrans { get; set; }

    public virtual DbSet<HraTrnasferReson> HraTrnasferResons { get; set; }

    public virtual DbSet<HreCategory> HreCategories { get; set; }

    public virtual DbSet<HreClass> HreClasses { get; set; }

    public virtual DbSet<HreEvaluationD> HreEvaluationDs { get; set; }

    public virtual DbSet<HreEvaluationH> HreEvaluationHs { get; set; }

    public virtual DbSet<HreGroup> HreGroups { get; set; }

    public virtual DbSet<HreTransD> HreTransDs { get; set; }

    public virtual DbSet<HreType> HreTypes { get; set; }

    public virtual DbSet<HrfCar> HrfCars { get; set; }

    public virtual DbSet<HrfCarDoc> HrfCarDocs { get; set; }

    public virtual DbSet<HrfCarMarka> HrfCarMarkas { get; set; }

    public virtual DbSet<HrfCarTran> HrfCarTrans { get; set; }

    public virtual DbSet<HrfCarTransD> HrfCarTransDs { get; set; }

    public virtual DbSet<HrfCarTransDoc> HrfCarTransDocs { get; set; }

    public virtual DbSet<HrfCarTransH> HrfCarTransHes { get; set; }

    public virtual DbSet<HrfConInstallment> HrfConInstallments { get; set; }

    public virtual DbSet<HrfConTerm> HrfConTerms { get; set; }

    public virtual DbSet<HrfContract> HrfContracts { get; set; }

    public virtual DbSet<HrfContractDoc> HrfContractDocs { get; set; }

    public virtual DbSet<HrfCustomer> HrfCustomers { get; set; }

    public virtual DbSet<HrfCustomerDoc> HrfCustomerDocs { get; set; }

    public virtual DbSet<HrfDocTran> HrfDocTrans { get; set; }

    public virtual DbSet<HrfDocTransD> HrfDocTransDs { get; set; }

    public virtual DbSet<HrfEmpConTeam> HrfEmpConTeams { get; set; }

    public virtual DbSet<HrfFurniture> HrfFurnitures { get; set; }

    public virtual DbSet<HrfRequestD> HrfRequestDs { get; set; }

    public virtual DbSet<HrfRequestH> HrfRequestHs { get; set; }

    public virtual DbSet<HrfTaskD> HrfTaskDs { get; set; }

    public virtual DbSet<HrfTaskDoc> HrfTaskDocs { get; set; }

    public virtual DbSet<HrfTaskH> HrfTaskHs { get; set; }

    public virtual DbSet<HrfTeam> HrfTeams { get; set; }

    public virtual DbSet<HrfTeamDoc> HrfTeamDocs { get; set; }

    public virtual DbSet<HrfUnit> HrfUnits { get; set; }

    public virtual DbSet<HrfUnitDoc> HrfUnitDocs { get; set; }

    public virtual DbSet<HrfUnitFurniture> HrfUnitFurnitures { get; set; }

    public virtual DbSet<HrfUnitTran> HrfUnitTrans { get; set; }

    public virtual DbSet<HrfVendor> HrfVendors { get; set; }

    public virtual DbSet<HrfVendorDoc> HrfVendorDocs { get; set; }

    public virtual DbSet<HspAllergy> HspAllergies { get; set; }

    public virtual DbSet<HspArea> HspAreas { get; set; }

    public virtual DbSet<HspBranch> HspBranches { get; set; }

    public virtual DbSet<HspCategory> HspCategories { get; set; }

    public virtual DbSet<HspClinic> HspClinics { get; set; }

    public virtual DbSet<HspDepartment> HspDepartments { get; set; }

    public virtual DbSet<HspDocType> HspDocTypes { get; set; }

    public virtual DbSet<HspDoctor> HspDoctors { get; set; }

    public virtual DbSet<HspGover> HspGovers { get; set; }

    public virtual DbSet<HspGroup> HspGroups { get; set; }

    public virtual DbSet<HspHistory> HspHistories { get; set; }

    public virtual DbSet<HspHospital> HspHospitals { get; set; }

    public virtual DbSet<HspInsCompGroup> HspInsCompGroups { get; set; }

    public virtual DbSet<HspInsuranceCompany> HspInsuranceCompanies { get; set; }

    public virtual DbSet<HspJob> HspJobs { get; set; }

    public virtual DbSet<HspNationality> HspNationalities { get; set; }

    public virtual DbSet<HspPatCat> HspPatCats { get; set; }

    public virtual DbSet<HspPatDoc> HspPatDocs { get; set; }

    public virtual DbSet<HspPatient> HspPatients { get; set; }

    public virtual DbSet<HspPayTransD> HspPayTransDs { get; set; }

    public virtual DbSet<HspPayTransDoc> HspPayTransDocs { get; set; }

    public virtual DbSet<HspPayTransH> HspPayTransHes { get; set; }

    public virtual DbSet<HspPriceListD> HspPriceListDs { get; set; }

    public virtual DbSet<HspPriceListH> HspPriceListHs { get; set; }

    public virtual DbSet<HspRelegion> HspRelegions { get; set; }

    public virtual DbSet<HspReqGroup> HspReqGroups { get; set; }

    public virtual DbSet<HspReqTransD> HspReqTransDs { get; set; }

    public virtual DbSet<HspReqTransH> HspReqTransHes { get; set; }

    public virtual DbSet<HspReqTypeD> HspReqTypeDs { get; set; }

    public virtual DbSet<HspReqTypeH> HspReqTypeHs { get; set; }

    public virtual DbSet<HspRoom> HspRooms { get; set; }

    public virtual DbSet<HspTreasury> HspTreasuries { get; set; }

    public virtual DbSet<HspVisit> HspVisits { get; set; }

    public virtual DbSet<InsArea> InsAreas { get; set; }

    public virtual DbSet<InsCar> InsCars { get; set; }

    public virtual DbSet<InsCarGroup> InsCarGroups { get; set; }

    public virtual DbSet<InsCarType> InsCarTypes { get; set; }

    public virtual DbSet<InsCarTypeItem> InsCarTypeItems { get; set; }

    public virtual DbSet<InsCountry> InsCountries { get; set; }

    public virtual DbSet<InsGover> InsGovers { get; set; }

    public virtual DbSet<InsNational> InsNationals { get; set; }

    public virtual DbSet<InvCategry> InvCategries { get; set; }

    public virtual DbSet<InvClass> InvClasses { get; set; }

    public virtual DbSet<InvDocType> InvDocTypes { get; set; }

    public virtual DbSet<InvGroup> InvGroups { get; set; }

    public virtual DbSet<InvItem> InvItems { get; set; }

    public virtual DbSet<InvItemCat> InvItemCats { get; set; }

    public virtual DbSet<InvItemCont> InvItemConts { get; set; }

    public virtual DbSet<InvItemLot> InvItemLots { get; set; }

    public virtual DbSet<InvItemUnit> InvItemUnits { get; set; }

    public virtual DbSet<InvItemsLabel> InvItemsLabels { get; set; }

    public virtual DbSet<InvLocation> InvLocations { get; set; }

    public virtual DbSet<InvMatrix> InvMatrices { get; set; }

    public virtual DbSet<InvMatrixUnit> InvMatrixUnits { get; set; }

    public virtual DbSet<InvOrg> InvOrgs { get; set; }

    public virtual DbSet<InvReason> InvReasons { get; set; }

    public virtual DbSet<InvTinventoryD> InvTinventoryDs { get; set; }

    public virtual DbSet<InvTinventoryDoc> InvTinventoryDocs { get; set; }

    public virtual DbSet<InvTinventoryH> InvTinventoryHs { get; set; }

    public virtual DbSet<InvTransAllocationD> InvTransAllocationDs { get; set; }

    public virtual DbSet<InvTransAllocationH> InvTransAllocationHs { get; set; }

    public virtual DbSet<InvTransCont> InvTransConts { get; set; }

    public virtual DbSet<InvTransD> InvTransDs { get; set; }

    public virtual DbSet<InvTransDoc> InvTransDocs { get; set; }

    public virtual DbSet<InvTransH> InvTransHes { get; set; }

    public virtual DbSet<InvTransMatrix> InvTransMatrices { get; set; }

    public virtual DbSet<InvTransType> InvTransTypes { get; set; }

    public virtual DbSet<InvType> InvTypes { get; set; }

    public virtual DbSet<InvUnit> InvUnits { get; set; }

    public virtual DbSet<InvWarehouse> InvWarehouses { get; set; }

    public virtual DbSet<LibActivtyType> LibActivtyTypes { get; set; }

    public virtual DbSet<LibCategry> LibCategries { get; set; }

    public virtual DbSet<LibClass> LibClasses { get; set; }

    public virtual DbSet<LibClassification> LibClassifications { get; set; }

    public virtual DbSet<LibGroup> LibGroups { get; set; }

    public virtual DbSet<LibItem> LibItems { get; set; }

    public virtual DbSet<LibItemCat> LibItemCats { get; set; }

    public virtual DbSet<LibItemUnit> LibItemUnits { get; set; }

    public virtual DbSet<LibItemsBook> LibItemsBooks { get; set; }

    public virtual DbSet<LibLibrary> LibLibraries { get; set; }

    public virtual DbSet<LibLocation> LibLocations { get; set; }

    public virtual DbSet<LibOrg> LibOrgs { get; set; }

    public virtual DbSet<LibReason> LibReasons { get; set; }

    public virtual DbSet<LibRecalculationD> LibRecalculationDs { get; set; }

    public virtual DbSet<LibRecalculationH> LibRecalculationHs { get; set; }

    public virtual DbSet<LibTactivty> LibTactivties { get; set; }

    public virtual DbSet<LibThistory> LibThistories { get; set; }

    public virtual DbSet<LibTran> LibTrans { get; set; }

    public virtual DbSet<LibTransAllocationD> LibTransAllocationDs { get; set; }

    public virtual DbSet<LibTransAllocationH> LibTransAllocationHs { get; set; }

    public virtual DbSet<LibTransD> LibTransDs { get; set; }

    public virtual DbSet<LibTransH> LibTransHes { get; set; }

    public virtual DbSet<LibTransType> LibTransTypes { get; set; }

    public virtual DbSet<LibTransWeb> LibTransWebs { get; set; }

    public virtual DbSet<LibType> LibTypes { get; set; }

    public virtual DbSet<LibUnit> LibUnits { get; set; }

    public virtual DbSet<LibVisit> LibVisits { get; set; }

    public virtual DbSet<LowImport> LowImports { get; set; }

    public virtual DbSet<LwrCase> LwrCases { get; set; }

    public virtual DbSet<LwrCaseDegAppeal> LwrCaseDegAppeals { get; set; }

    public virtual DbSet<LwrCaseDegCassation> LwrCaseDegCassations { get; set; }

    public virtual DbSet<LwrCaseDegFirst> LwrCaseDegFirsts { get; set; }

    public virtual DbSet<LwrCaseHistory> LwrCaseHistories { get; set; }

    public virtual DbSet<LwrCaseLower> LwrCaseLowers { get; set; }

    public virtual DbSet<LwrCaseProcedure> LwrCaseProcedures { get; set; }

    public virtual DbSet<LwrCaseStatus> LwrCaseStatuses { get; set; }

    public virtual DbSet<LwrCaseSubject> LwrCaseSubjects { get; set; }

    public virtual DbSet<LwrCaseType> LwrCaseTypes { get; set; }

    public virtual DbSet<LwrClint> LwrClints { get; set; }

    public virtual DbSet<LwrClintClass> LwrClintClasses { get; set; }

    public virtual DbSet<LwrCourt> LwrCourts { get; set; }

    public virtual DbSet<LwrCourtRoom> LwrCourtRooms { get; set; }

    public virtual DbSet<LwrCourtType> LwrCourtTypes { get; set; }

    public virtual DbSet<LwrCstCustomer> LwrCstCustomers { get; set; }

    public virtual DbSet<LwrCstEmp> LwrCstEmps { get; set; }

    public virtual DbSet<LwrCstPayType> LwrCstPayTypes { get; set; }

    public virtual DbSet<LwrCstPerson> LwrCstPeople { get; set; }

    public virtual DbSet<LwrCstService> LwrCstServices { get; set; }

    public virtual DbSet<LwrCstTran> LwrCstTrans { get; set; }

    public virtual DbSet<LwrCstTreasury> LwrCstTreasuries { get; set; }

    public virtual DbSet<LwrCust> LwrCusts { get; set; }

    public virtual DbSet<LwrDoc> LwrDocs { get; set; }

    public virtual DbSet<LwrDocType> LwrDocTypes { get; set; }

    public virtual DbSet<LwrEmp> LwrEmps { get; set; }

    public virtual DbSet<LwrHearing> LwrHearings { get; set; }

    public virtual DbSet<LwrHearingAction> LwrHearingActions { get; set; }

    public virtual DbSet<LwrHearingType> LwrHearingTypes { get; set; }

    public virtual DbSet<LwrLawyer> LwrLawyers { get; set; }

    public virtual DbSet<LwrLiability> LwrLiabilities { get; set; }

    public virtual DbSet<LwrLiabilityType> LwrLiabilityTypes { get; set; }

    public virtual DbSet<LwrOrg> LwrOrgs { get; set; }

    public virtual DbSet<LwrSubject> LwrSubjects { get; set; }

    public virtual DbSet<LwrtCategry> LwrtCategries { get; set; }

    public virtual DbSet<LwrtDayWork> LwrtDayWorks { get; set; }

    public virtual DbSet<LwrtTask> LwrtTasks { get; set; }

    public virtual DbSet<LwrtTaskDoc> LwrtTaskDocs { get; set; }

    public virtual DbSet<LwrtTaskType> LwrtTaskTypes { get; set; }

    public virtual DbSet<MbrArea> MbrAreas { get; set; }

    public virtual DbSet<MbrCustProject> MbrCustProjects { get; set; }

    public virtual DbSet<MbrCustomer> MbrCustomers { get; set; }

    public virtual DbSet<MbrDeduction> MbrDeductions { get; set; }

    public virtual DbSet<MbrDriver> MbrDrivers { get; set; }

    public virtual DbSet<MbrGover> MbrGovers { get; set; }

    public virtual DbSet<MbrItem> MbrItems { get; set; }

    public virtual DbSet<MbrProject> MbrProjects { get; set; }

    public virtual DbSet<MbrTelmarket> MbrTelmarkets { get; set; }

    public virtual DbSet<MbrTransD> MbrTransDs { get; set; }

    public virtual DbSet<MbrTransFast> MbrTransFasts { get; set; }

    public virtual DbSet<MbrTransH> MbrTransHes { get; set; }

    public virtual DbSet<MedIllnessType> MedIllnessTypes { get; set; }

    public virtual DbSet<MedMedicalCard> MedMedicalCards { get; set; }

    public virtual DbSet<MedStuIllness> MedStuIllnesses { get; set; }

    public virtual DbSet<MedStuPermission> MedStuPermissions { get; set; }

    public virtual DbSet<MmbAppointment> MmbAppointments { get; set; }

    public virtual DbSet<MmbAppotTran> MmbAppotTrans { get; set; }

    public virtual DbSet<MmbClass> MmbClasses { get; set; }

    public virtual DbSet<MmbComment> MmbComments { get; set; }

    public virtual DbSet<MmbDiscount> MmbDiscounts { get; set; }

    public virtual DbSet<MmbGroup> MmbGroups { get; set; }

    public virtual DbSet<MmbHall> MmbHalls { get; set; }

    public virtual DbSet<MmbMember> MmbMembers { get; set; }

    public virtual DbSet<MmbPayType> MmbPayTypes { get; set; }

    public virtual DbSet<MmbPeriod> MmbPeriods { get; set; }

    public virtual DbSet<MmbPtType> MmbPtTypes { get; set; }

    public virtual DbSet<MmbService> MmbServices { get; set; }

    public virtual DbSet<MmbSubscribe> MmbSubscribes { get; set; }

    public virtual DbSet<MmbTeam> MmbTeams { get; set; }

    public virtual DbSet<MmbTrainer> MmbTrainers { get; set; }

    public virtual DbSet<MmbTran> MmbTrans { get; set; }

    public virtual DbSet<MmbTreasury> MmbTreasuries { get; set; }

    public virtual DbSet<MmbTreservation> MmbTreservations { get; set; }

    public virtual DbSet<MpsCompany> MpsCompanies { get; set; }

    public virtual DbSet<MpsConnection> MpsConnections { get; set; }

    public virtual DbSet<MpsDirecrSalse> MpsDirecrSalses { get; set; }

    public virtual DbSet<MpsItem> MpsItems { get; set; }

    public virtual DbSet<MpsPariodD> MpsPariodDs { get; set; }

    public virtual DbSet<MpsPariodH> MpsPariodHs { get; set; }

    public virtual DbSet<MpsPlanMaster> MpsPlanMasters { get; set; }

    public virtual DbSet<MpsSalseLine> MpsSalseLines { get; set; }

    public virtual DbSet<MpsSalseLine1> MpsSalseLine1s { get; set; }

    public virtual DbSet<MpsTransD> MpsTransDs { get; set; }

    public virtual DbSet<MpsTransH> MpsTransHes { get; set; }

    public virtual DbSet<OmaAgent> OmaAgents { get; set; }

    public virtual DbSet<OmaArea> OmaAreas { get; set; }

    public virtual DbSet<OmaCandidate> OmaCandidates { get; set; }

    public virtual DbSet<OmaConstituency> OmaConstituencies { get; set; }

    public virtual DbSet<OmaCoordinator> OmaCoordinators { get; set; }

    public virtual DbSet<OmaElectoralCommissionsD> OmaElectoralCommissionsDs { get; set; }

    public virtual DbSet<OmaElectoralCommissionsH> OmaElectoralCommissionsHes { get; set; }

    public virtual DbSet<OmaEventType> OmaEventTypes { get; set; }

    public virtual DbSet<OmaFollower> OmaFollowers { get; set; }

    public virtual DbSet<OmaGover> OmaGovers { get; set; }

    public virtual DbSet<OmaResponcer> OmaResponcers { get; set; }

    public virtual DbSet<OmaTransElection> OmaTransElections { get; set; }

    public virtual DbSet<OmaTransEventD> OmaTransEventDs { get; set; }

    public virtual DbSet<OmaTransEventH> OmaTransEventHs { get; set; }

    public virtual DbSet<OmaTransSorting> OmaTransSortings { get; set; }

    public virtual DbSet<OmaVoter> OmaVoters { get; set; }

    public virtual DbSet<PadArea> PadAreas { get; set; }

    public virtual DbSet<PadBank> PadBanks { get; set; }

    public virtual DbSet<PadBankBranch> PadBankBranches { get; set; }

    public virtual DbSet<PadDisable> PadDisables { get; set; }

    public virtual DbSet<PadGover> PadGovers { get; set; }

    public virtual DbSet<PadGread> PadGreads { get; set; }

    public virtual DbSet<PadNational> PadNationals { get; set; }

    public virtual DbSet<PadResponsibile> PadResponsibiles { get; set; }

    public virtual DbSet<PadSchGread> PadSchGreads { get; set; }

    public virtual DbSet<PadSchType> PadSchTypes { get; set; }

    public virtual DbSet<PadSchool> PadSchools { get; set; }

    public virtual DbSet<PadStage> PadStages { get; set; }

    public virtual DbSet<PadStuDisable> PadStuDisables { get; set; }

    public virtual DbSet<PadStudent> PadStudents { get; set; }

    public virtual DbSet<PadTpayD> PadTpayDs { get; set; }

    public virtual DbSet<PadTpayH> PadTpayHs { get; set; }

    public virtual DbSet<PadTreasury> PadTreasuries { get; set; }

    public virtual DbSet<PadYear> PadYears { get; set; }

    public virtual DbSet<PadYearFee> PadYearFees { get; set; }

    public virtual DbSet<PafnCertificateD> PafnCertificateDs { get; set; }

    public virtual DbSet<PafnCertificateH> PafnCertificateHs { get; set; }

    public virtual DbSet<PafnCheckRequest> PafnCheckRequests { get; set; }

    public virtual DbSet<PafnInspection> PafnInspections { get; set; }

    public virtual DbSet<PafnLicense1> PafnLicense1s { get; set; }

    public virtual DbSet<PafnLicense2> PafnLicense2s { get; set; }

    public virtual DbSet<PafnLicense3> PafnLicense3s { get; set; }

    public virtual DbSet<PafnLicense4> PafnLicense4s { get; set; }

    public virtual DbSet<PafnLicense5> PafnLicense5s { get; set; }

    public virtual DbSet<PafnLicense6> PafnLicense6s { get; set; }

    public virtual DbSet<PafnLicense7> PafnLicense7s { get; set; }

    public virtual DbSet<PafnLicense8> PafnLicense8s { get; set; }

    public virtual DbSet<PafnPledge> PafnPledges { get; set; }

    public virtual DbSet<PafnRecordD1> PafnRecordD1s { get; set; }

    public virtual DbSet<PafnRecordD2> PafnRecordD2s { get; set; }

    public virtual DbSet<PafnRecordD3> PafnRecordD3s { get; set; }

    public virtual DbSet<PafnRecordD4> PafnRecordD4s { get; set; }

    public virtual DbSet<PafnRecordD5> PafnRecordD5s { get; set; }

    public virtual DbSet<PafnRecordH1> PafnRecordH1s { get; set; }

    public virtual DbSet<PafnRecordH2> PafnRecordH2s { get; set; }

    public virtual DbSet<PafnRecordH3> PafnRecordH3s { get; set; }

    public virtual DbSet<PafnRecordH4> PafnRecordH4s { get; set; }

    public virtual DbSet<PafnRecordH5> PafnRecordH5s { get; set; }

    public virtual DbSet<PafnTrans1> PafnTrans1s { get; set; }

    public virtual DbSet<PafnTrans2> PafnTrans2s { get; set; }

    public virtual DbSet<PafnTrans3> PafnTrans3s { get; set; }

    public virtual DbSet<PafnTrans4> PafnTrans4s { get; set; }

    public virtual DbSet<PafnVehicleLicense> PafnVehicleLicenses { get; set; }

    public virtual DbSet<PafnVoucher> PafnVouchers { get; set; }

    public virtual DbSet<Pbcatcol> Pbcatcols { get; set; }

    public virtual DbSet<Pbcatedt> Pbcatedts { get; set; }

    public virtual DbSet<Pbcatfmt> Pbcatfmts { get; set; }

    public virtual DbSet<Pbcattbl> Pbcattbls { get; set; }

    public virtual DbSet<Pbcatvld> Pbcatvlds { get; set; }

    public virtual DbSet<PosAmount> PosAmounts { get; set; }

    public virtual DbSet<PosAppointment> PosAppointments { get; set; }

    public virtual DbSet<PosArea> PosAreas { get; set; }

    public virtual DbSet<PosBranch> PosBranches { get; set; }

    public virtual DbSet<PosCasher> PosCashers { get; set; }

    public virtual DbSet<PosCategry> PosCategries { get; set; }

    public virtual DbSet<PosClass> PosClasses { get; set; }

    public virtual DbSet<PosColor> PosColors { get; set; }

    public virtual DbSet<PosCustCategry> PosCustCategries { get; set; }

    public virtual DbSet<PosCustomer> PosCustomers { get; set; }

    public virtual DbSet<PosCustomer1> PosCustomers1 { get; set; }

    public virtual DbSet<PosDay> PosDays { get; set; }

    public virtual DbSet<PosDriver> PosDrivers { get; set; }

    public virtual DbSet<PosGovernment> PosGovernments { get; set; }

    public virtual DbSet<PosInvoiceD> PosInvoiceDs { get; set; }

    public virtual DbSet<PosInvoiceH> PosInvoiceHs { get; set; }

    public virtual DbSet<PosItem> PosItems { get; set; }

    public virtual DbSet<PosItem1> PosItems1 { get; set; }

    public virtual DbSet<PosOrderD> PosOrderDs { get; set; }

    public virtual DbSet<PosOrderH> PosOrderHs { get; set; }

    public virtual DbSet<PosPayment> PosPayments { get; set; }

    public virtual DbSet<PosPriceListD> PosPriceListDs { get; set; }

    public virtual DbSet<PosPriceListH> PosPriceListHs { get; set; }

    public virtual DbSet<PosQty> PosQties { get; set; }

    public virtual DbSet<PosQuantity> PosQuantities { get; set; }

    public virtual DbSet<PosReason> PosReasons { get; set; }

    public virtual DbSet<PosReservation> PosReservations { get; set; }

    public virtual DbSet<PosSalesMan> PosSalesMen { get; set; }

    public virtual DbSet<PosSeat> PosSeats { get; set; }

    public virtual DbSet<PosSection> PosSections { get; set; }

    public virtual DbSet<PosShift> PosShifts { get; set; }

    public virtual DbSet<PosShift1> PosShifts1 { get; set; }

    public virtual DbSet<PosTransD> PosTransDs { get; set; }

    public virtual DbSet<PosTransH> PosTransHes { get; set; }

    public virtual DbSet<PosrAmount> PosrAmounts { get; set; }

    public virtual DbSet<PosrArea> PosrAreas { get; set; }

    public virtual DbSet<PosrBranch> PosrBranches { get; set; }

    public virtual DbSet<PosrCashier> PosrCashiers { get; set; }

    public virtual DbSet<PosrCustAddress> PosrCustAddresses { get; set; }

    public virtual DbSet<PosrCustGroup> PosrCustGroups { get; set; }

    public virtual DbSet<PosrCustomer> PosrCustomers { get; set; }

    public virtual DbSet<PosrDay> PosrDays { get; set; }

    public virtual DbSet<PosrDriver> PosrDrivers { get; set; }

    public virtual DbSet<PosrGover> PosrGovers { get; set; }

    public virtual DbSet<PosrInvoiceD> PosrInvoiceDs { get; set; }

    public virtual DbSet<PosrInvoiceH> PosrInvoiceHs { get; set; }

    public virtual DbSet<PosrItem> PosrItems { get; set; }

    public virtual DbSet<PosrItemAdd> PosrItemAdds { get; set; }

    public virtual DbSet<PosrItemInvComponent> PosrItemInvComponents { get; set; }

    public virtual DbSet<PosrItemPrinter> PosrItemPrinters { get; set; }

    public virtual DbSet<PosrNote> PosrNotes { get; set; }

    public virtual DbSet<PosrOrderD> PosrOrderDs { get; set; }

    public virtual DbSet<PosrOrderExtra> PosrOrderExtras { get; set; }

    public virtual DbSet<PosrOrderH> PosrOrderHs { get; set; }

    public virtual DbSet<PosrPayment> PosrPayments { get; set; }

    public virtual DbSet<PosrPriceListD> PosrPriceListDs { get; set; }

    public virtual DbSet<PosrPriceListH> PosrPriceListHs { get; set; }

    public virtual DbSet<PosrQty> PosrQties { get; set; }

    public virtual DbSet<PosrReason> PosrReasons { get; set; }

    public virtual DbSet<PosrReservation> PosrReservations { get; set; }

    public virtual DbSet<PosrSalesMan> PosrSalesMen { get; set; }

    public virtual DbSet<PosrSeat> PosrSeats { get; set; }

    public virtual DbSet<PosrSection> PosrSections { get; set; }

    public virtual DbSet<PosrShift> PosrShifts { get; set; }

    public virtual DbSet<PosrShiftD> PosrShiftDs { get; set; }

    public virtual DbSet<PosrSource> PosrSources { get; set; }

    public virtual DbSet<PosrTable> PosrTables { get; set; }

    public virtual DbSet<PosrTransType> PosrTransTypes { get; set; }

    public virtual DbSet<PosrWaiting> PosrWaitings { get; set; }

    public virtual DbSet<PrtyActivity> PrtyActivities { get; set; }

    public virtual DbSet<PrtyActivityType> PrtyActivityTypes { get; set; }

    public virtual DbSet<PrtyArea> PrtyAreas { get; set; }

    public virtual DbSet<PrtyDistrict> PrtyDistricts { get; set; }

    public virtual DbSet<PrtyGover> PrtyGovers { get; set; }

    public virtual DbSet<PrtyJob> PrtyJobs { get; set; }

    public virtual DbSet<PrtyMember> PrtyMembers { get; set; }

    public virtual DbSet<PrtySection> PrtySections { get; set; }

    public virtual DbSet<PrtySpecialization> PrtySpecializations { get; set; }

    public virtual DbSet<PrtyTelCompany> PrtyTelCompanies { get; set; }

    public virtual DbSet<PurArea> PurAreas { get; set; }

    public virtual DbSet<PurBranch> PurBranches { get; set; }

    public virtual DbSet<PurCategory> PurCategories { get; set; }

    public virtual DbSet<PurCountry> PurCountries { get; set; }

    public virtual DbSet<PurExpD> PurExpDs { get; set; }

    public virtual DbSet<PurExpDoc> PurExpDocs { get; set; }

    public virtual DbSet<PurExpH> PurExpHs { get; set; }

    public virtual DbSet<PurExpItem> PurExpItems { get; set; }

    public virtual DbSet<PurGroup> PurGroups { get; set; }

    public virtual DbSet<PurPayD> PurPayDs { get; set; }

    public virtual DbSet<PurPayDoc> PurPayDocs { get; set; }

    public virtual DbSet<PurPayH> PurPayHs { get; set; }

    public virtual DbSet<PurPayType> PurPayTypes { get; set; }

    public virtual DbSet<PurPriceListD> PurPriceListDs { get; set; }

    public virtual DbSet<PurPriceListH> PurPriceListHs { get; set; }

    public virtual DbSet<PurResponser> PurResponsers { get; set; }

    public virtual DbSet<PurShipCompany> PurShipCompanies { get; set; }

    public virtual DbSet<PurState> PurStates { get; set; }

    public virtual DbSet<PurTinvoiceD> PurTinvoiceDs { get; set; }

    public virtual DbSet<PurTinvoiceDoc> PurTinvoiceDocs { get; set; }

    public virtual DbSet<PurTinvoiceExp> PurTinvoiceExps { get; set; }

    public virtual DbSet<PurTinvoiceH> PurTinvoiceHs { get; set; }

    public virtual DbSet<PurTorderD> PurTorderDs { get; set; }

    public virtual DbSet<PurTorderDoc> PurTorderDocs { get; set; }

    public virtual DbSet<PurTorderExp> PurTorderExps { get; set; }

    public virtual DbSet<PurTorderH> PurTorderHs { get; set; }

    public virtual DbSet<PurTqoutationDoc> PurTqoutationDocs { get; set; }

    public virtual DbSet<PurTqoutationExp> PurTqoutationExps { get; set; }

    public virtual DbSet<PurTquotationD> PurTquotationDs { get; set; }

    public virtual DbSet<PurTquotationH> PurTquotationHs { get; set; }

    public virtual DbSet<PurTreasury> PurTreasuries { get; set; }

    public virtual DbSet<PurVenCat> PurVenCats { get; set; }

    public virtual DbSet<PurVendor> PurVendors { get; set; }

    public virtual DbSet<RcasCase> RcasCases { get; set; }

    public virtual DbSet<RconNationality> RconNationalities { get; set; }

    public virtual DbSet<RconReason> RconReasons { get; set; }

    public virtual DbSet<RconRent> RconRents { get; set; }

    public virtual DbSet<RconRentDoc> RconRentDocs { get; set; }

    public virtual DbSet<RconRentGroup> RconRentGroups { get; set; }

    public virtual DbSet<RconTransD> RconTransDs { get; set; }

    public virtual DbSet<RconTransDoc> RconTransDocs { get; set; }

    public virtual DbSet<RconTransH> RconTransHes { get; set; }

    public virtual DbSet<RconTransUnit> RconTransUnits { get; set; }

    public virtual DbSet<RconTransUnitD> RconTransUnitDs { get; set; }

    public virtual DbSet<RcpMeeting> RcpMeetings { get; set; }

    public virtual DbSet<RcpReception> RcpReceptions { get; set; }

    public virtual DbSet<RcpWeek> RcpWeeks { get; set; }

    public virtual DbSet<RcvArea> RcvAreas { get; set; }

    public virtual DbSet<RcvBank> RcvBanks { get; set; }

    public virtual DbSet<RcvBankAcc> RcvBankAccs { get; set; }

    public virtual DbSet<RcvBankBranch> RcvBankBranches { get; set; }

    public virtual DbSet<RcvCountry> RcvCountries { get; set; }

    public virtual DbSet<RcvGover> RcvGovers { get; set; }

    public virtual DbSet<RcvInstallmentD> RcvInstallmentDs { get; set; }

    public virtual DbSet<RcvInstallmentDoc> RcvInstallmentDocs { get; set; }

    public virtual DbSet<RcvInstallmentH> RcvInstallmentHs { get; set; }

    public virtual DbSet<RcvPayType> RcvPayTypes { get; set; }

    public virtual DbSet<RcvProject> RcvProjects { get; set; }

    public virtual DbSet<RcvTransDoc> RcvTransDocs { get; set; }

    public virtual DbSet<RcvTransH> RcvTransHes { get; set; }

    public virtual DbSet<RcvTreasury> RcvTreasuries { get; set; }

    public virtual DbSet<ReTransH> ReTransHes { get; set; }

    public virtual DbSet<RegArea> RegAreas { get; set; }

    public virtual DbSet<RegBranch> RegBranches { get; set; }

    public virtual DbSet<RegClass> RegClasses { get; set; }

    public virtual DbSet<RegDocType> RegDocTypes { get; set; }

    public virtual DbSet<RegEducational> RegEducationals { get; set; }

    public virtual DbSet<RegEmp> RegEmps { get; set; }

    public virtual DbSet<RegGover> RegGovers { get; set; }

    public virtual DbSet<RegGread> RegGreads { get; set; }

    public virtual DbSet<RegHandicapeType> RegHandicapeTypes { get; set; }

    public virtual DbSet<RegIdType> RegIdTypes { get; set; }

    public virtual DbSet<RegJob> RegJobs { get; set; }

    public virtual DbSet<RegKwtSchool> RegKwtSchools { get; set; }

    public virtual DbSet<RegNational> RegNationals { get; set; }

    public virtual DbSet<RegOrganization> RegOrganizations { get; set; }

    public virtual DbSet<RegPart> RegParts { get; set; }

    public virtual DbSet<RegRelegion> RegRelegions { get; set; }

    public virtual DbSet<RegResponsibile> RegResponsibiles { get; set; }

    public virtual DbSet<RegResponsibile1> RegResponsibile1s { get; set; }

    public virtual DbSet<RegResponsibile3> RegResponsibile3s { get; set; }

    public virtual DbSet<RegResponsibileOld> RegResponsibileOlds { get; set; }

    public virtual DbSet<RegSchool> RegSchools { get; set; }

    public virtual DbSet<RegStage> RegStages { get; set; }

    public virtual DbSet<RegStuOrg> RegStuOrgs { get; set; }

    public virtual DbSet<RegStudent> RegStudents { get; set; }

    public virtual DbSet<RegStudent1> RegStudent1s { get; set; }

    public virtual DbSet<RegStudent2> RegStudent2s { get; set; }

    public virtual DbSet<RegStudent3> RegStudent3s { get; set; }

    public virtual DbSet<RegStudentDoc> RegStudentDocs { get; set; }

    public virtual DbSet<RegStudentHistory> RegStudentHistories { get; set; }

    public virtual DbSet<RegStudentOld> RegStudentOlds { get; set; }

    public virtual DbSet<RegYear> RegYears { get; set; }

    public virtual DbSet<RmanBranch> RmanBranches { get; set; }

    public virtual DbSet<RmanBreakdown> RmanBreakdowns { get; set; }

    public virtual DbSet<RmanCategory> RmanCategories { get; set; }

    public virtual DbSet<RmanCompCat> RmanCompCats { get; set; }

    public virtual DbSet<RmanCompany> RmanCompanies { get; set; }

    public virtual DbSet<RmanCompanyGroup> RmanCompanyGroups { get; set; }

    public virtual DbSet<RmanDepartment> RmanDepartments { get; set; }

    public virtual DbSet<RmanEmpItem> RmanEmpItems { get; set; }

    public virtual DbSet<RmanEmploy> RmanEmploys { get; set; }

    public virtual DbSet<RmanExpense> RmanExpenses { get; set; }

    public virtual DbSet<RmanItem> RmanItems { get; set; }

    public virtual DbSet<RmanReason> RmanReasons { get; set; }

    public virtual DbSet<RmanTconDoc> RmanTconDocs { get; set; }

    public virtual DbSet<RmanTconH> RmanTconHs { get; set; }

    public virtual DbSet<RmanTconItem> RmanTconItems { get; set; }

    public virtual DbSet<RmanTconOther> RmanTconOthers { get; set; }

    public virtual DbSet<RmanTconPay> RmanTconPays { get; set; }

    public virtual DbSet<RmanTconUnit> RmanTconUnits { get; set; }

    public virtual DbSet<RmanTeam> RmanTeams { get; set; }

    public virtual DbSet<RmanTorderBreakdown> RmanTorderBreakdowns { get; set; }

    public virtual DbSet<RmanTorderCost> RmanTorderCosts { get; set; }

    public virtual DbSet<RmanTorderDoc> RmanTorderDocs { get; set; }

    public virtual DbSet<RmanTorderH> RmanTorderHs { get; set; }

    public virtual DbSet<RmanTransH> RmanTransHes { get; set; }

    public virtual DbSet<RmcConTerm> RmcConTerms { get; set; }

    public virtual DbSet<RmcConType> RmcConTypes { get; set; }

    public virtual DbSet<RmcReason> RmcReasons { get; set; }

    public virtual DbSet<RmcSignature> RmcSignatures { get; set; }

    public virtual DbSet<RmcTconDoc> RmcTconDocs { get; set; }

    public virtual DbSet<RmcTconH> RmcTconHs { get; set; }

    public virtual DbSet<RmcTconInst> RmcTconInsts { get; set; }

    public virtual DbSet<RmcTconItem> RmcTconItems { get; set; }

    public virtual DbSet<RmcTconTerm> RmcTconTerms { get; set; }

    public virtual DbSet<RmcTeam> RmcTeams { get; set; }

    public virtual DbSet<RmcTorderBreakdown> RmcTorderBreakdowns { get; set; }

    public virtual DbSet<RmcTorderCost> RmcTorderCosts { get; set; }

    public virtual DbSet<RmcTorderDoc> RmcTorderDocs { get; set; }

    public virtual DbSet<RmcTorderH> RmcTorderHs { get; set; }

    public virtual DbSet<RmcTreasury> RmcTreasuries { get; set; }

    public virtual DbSet<RmcVisitType> RmcVisitTypes { get; set; }

    public virtual DbSet<RpayBank> RpayBanks { get; set; }

    public virtual DbSet<RpayBankAcc> RpayBankAccs { get; set; }

    public virtual DbSet<RpayBankBranch> RpayBankBranches { get; set; }

    public virtual DbSet<RpayPayType> RpayPayTypes { get; set; }

    public virtual DbSet<RpayTransD> RpayTransDs { get; set; }

    public virtual DbSet<RpayTransDoc> RpayTransDocs { get; set; }

    public virtual DbSet<RpayTransH> RpayTransHes { get; set; }

    public virtual DbSet<RpayTreasury> RpayTreasuries { get; set; }

    public virtual DbSet<RprtOnwerGroup> RprtOnwerGroups { get; set; }

    public virtual DbSet<RprtOnwerType> RprtOnwerTypes { get; set; }

    public virtual DbSet<RprtOwner> RprtOwners { get; set; }

    public virtual DbSet<RprtPortfolio> RprtPortfolios { get; set; }

    public virtual DbSet<RprtPortfolioOwner> RprtPortfolioOwners { get; set; }

    public virtual DbSet<RprtPortfolioType> RprtPortfolioTypes { get; set; }

    public virtual DbSet<RrelAirType> RrelAirTypes { get; set; }

    public virtual DbSet<RrelArea> RrelAreas { get; set; }

    public virtual DbSet<RrelCountry> RrelCountries { get; set; }

    public virtual DbSet<RrelDocType> RrelDocTypes { get; set; }

    public virtual DbSet<RrelEmploy> RrelEmploys { get; set; }

    public virtual DbSet<RrelFloor> RrelFloors { get; set; }

    public virtual DbSet<RrelGover> RrelGovers { get; set; }

    public virtual DbSet<RrelOption> RrelOptions { get; set; }

    public virtual DbSet<RrelOutView> RrelOutViews { get; set; }

    public virtual DbSet<RrelReal> RrelReals { get; set; }

    public virtual DbSet<RrelRealDoc> RrelRealDocs { get; set; }

    public virtual DbSet<RrelRealHistory> RrelRealHistories { get; set; }

    public virtual DbSet<RrelRealOption> RrelRealOptions { get; set; }

    public virtual DbSet<RrelRealStatus> RrelRealStatuses { get; set; }

    public virtual DbSet<RrelRealType> RrelRealTypes { get; set; }

    public virtual DbSet<RrelUnit> RrelUnits { get; set; }

    public virtual DbSet<RrelUnitDoc> RrelUnitDocs { get; set; }

    public virtual DbSet<RrelUnitOption> RrelUnitOptions { get; set; }

    public virtual DbSet<RrelUnitType> RrelUnitTypes { get; set; }

    public virtual DbSet<SalArea> SalAreas { get; set; }

    public virtual DbSet<SalBranch> SalBranches { get; set; }

    public virtual DbSet<SalCategory> SalCategories { get; set; }

    public virtual DbSet<SalCountry> SalCountries { get; set; }

    public virtual DbSet<SalCustCat> SalCustCats { get; set; }

    public virtual DbSet<SalCustomer> SalCustomers { get; set; }

    public virtual DbSet<SalExpD> SalExpDs { get; set; }

    public virtual DbSet<SalExpDoc> SalExpDocs { get; set; }

    public virtual DbSet<SalExpH> SalExpHs { get; set; }

    public virtual DbSet<SalExpItem> SalExpItems { get; set; }

    public virtual DbSet<SalGroup> SalGroups { get; set; }

    public virtual DbSet<SalPayD> SalPayDs { get; set; }

    public virtual DbSet<SalPayDoc> SalPayDocs { get; set; }

    public virtual DbSet<SalPayH> SalPayHs { get; set; }

    public virtual DbSet<SalPayType> SalPayTypes { get; set; }

    public virtual DbSet<SalPriceListD> SalPriceListDs { get; set; }

    public virtual DbSet<SalPriceListH> SalPriceListHs { get; set; }

    public virtual DbSet<SalResponser> SalResponsers { get; set; }

    public virtual DbSet<SalResponserExt> SalResponserExts { get; set; }

    public virtual DbSet<SalState> SalStates { get; set; }

    public virtual DbSet<SalTinvoiceD> SalTinvoiceDs { get; set; }

    public virtual DbSet<SalTinvoiceDoc> SalTinvoiceDocs { get; set; }

    public virtual DbSet<SalTinvoiceExp> SalTinvoiceExps { get; set; }

    public virtual DbSet<SalTinvoiceH> SalTinvoiceHs { get; set; }

    public virtual DbSet<SalTorderD> SalTorderDs { get; set; }

    public virtual DbSet<SalTorderDoc> SalTorderDocs { get; set; }

    public virtual DbSet<SalTorderExp> SalTorderExps { get; set; }

    public virtual DbSet<SalTorderH> SalTorderHs { get; set; }

    public virtual DbSet<SalTqoutationDoc> SalTqoutationDocs { get; set; }

    public virtual DbSet<SalTqoutationExp> SalTqoutationExps { get; set; }

    public virtual DbSet<SalTquotationD> SalTquotationDs { get; set; }

    public virtual DbSet<SalTquotationH> SalTquotationHs { get; set; }

    public virtual DbSet<SalTreasury> SalTreasuries { get; set; }

    public virtual DbSet<SchClbMember> SchClbMembers { get; set; }

    public virtual DbSet<SchClbService> SchClbServices { get; set; }

    public virtual DbSet<SchClbTeam> SchClbTeams { get; set; }

    public virtual DbSet<SchClbTransH> SchClbTransHes { get; set; }

    public virtual DbSet<SchClbTrnasD> SchClbTrnasDs { get; set; }

    public virtual DbSet<SchCourseWeek> SchCourseWeeks { get; set; }

    public virtual DbSet<SchWeek> SchWeeks { get; set; }

    public virtual DbSet<SecGroup> SecGroups { get; set; }

    public virtual DbSet<SecGroupModule> SecGroupModules { get; set; }

    public virtual DbSet<SecGroupWin> SecGroupWins { get; set; }

    public virtual DbSet<SecLang> SecLangs { get; set; }

    public virtual DbSet<SecLog> SecLogs { get; set; }

    public virtual DbSet<SecModule> SecModules { get; set; }

    public virtual DbSet<SecModuleWin> SecModuleWins { get; set; }

    public virtual DbSet<SecParamter> SecParamters { get; set; }

    public virtual DbSet<SecSolution> SecSolutions { get; set; }

    public virtual DbSet<SecSolutionModule> SecSolutionModules { get; set; }

    public virtual DbSet<SecTranslation> SecTranslations { get; set; }

    public virtual DbSet<SecTranslationMenu> SecTranslationMenus { get; set; }

    public virtual DbSet<SecTranslationMsg> SecTranslationMsgs { get; set; }

    public virtual DbSet<SecUser> SecUsers { get; set; }

    public virtual DbSet<SecUserAccAccount> SecUserAccAccounts { get; set; }

    public virtual DbSet<SecUserAccAnalysis> SecUserAccAnalyses { get; set; }

    public virtual DbSet<SecUserAccCostCenter> SecUserAccCostCenters { get; set; }

    public virtual DbSet<SecUserAccExp> SecUserAccExps { get; set; }

    public virtual DbSet<SecUserAccJournal> SecUserAccJournals { get; set; }

    public virtual DbSet<SecUserDataBranch> SecUserDataBranches { get; set; }

    public virtual DbSet<SecUserDataClass> SecUserDataClasses { get; set; }

    public virtual DbSet<SecUserDataCourse> SecUserDataCourses { get; set; }

    public virtual DbSet<SecUserDataCustomer> SecUserDataCustomers { get; set; }

    public virtual DbSet<SecUserDataDocType> SecUserDataDocTypes { get; set; }

    public virtual DbSet<SecUserDataGread> SecUserDataGreads { get; set; }

    public virtual DbSet<SecUserDataLibrary> SecUserDataLibraries { get; set; }

    public virtual DbSet<SecUserDataPortfolio> SecUserDataPortfolios { get; set; }

    public virtual DbSet<SecUserDataTreasury> SecUserDataTreasuries { get; set; }

    public virtual DbSet<SecUserDataVendor> SecUserDataVendors { get; set; }

    public virtual DbSet<SecUserDataWarehouse> SecUserDataWarehouses { get; set; }

    public virtual DbSet<SecUserGroup> SecUserGroups { get; set; }

    public virtual DbSet<SecUserInvItem> SecUserInvItems { get; set; }

    public virtual DbSet<SecUserInvOrg> SecUserInvOrgs { get; set; }

    public virtual DbSet<SecUserInvWarehouse> SecUserInvWarehouses { get; set; }

    public virtual DbSet<SecUserLogen> SecUserLogens { get; set; }

    public virtual DbSet<SecUserModule> SecUserModules { get; set; }

    public virtual DbSet<SecUserPosrBranch> SecUserPosrBranches { get; set; }

    public virtual DbSet<SecUserPosrCust> SecUserPosrCusts { get; set; }

    public virtual DbSet<SecUserPosrShift> SecUserPosrShifts { get; set; }

    public virtual DbSet<SecUserPurBranch> SecUserPurBranches { get; set; }

    public virtual DbSet<SecUserPurTreasury> SecUserPurTreasuries { get; set; }

    public virtual DbSet<SecUserPurVendor> SecUserPurVendors { get; set; }

    public virtual DbSet<SecUserSalBranch> SecUserSalBranches { get; set; }

    public virtual DbSet<SecUserSalCust> SecUserSalCusts { get; set; }

    public virtual DbSet<SecUserSalTreasury> SecUserSalTreasuries { get; set; }

    public virtual DbSet<SecUserWin> SecUserWins { get; set; }

    public virtual DbSet<SecWinNew> SecWinNews { get; set; }

    public virtual DbSet<SecWindow> SecWindows { get; set; }

    public virtual DbSet<SfcBomD> SfcBomDs { get; set; }

    public virtual DbSet<SfcBomH> SfcBomHs { get; set; }

    public virtual DbSet<SfcFacility> SfcFacilities { get; set; }

    public virtual DbSet<SfcMethod> SfcMethods { get; set; }

    public virtual DbSet<SfcProcess> SfcProcesses { get; set; }

    public virtual DbSet<SfcRouting> SfcRoutings { get; set; }

    public virtual DbSet<SfcTransBom> SfcTransBoms { get; set; }

    public virtual DbSet<SfcTransD> SfcTransDs { get; set; }

    public virtual DbSet<SfcTransDoc> SfcTransDocs { get; set; }

    public virtual DbSet<SfcTransH> SfcTransHes { get; set; }

    public virtual DbSet<SfcTransMatrix> SfcTransMatrices { get; set; }

    public virtual DbSet<SfcTransRouting> SfcTransRoutings { get; set; }

    public virtual DbSet<SfcWorkcenter> SfcWorkcenters { get; set; }

    public virtual DbSet<ShfExpier> ShfExpiers { get; set; }

    public virtual DbSet<ShfExpierCaptal> ShfExpierCaptals { get; set; }

    public virtual DbSet<ShfExport> ShfExports { get; set; }

    public virtual DbSet<ShfExportCaptal> ShfExportCaptals { get; set; }

    public virtual DbSet<ShfReport> ShfReports { get; set; }

    public virtual DbSet<ShpCustGroup> ShpCustGroups { get; set; }

    public virtual DbSet<ShpCustomer> ShpCustomers { get; set; }

    public virtual DbSet<ShpDiscount> ShpDiscounts { get; set; }

    public virtual DbSet<ShpEmp> ShpEmps { get; set; }

    public virtual DbSet<ShpExpItem> ShpExpItems { get; set; }

    public virtual DbSet<ShpGroup> ShpGroups { get; set; }

    public virtual DbSet<ShpMarka> ShpMarkas { get; set; }

    public virtual DbSet<ShpRent> ShpRents { get; set; }

    public virtual DbSet<ShpService> ShpServices { get; set; }

    public virtual DbSet<ShpShip> ShpShips { get; set; }

    public virtual DbSet<ShpTcontract> ShpTcontracts { get; set; }

    public virtual DbSet<ShpTcontractService> ShpTcontractServices { get; set; }

    public virtual DbSet<ShpTexpensess> ShpTexpensesses { get; set; }

    public virtual DbSet<ShpTicket> ShpTickets { get; set; }

    public virtual DbSet<ShpTpayment> ShpTpayments { get; set; }

    public virtual DbSet<ShpTreasury> ShpTreasuries { get; set; }

    public virtual DbSet<ShpTwaiting> ShpTwaitings { get; set; }

    public virtual DbSet<ShpgBosale> ShpgBosales { get; set; }

    public virtual DbSet<ShpgDeleteRequest> ShpgDeleteRequests { get; set; }

    public virtual DbSet<ShpgInspection> ShpgInspections { get; set; }

    public virtual DbSet<ShpgRegistWatercraft> ShpgRegistWatercrafts { get; set; }

    public virtual DbSet<ShpgRequestCertificate> ShpgRequestCertificates { get; set; }

    public virtual DbSet<ShpgRequestProof> ShpgRequestProofs { get; set; }

    public virtual DbSet<ShpgRequestProofNon> ShpgRequestProofNons { get; set; }

    public virtual DbSet<TblMidDatum> TblMidData { get; set; }

    public virtual DbSet<TblMidPo> TblMidPos { get; set; }

    public virtual DbSet<TshEmp> TshEmps { get; set; }

    public virtual DbSet<TshEmpTask> TshEmpTasks { get; set; }

    public virtual DbSet<TshTask> TshTasks { get; set; }

    public virtual DbSet<TshTask1> TshTasks1 { get; set; }

    public virtual DbSet<TshTran> TshTrans { get; set; }

    public virtual DbSet<TshWeek> TshWeeks { get; set; }

    public virtual DbSet<TskTask> TskTasks { get; set; }

    public virtual DbSet<TskTaskType> TskTaskTypes { get; set; }

    public virtual DbSet<TtbBranchGrade> TtbBranchGrades { get; set; }

    public virtual DbSet<TtbTran> TtbTrans { get; set; }

    public virtual DbSet<VCiepCourseLevel> VCiepCourseLevels { get; set; }

    public virtual DbSet<VDddwInvTransTransferAllocatPosr> VDddwInvTransTransferAllocatPosrs { get; set; }

    public virtual DbSet<VExmCourse> VExmCourses { get; set; }

    public virtual DbSet<VInvTransD> VInvTransDs { get; set; }

    public virtual DbSet<WcnConTerm> WcnConTerms { get; set; }

    public virtual DbSet<WcnContType> WcnContTypes { get; set; }

    public virtual DbSet<WcnExpD> WcnExpDs { get; set; }

    public virtual DbSet<WcnExpDoc> WcnExpDocs { get; set; }

    public virtual DbSet<WcnExpH> WcnExpHs { get; set; }

    public virtual DbSet<WcnExpensesItem> WcnExpensesItems { get; set; }

    public virtual DbSet<WcnPayD> WcnPayDs { get; set; }

    public virtual DbSet<WcnPayDoc> WcnPayDocs { get; set; }

    public virtual DbSet<WcnPayH> WcnPayHs { get; set; }

    public virtual DbSet<WcnTransH> WcnTransHes { get; set; }

    public virtual DbSet<WcnTransHDoc> WcnTransHDocs { get; set; }

    public virtual DbSet<WcnTransInst> WcnTransInsts { get; set; }

    public virtual DbSet<WcnTransTerm> WcnTransTerms { get; set; }

    public virtual DbSet<WcnTreasury> WcnTreasuries { get; set; }

    public virtual DbSet<WflTask> WflTasks { get; set; }

    public virtual DbSet<WflTaskD> WflTaskDs { get; set; }

    public virtual DbSet<WflTaskH> WflTaskHs { get; set; }

    public virtual DbSet<WflTransD> WflTransDs { get; set; }

    public virtual DbSet<WflTransDDoc> WflTransDDocs { get; set; }

    public virtual DbSet<WflTransH> WflTransHes { get; set; }

    public virtual DbSet<WflTransHDoc> WflTransHDocs { get; set; }

    public virtual DbSet<WtsAction> WtsActions { get; set; }

    public virtual DbSet<WtsMonth> WtsMonths { get; set; }

    public virtual DbSet<WtsTran> WtsTrans { get; set; }

    public virtual DbSet<WtsTransDoc> WtsTransDocs { get; set; }

    public virtual DbSet<WtsWeek> WtsWeeks { get; set; }

    public virtual DbSet<WtsYear> WtsYears { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=AOE_nokhba_2023;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<AccAccAnalysis>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccAccCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccAccCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_acc_coset");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccAccExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccAccount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccAnalysis>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccAnalysisBudget>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccBudget>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_Category");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccCheque>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccCostBudget>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccCostCenter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccCurrency>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccExchangeRate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccExpBudget>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccExpense>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccJournal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccPariodD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccPariodH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccRetransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccRetransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccRetransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccTransCheque>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpExam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpExamType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpExaminer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acp_Examiner");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpExmRoom>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpExmSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acp_exm_Schedule");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpResponsibile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acp_RESPONSIBILE");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpStuExm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AcpStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acp_STUDENT");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.HealthTel).IsFixedLength();
        });

        modelBuilder.Entity<AcpStudent1>(entity =>
        {
            entity.Property(e => e.HelthTel).IsFixedLength();
        });

        modelBuilder.Entity<AdlArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlConExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlConTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlConType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlPayExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlTransExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdlTransTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAsset>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_asset_Component");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetDepreciation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_asset_Depreciation");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstAssetType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_Branch");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstCompanyInsurance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_asset_Company_ins");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstComponentLabel>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_Department");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstDivision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_Division");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstEmploy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_Employ");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ast_Location");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransAllocationD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransAllocationDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransAllocationH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AstTransType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusAssistant>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusBu>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusDriver>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusResponser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BusTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_C_byn_activity");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_C_byn_company");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_C_byn_main");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynOther>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_C_byn_other");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_C_byn_product");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynQuation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CBynTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarCustGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarDiscount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarMaintenanceItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_car_Maintenance_item");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarMarka>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarRent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarTcontract>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarTcontractService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_c_car_tcontract_service");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarTicket>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarTmaintanance>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarTpayment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CCarTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrderId).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CartAddress>(entity =>
        {
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CartPayment>(entity =>
        {
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepChecklist>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepChecklistClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepClassTeacher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepCourseObjective>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepObjective>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepRowType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepStudent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepTeacher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepTransChecklist>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepTransDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepTransIep>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CiepTransNote>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthCust>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthCustOrder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Path1).IsFixedLength();
            entity.Property(e => e.Path2).IsFixedLength();
            entity.Property(e => e.Path3).IsFixedLength();
        });

        modelBuilder.Entity<ClthEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthPur>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthSalary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClthWh>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_Category");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsContCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_ven_cat");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsContractor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_Contractor");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_Department");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsExpItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsProjItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsProject>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsResponser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsState>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTcontractD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTcontractH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_contract_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTinvoiceD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTinvoiceDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_invoice_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTinvoiceExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_invoice_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTinvoiceH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_tinvoice_h2");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTorderD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_order_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTorderDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_order_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTorderExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_order_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTorderH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_order_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTqoutationDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_qoutation_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTqoutationExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_qoutation_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTquotationD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_Quotation_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CnsTquotationH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cns_Quotation_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCarEquipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cnt_car_Equipment");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCarGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCarMarka>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cnt_marka");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCarPermeation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cnt_Category");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntContCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntContractor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntEmpDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntEmpGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntEmpPermeation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntEmpVacation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cnt_emp_Vacation");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntExpItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntLocation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntMaintananceItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntPermeation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cnt_Permitting");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntResponser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntState>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTconDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTconEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTconExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTconPurOrder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTconTrem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTcontractH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTjobOrder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTmaintanance>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTpayment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CntTworkCard>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgBorder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CntEmpId).IsFixedLength();
        });

        modelBuilder.Entity<CrgCargoType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgDeliveryNote>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgDispatch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgDispatchDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgEmployee>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgExpD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgExpDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgExpH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgExpItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgInvoiceItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgPayD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgPayDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgPayH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgShipment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgShipmentDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgStage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTinvoiceD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTinvoiceDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTinvoiceExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTinvoiceH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTorderD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTorderDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTorderExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTorderH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTquotationD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTquotationDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTquotationExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTquotationH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrgVendor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CstDocTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CstOm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CstOrg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Contact).IsFixedLength();
        });

        modelBuilder.Entity<CstTel>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurCourseUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurCourseUnitWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurTransDoc>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_cur_trans_doc_1")
                .IsClustered(false);

            entity.HasIndex(e => e.Id, "pk_cur_trans_doc")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurUnitType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrChecklist>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrCourseObjective>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrCourseTechStu>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrExam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrLevel>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMAssessment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMAssessmentStrategy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMComment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMEnvironmental>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMInstructional>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMNeed>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMStrength>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrMTeachingStrategy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrObjective>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrStuInsEnvAss>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrStuRelevant>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrStuStrengthNeed>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrStuSub>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrStuTeacherNote>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrStudent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrSubCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrTeacher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrTransAssessement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrTransPlan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CurrYearAcademy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursConcept>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursDisability>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursExam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursLevel>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursLevelCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursLevelUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursObjective>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursStage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursStageCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursStageUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursStudent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursSubstage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursTool>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CursUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspAircraftConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dsp_air_craft_config");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspAircraftConfigCharge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dsp_air_craft_config_charges");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspAircraftConfigGalleyPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dsp_air_craft_galley_plan");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspBomH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspBomRouting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspBoomD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDepartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dsp_diah");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDispatch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDispatchCharge>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDispatchD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDispatchReduction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspDispatchSpl>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspLoadingScale>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspLoadingScaleDish>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspPriceMatrix>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspProcess>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspSchedule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspScheduleFlight>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspScheduleMeal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspScheduleMealReduction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspSector>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspStorageType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DspWorkcenter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Eexp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_acc_budget");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquCarsCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquCarsClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquCarsDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquCarsMarka>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquDepartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquEmploy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquMaintananceItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquTcontractD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.DIdNavigation).WithMany(p => p.EquTcontractDs).HasConstraintName("fk_equ_tcontract_d_equ_tcontrct_cars");

            entity.HasOne(d => d.HIdNavigation).WithMany(p => p.EquTcontractDs).HasConstraintName("fk_equ_tcontract_d_equ_tcontrct_h");

            entity.HasOne(d => d.SalInvoice).WithMany(p => p.EquTcontractDs).HasConstraintName("fk_equ_tcontract_d_sal_tinvoice_h");
        });

        modelBuilder.Entity<EquTcontrctCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.HIdNavigation).WithMany(p => p.EquTcontrctCars).HasConstraintName("fk_equ_tcontrct_cars_equ_tcontrct_h");
        });

        modelBuilder.Entity<EquTcontrctCarsDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquTcontrctDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquTcontrctH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.SalBranch).WithMany(p => p.EquTcontrctHs).HasConstraintName("fk_equ_tcontrct_h_sal_branch");
        });

        modelBuilder.Entity<EquTmaintananceD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Car).WithMany(p => p.EquTmaintananceDs).HasConstraintName("fk_equ_tmaintanance_d_equ_cars");

            entity.HasOne(d => d.Emp).WithMany(p => p.EquTmaintananceDs).HasConstraintName("fk_equ_tmaintanance_d_equ_employ");

            entity.HasOne(d => d.Equipment).WithMany(p => p.EquTmaintananceDs).HasConstraintName("fk_equ_tmaintanance_d_equ_maintanance_item");

            entity.HasOne(d => d.HIdNavigation).WithMany(p => p.EquTmaintananceDs).HasConstraintName("fk_equ_tmaintanance_d_equ_tmaintanance_h");
        });

        modelBuilder.Entity<EquTmaintananceDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EquTmaintananceH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgAgent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgAgentBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgBanck>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgBanckBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgBlackList>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgCountryCurrency>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgCurrency>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgCustGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgCustRecipient>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgEmploy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgExchangeRate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgIdType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgNationality>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgRecipient>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgTransType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExgTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmAttendance>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmCalendarBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_calendar_branch");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmCalendarMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_calendar_main");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmCalendarMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_calendar_master");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Comment");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Course");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmCourseClassTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Course_class_Teacher");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmCourseGread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Course_gread");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Skills");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmSkillsItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Skills_item");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmStudentAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_student_attendance");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Teacher");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Term");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmTermExam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_Term_Exam");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmTran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Exm_trans");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmTranscript>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmdCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmdExam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmdExamCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmdExamClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmdTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExmdType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpDiscItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EXP_DISCOUNTS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpExpItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EXPENSES");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpGreadExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EXP_GREAD_EXP");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpPayD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.HIdNavigation).WithMany(p => p.ExpPayDs).HasConstraintName("FK_exp_pay_d_exp_pay_h");

            entity.HasOne(d => d.Student).WithMany(p => p.ExpPayDs).HasConstraintName("FK_exp_pay_d_reg_student");
        });

        modelBuilder.Entity<ExpPayDWeb>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpPayH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Responsibile).WithMany(p => p.ExpPayHs).HasConstraintName("FK_exp_pay_h_reg_responsibile");
        });

        modelBuilder.Entity<ExpPayHWeb>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpPayItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpPayTypeWeb>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpPayWay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EXP_PAY_TYPES");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpStuAccount>(entity =>
        {
            entity.Property(e => e.Posted).IsFixedLength();
        });

        modelBuilder.Entity<ExpTreasury>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EXP_TREASURY");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExpTreasuryItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenAlarm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenAnalysisRep>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenCrosstab>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenCrosstabH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenGraphD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenGraphH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRconCon>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepAcc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepAcp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepAcpStu>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepHrAtd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_gen_rep_hr_emp_rep");
        });

        modelBuilder.Entity<GenRepHrEmpRep>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_gen_rep_hr_emp_rep_1")
                .IsClustered(false);

            entity.HasIndex(e => e.Id, "pk_gen_rep_hr_emp_rep")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepPad>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepPur>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepSal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRepWcn>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenRfid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_PK_gen_rfid1");
        });

        modelBuilder.Entity<GenTranslation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenWcnRep>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GovArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GovDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GovGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GovOrg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Contact).IsFixedLength();
        });

        modelBuilder.Entity<GovPersson>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GovTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HaptAppiontment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HaptDoctor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HaptPatient>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HaptPatientDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAcdmcQulfc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hr_Academic_Qualifications");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAtdCalendarD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAtdCalendarH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAtdEmpTimetable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAtdImport>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAtdMachine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hr_atd_Machine");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrAtdTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrBank>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrBankAcc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrBankBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrCalendarD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hr_Calendar_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrCalenderH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrCategry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrCompanyLicense>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrDeprt>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmpClass>(entity =>
        {
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmpGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmpSalary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
        });

        modelBuilder.Entity<HrEmpTimetable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmpType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmployAcdmcQulfc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmployCalender>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmployClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmployDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmployVacation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrEmply>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
        });

        modelBuilder.Entity<HrEmply2>(entity =>
        {
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
        });

        modelBuilder.Entity<HrEmply3>(entity =>
        {
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
        });

        modelBuilder.Entity<HrEmply4>(entity =>
        {
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
        });

        modelBuilder.Entity<HrEmplySalaryPlan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrJob>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrNationalty>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrPayIndemnity>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrRegonal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrSignature>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.AccAnalysisId).IsFixedLength();
        });

        modelBuilder.Entity<HraBonusType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraDegree>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraPenaltiesType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraPromotedType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraTbonu>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraTpromotion>(entity =>
        {
            entity.Property(e => e.PromotedTypeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HraTrnasferReson>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreEvaluationD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreEvaluationH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HreType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCarDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCarMarka>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCarTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCarTransD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hr_trans_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCarTransDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hra_trans_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCarTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfConInstallment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfConTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfContract>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfContractDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfCustomerDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfDocTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfDocTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfEmpConTeam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfFurniture>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfRequestD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfRequestH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfTaskD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfTaskDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfTaskH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfTeam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfTeamDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfUnitDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfUnitFurniture>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfUnitTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfVendor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrfVendorDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspAllergy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspClinic>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspDepartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspDoctor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspHospital>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspInsCompGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspInsuranceCompany>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspJob>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspNationality>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPatCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPatDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPatient>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPayTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPayTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPayTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPriceListD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspPriceListH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspRelegion>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspReqGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspReqTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspReqTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspReqTypeD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspReqTypeH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspRoom>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HspVisit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsCar>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsCarGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsCarType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsCarTypeItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InsNational>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvCategry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvClass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_class");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_group");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_items");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvItemCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvItemCont>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvItemLot>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvItemUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_item_unit");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvItemsLabel>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_Location");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvMatrix>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvMatrixUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvOrg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_reason");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTinventoryD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_inv_inventory_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTinventoryDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTinventoryH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransAllocationD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransAllocationH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INV_trans_allocation_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransCont>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_trans_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransH>(entity =>
        {
            entity.HasKey(e => e.TransDate).HasName("PK_Inv_trans_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransMatrix>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvTransType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_trans_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_item_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IssuePolce).IsFixedLength();
        });

        modelBuilder.Entity<InvUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvWarehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inv_whs");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibActivtyType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibCategry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibClassification>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibItemCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibItemUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibItemsBook>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lib_whs");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lib_Location");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibOrg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibRecalculationD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibRecalculationH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTactivty>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibThistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.RentBy).IsFixedLength();
        });

        modelBuilder.Entity<LibTransAllocationD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTransAllocationH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTransType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibTransWeb>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lib_item_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LibVisit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LowImport>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCase>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseDegAppeal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_deg_appeal");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseDegCassation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_deg_cassation");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseDegFirst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_deg_first");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_history");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseLower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_lower");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseProcedure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_procedure");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_status");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Case_subject");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCaseType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrClint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Clint");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrClintClass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Clint_class");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCourt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Court");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCourtRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Court_room");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCourtType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Court_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstPerson>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCstTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrCust>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrHearing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Hearing");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrHearingAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Hearing_action");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrHearingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Hearing_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrLawyer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Lawyer");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrLiability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Liability");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrLiabilityType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lwr_Liability_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrOrg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrSubject>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrtCategry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrtDayWork>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrtTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrtTaskDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LwrtTaskType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrCustProject>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrDriver>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrProject>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrTelmarket>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrTransFast>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MbrTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MedIllnessType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MedMedicalCard>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MedStuIllness>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MedStuPermission>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbAppointment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbAppotTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbComment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbDiscount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbHall>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TrainersId).IsFixedLength();
        });

        modelBuilder.Entity<MmbMember>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbPeriod>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbPtType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbSubscribe>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbTeam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbTrainer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmbTreservation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_mps_Company");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsConnection>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsDirecrSalse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsPariodD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsPariodH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsPlanMaster>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsSalseLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_mps_salse_line2");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsSalseLine1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_mps_salse_line");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MpsTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaAgent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Agents");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Areas");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaCandidate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Candidates");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaConstituency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Constituencies");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaCoordinator>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaElectoralCommissionsD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Electoral_commissions");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaElectoralCommissionsH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Electoral_commissions_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaEventType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Event_types");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaFollower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Followers");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaResponcer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaTransElection>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaTransEventD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_tevent_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaTransEventH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_tevent_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaTransSorting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_trans_Sorting");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OmaVoter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_oma_Voters");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadBank>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadBankBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadDisable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadGread>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadNational>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadResponsibile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadSchGread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pad_class");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadSchType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadSchool>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadStage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadStuDisable>(entity =>
        {
            entity.Property(e => e.DisableId).IsFixedLength();
        });

        modelBuilder.Entity<PadStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pad_student_1");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadTpayD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadTpayH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadYear>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PadYearFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pad_fees");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnCertificateD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnCertificateH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnCheckRequest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnInspection>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense2>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense3>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense4>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense5>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense6>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense7>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnLicense8>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnPledge>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordD1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordD2>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordD3>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordD4>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordD5>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordH1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordH2>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordH3>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordH4>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnRecordH5>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnTrans1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnTrans2>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnTrans3>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnTrans4>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnVehicleLicense>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PafnVoucher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Pbcatcol>(entity =>
        {
            entity.Property(e => e.PbcBmap).IsFixedLength();
            entity.Property(e => e.PbcCnam).IsFixedLength();
            entity.Property(e => e.PbcOwnr).IsFixedLength();
            entity.Property(e => e.PbcTnam).IsFixedLength();
        });

        modelBuilder.Entity<Pbcatedt>(entity =>
        {
            entity.Property(e => e.PbeWork).IsFixedLength();
        });

        modelBuilder.Entity<Pbcattbl>(entity =>
        {
            entity.Property(e => e.PbdFfce).IsFixedLength();
            entity.Property(e => e.PbdFitl).IsFixedLength();
            entity.Property(e => e.PbdFunl).IsFixedLength();
            entity.Property(e => e.PbhFfce).IsFixedLength();
            entity.Property(e => e.PbhFitl).IsFixedLength();
            entity.Property(e => e.PbhFunl).IsFixedLength();
            entity.Property(e => e.PblFfce).IsFixedLength();
            entity.Property(e => e.PblFitl).IsFixedLength();
            entity.Property(e => e.PblFunl).IsFixedLength();
            entity.Property(e => e.PbtOwnr).IsFixedLength();
            entity.Property(e => e.PbtTnam).IsFixedLength();
        });

        modelBuilder.Entity<PosAmount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosAppointment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosCasher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosCategry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosColor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosCustCategry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosDay>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosDriver>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosGovernment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosInvoiceD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pos_trans_check_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.HId).IsFixedLength();
        });

        modelBuilder.Entity<PosInvoiceH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pos_trans_check_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosItem1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosOrderD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pos_ttrans_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosOrderH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pos_ttrans_h");
        });

        modelBuilder.Entity<PosPayment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosPriceListD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosPriceListH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosQty>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosSalesMan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosSeat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TableId).IsFixedLength();
        });

        modelBuilder.Entity<PosSection>(entity =>
        {
            entity.Property(e => e.BranchId).IsFixedLength();
        });

        modelBuilder.Entity<PosShift>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosShift1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrAmount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrCashier>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrCustAddress>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrCustGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrDay>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrDriver>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrInvoiceD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrInvoiceH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrItemAdd>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrItemInvComponent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrItemPrinter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrNote>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrOrderD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrOrderExtra>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrOrderH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrPayment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrPriceListD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrPriceListH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrQty>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrReservation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrSalesMan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrSeat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TableId).IsFixedLength();
        });

        modelBuilder.Entity<PosrSection>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.BranchId).IsFixedLength();
        });

        modelBuilder.Entity<PosrShift>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrShiftD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrSource>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SectionId).IsFixedLength();
        });

        modelBuilder.Entity<PosrTransType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_trans_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosrWaiting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyActivity>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyActivityType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyDistrict>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyJob>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_prty_Member");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtySection>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtySpecialization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_prty_Specialization");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PrtyTelCompany>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_Category");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurExpD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurExpDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurExpH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurExpItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurPayD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurPayDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurPayH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurPriceListD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurPriceListH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurResponser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurShipCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_shep_company");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurState>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTinvoiceD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_invoice_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTinvoiceDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_invoice_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTinvoiceExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_invoice_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTinvoiceH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_invoice_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTorderD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_order_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTorderDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_order_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTorderExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_order_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTorderH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_order_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTqoutationDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_qoutation_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTqoutationExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_qoutation_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTquotationD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_Quotation_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTquotationH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pur_Quotation_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurVenCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PurVendor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcasCase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cas_cases");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconNationality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rcon_");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rcon_Reason");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconRent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconRentDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconRentGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RconTransUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rcon_trans_uint");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcpMeeting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcpReception>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcpWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rcv_banck");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvBankAcc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvBankBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvInstallmentD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rcv_Installment_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvInstallmentDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvInstallmentH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rcv_Installment_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvPayType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_crv_pay_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvProject>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvTransH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_crv_trans_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RcvTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReTransH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hre_trans_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_AREA");
        });

        modelBuilder.Entity<RegBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_BRANCH");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegClass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_CLASS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegEducational>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_EDUCATIONAL");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegEmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_emp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegGover>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_STATE");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegGread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_GREAD");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegHandicapeType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegIdType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_ID_TYPE");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_JOB");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegNational>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_NATIONAL");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegOrganization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_ORGANIZATIONS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_PART");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegRelegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_RELEGION");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegResponsibile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegSchool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_SCHOOL");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_STAGE");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegStuOrg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_STU_ORG");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegStudent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.HelthTel).IsFixedLength();
        });

        modelBuilder.Entity<RegStudent1>(entity =>
        {
            entity.Property(e => e.HelthTel).IsFixedLength();
        });

        modelBuilder.Entity<RegStudent2>(entity =>
        {
            entity.Property(e => e.HelthTel).IsFixedLength();
        });

        modelBuilder.Entity<RegStudent3>(entity =>
        {
            entity.Property(e => e.HelthTel).IsFixedLength();
        });

        modelBuilder.Entity<RegStudentDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegStudentHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RegStudentOld>(entity =>
        {
            entity.Property(e => e.HelthTel).IsFixedLength();
        });

        modelBuilder.Entity<RegYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REG_YEARS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanBreakdown>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rman_Category");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanCompCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanCompany>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanCompanyGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanDepartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanEmpItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanEmploy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanExpense>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTconDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTconH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTconItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTconOther>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTconPay>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTconUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTeam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTorderBreakdown>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTorderCost>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTorderDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTorderH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmanTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcConTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rmc_con_terms");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcConType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcReason>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcSignature>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTconDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTconH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTconInst>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTconItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.HId).IsFixedLength();
        });

        modelBuilder.Entity<RmcTconTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTeam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTorderBreakdown>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTorderCost>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTorderDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTorderH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmcVisitType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayBank>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayBankAcc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayBankBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RpayTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RprtOnwerGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RprtOnwerType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RprtOwner>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RprtPortfolio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rprt_Portfolio");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RprtPortfolioOwner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rprt_Portfolio_owner");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RprtPortfolioType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rprt_Portfolio_type");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelAirType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rrel_Country");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelEmploy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelFloor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelGover>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelOption>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelOutView>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelReal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelRealDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelRealHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelRealOption>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelRealStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelRealType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelUnitDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelUnitOption>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RrelUnitType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_Category");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalCountry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalCustCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_ven_cat");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalExpD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalExpDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalExpH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalExpItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalPayD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalPayDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalPayH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalPayType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalPriceListD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalPriceListH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalResponser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalResponserExt>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalState>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTinvoiceD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_invoice_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTinvoiceDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_invoice_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTinvoiceExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_invoice_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTinvoiceH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_invoice_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTorderD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_order_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTorderDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_order_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTorderExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_order_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTorderH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_order_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTqoutationDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_qoutation_doc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTqoutationExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_qoutation_exp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTquotationD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_Quotation_d");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTquotationH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sal_Quotation_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchClbMember>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchClbService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchClbTeam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchClbTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchClbTrnasD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchCourseWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SchWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecGroupModule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecGroupWin>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecLang>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecModuleWin>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_sec_module_win_1")
                .IsClustered(false);

            entity.HasIndex(e => e.Id, "pk_sec_module_win")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecParamter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecSolution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SEC_SOLUTION");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecSolutionModule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecTranslation>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_sec_translation_1")
                .IsClustered(false);

            entity.HasIndex(e => e.Id, "pk_sec_translation")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecTranslationMenu>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.Id, "pk_sec_translation")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecTranslationMsg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserAccAccount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserAccAnalysis>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserAccCostCenter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserAccExp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserAccJournal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserDataBranch>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataClass>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataCourse>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataCustomer>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataDocType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserDataGread>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataLibrary>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataPortfolio>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataTreasury>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataVendor>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserDataWarehouse>(entity =>
        {
            entity.Property(e => e.Admin).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecUserInvItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserInvOrg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserInvWarehouse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserLogen>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LogType).IsFixedLength();
        });

        modelBuilder.Entity<SecUserModule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserPosrBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserPosrCust>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserPosrShift>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserPurBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserPurTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserPurVendor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserSalBranch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserSalCust>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserSalTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Admin).IsFixedLength();
        });

        modelBuilder.Entity<SecUserWin>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecWinNew>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SecWindow>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Sec_window_1")
                .IsClustered(false);

            entity.HasIndex(e => e.Id, "pk_sec_window")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcBomD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcBomH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sfc_Bom_h");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcFacility>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sfc_Facility");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sfc_Method");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcProcess>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcRouting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sfc_Routing");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcTransBom>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcTransMatrix>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcTransRouting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SfcWorkcenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sfc_Workcenter");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShfExpier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_shf_export");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShfExpierCaptal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_shf_export_captal");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShfExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_shf_expier");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShfExportCaptal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_shf_expier_captal");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShfReport>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpCustGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_cust_group");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_customer");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_discount");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpEmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_emp");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpExpItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_exp_item");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_group");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpMarka>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_marka");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpRent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_rent");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_service");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpShip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_ships");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTcontract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_tcontract");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTcontractService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_c_shp_tcontract_service");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTexpensess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_texpensess");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_ticket");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTpayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_tpayment");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTreasury>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_c_shp_treasury");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpTwaiting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgBosale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_bosale");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgDeleteRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_delete_request");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgInspection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_inspection");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgRegistWatercraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_regist_watercraft");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgRequestCertificate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_request_certificate");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgRequestProof>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_request_proof");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ShpgRequestProofNon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hspg_request_proof_non");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblMidDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TBL_Mid_Data");

            entity.Property(e => e.Posted).HasDefaultValueSql("((0))");
            entity.Property(e => e.YearId).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMidPo>(entity =>
        {
            entity.Property(e => e.Posted).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<TshEmp>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TshEmpTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TshTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TshTask1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TshTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TshWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TskTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TskTaskType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TtbBranchGrade>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TtbTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VCiepCourseLevel>(entity =>
        {
            entity.ToView("v_ciep_course_level");
        });

        modelBuilder.Entity<VDddwInvTransTransferAllocatPosr>(entity =>
        {
            entity.ToView("v_dddw_inv_trans_transfer_allocat_posr");
        });

        modelBuilder.Entity<VExmCourse>(entity =>
        {
            entity.ToView("v_exm_course");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VInvTransD>(entity =>
        {
            entity.ToView("v_inv_trans_d");
        });

        modelBuilder.Entity<WcnConTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnContType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnExpD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnExpDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnExpH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnExpensesItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnPayD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnPayDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnPayH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnTransHDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnTransInst>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnTransTerm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WcnTreasury>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WflTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WflTaskD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WflTaskH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WflTransD>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.EmpId).IsFixedLength();
        });

        modelBuilder.Entity<WflTransDDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WflTransH>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WflTransHDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WtsAction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WtsMonth>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WtsTran>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WtsTransDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WtsWeek>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WtsYear>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
