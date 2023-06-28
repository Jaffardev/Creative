using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("Gen_sys_parm")]
public partial class GenSysParm
{
    [Key]
    [Column("ID", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("Company_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [Column("Manger_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MangerName { get; set; }

    [Column("Address_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("Address_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("address_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [Column("Tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("Tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("Tel_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("titel_a_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA1 { get; set; }

    [Column("titel_a_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA2 { get; set; }

    [Column("titel_a_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA3 { get; set; }

    [Column("titel_a_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA4 { get; set; }

    [Column("titel_a_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA5 { get; set; }

    [Column("titel_a_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA6 { get; set; }

    [Column("titel_e_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE1 { get; set; }

    [Column("titel_e_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE2 { get; set; }

    [Column("titel_e_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE3 { get; set; }

    [Column("titel_e_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE4 { get; set; }

    [Column("titel_e_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE5 { get; set; }

    [Column("titel_e_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE6 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Logo { get; set; }

    [Column("win_master_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WinMaster2 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("c_byn_result_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBynResult1 { get; set; }

    [Column("c_byn_result_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBynResult2 { get; set; }

    [Column("c_byn_result_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBynResult3 { get; set; }

    [Column("c_byn_result_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBynResult4 { get; set; }

    [Column("c_byn_result_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBynResult5 { get; set; }

    [Column("acc_level_1", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel1 { get; set; }

    [Column("acc_level_2", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel2 { get; set; }

    [Column("acc_level_3", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel3 { get; set; }

    [Column("acc_level_4", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel4 { get; set; }

    [Column("acc_level_5", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel5 { get; set; }

    [Column("acc_level_6", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel6 { get; set; }

    [Column("acc_level_7", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel7 { get; set; }

    [Column("acc_level_8", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel8 { get; set; }

    [Column("acc_level_9", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel9 { get; set; }

    [Column("acc_level_10", TypeName = "decimal(18, 0)")]
    public decimal? AccLevel10 { get; set; }

    [Column("cost_level_1", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel1 { get; set; }

    [Column("cost_level_2", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel2 { get; set; }

    [Column("cost_level_3", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel3 { get; set; }

    [Column("cost_level_4", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel4 { get; set; }

    [Column("cost_level_5", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel5 { get; set; }

    [Column("cost_level_6", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel6 { get; set; }

    [Column("cost_level_7", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel7 { get; set; }

    [Column("cost_level_8", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel8 { get; set; }

    [Column("cost_level_9", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel9 { get; set; }

    [Column("cost_level_10", TypeName = "decimal(18, 0)")]
    public decimal? CostLevel10 { get; set; }

    [Column("exp_level_1", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel1 { get; set; }

    [Column("exp_level_2", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel2 { get; set; }

    [Column("exp_level_3", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel3 { get; set; }

    [Column("exp_level_4", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel4 { get; set; }

    [Column("exp_level_5", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel5 { get; set; }

    [Column("exp_level_6", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel6 { get; set; }

    [Column("exp_level_7", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel7 { get; set; }

    [Column("exp_level_8", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel8 { get; set; }

    [Column("exp_level_9", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel9 { get; set; }

    [Column("exp_level_10", TypeName = "decimal(18, 0)")]
    public decimal? ExpLevel10 { get; set; }

    [Column("analysis_level_1", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel1 { get; set; }

    [Column("analysis_level_2", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel2 { get; set; }

    [Column("analysis_level_3", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel3 { get; set; }

    [Column("analysis_level_4", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel4 { get; set; }

    [Column("analysis_level_5", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel5 { get; set; }

    [Column("analysis_level_6", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel6 { get; set; }

    [Column("analysis_level_7", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel7 { get; set; }

    [Column("analysis_level_8", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel8 { get; set; }

    [Column("analysis_level_9", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel9 { get; set; }

    [Column("analysis_level_10", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisLevel10 { get; set; }

    [Column("stu_exp_blok")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuExpBlok { get; set; }

    [Column("exp_one_serial")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpOneSerial { get; set; }

    [Column("Spatial_print")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SpatialPrint { get; set; }

    [Column("acc_profit_loss_id", TypeName = "decimal(18, 0)")]
    public decimal? AccProfitLossId { get; set; }

    [Column("acc_activity_id", TypeName = "decimal(18, 0)")]
    public decimal? AccActivityId { get; set; }

    [Column("acc_link")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccLink { get; set; }

    [Column("cust_credit_limit")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CustCreditLimit { get; set; }

    [Column("cust_credit_day")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CustCreditDay { get; set; }

    [Column("sal_issue_zero")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalIssueZero { get; set; }

    [Column("inv_issue_zero")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvIssueZero { get; set; }

    [Column("post_inv_journal_id", TypeName = "decimal(18, 0)")]
    public decimal? PostInvJournalId { get; set; }

    [Column("post_pur_journal_id", TypeName = "decimal(18, 0)")]
    public decimal? PostPurJournalId { get; set; }

    [Column("post_sal_journal_id", TypeName = "decimal(18, 0)")]
    public decimal? PostSalJournalId { get; set; }

    [Column("post_rcon_journal_id", TypeName = "decimal(18, 0)")]
    public decimal? PostRconJournalId { get; set; }

    [Column("post_rpay_journal_id", TypeName = "decimal(18, 0)")]
    public decimal? PostRpayJournalId { get; set; }

    [Column("exp_check_block")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpCheckBlock { get; set; }

    [Column("print_datetime")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintDatetime { get; set; }

    [Column("sal_one_serial")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalOneSerial { get; set; }

    [Column("financial_start_date", TypeName = "datetime")]
    public DateTime? FinancialStartDate { get; set; }

    [Column("financial_end_date", TypeName = "datetime")]
    public DateTime? FinancialEndDate { get; set; }

    [Column("exp_auto_load")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpAutoLoad { get; set; }

    [Column("exp_more_disc")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpMoreDisc { get; set; }

    [Column("overtime")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Overtime { get; set; }

    [Column("currency_name_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CurrencyNameNo { get; set; }

    [Column("currency_name_dec")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CurrencyNameDec { get; set; }

    [Column("currency_name_no_e")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CurrencyNameNoE { get; set; }

    [Column("currency_name_dec_e")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CurrencyNameDecE { get; set; }

    [Column("disc_auto_load")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DiscAutoLoad { get; set; }

    [Column("post_sal_pay_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PostSalPayJurId { get; set; }

    [Column("post_sal_exp_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PostSalExpJurId { get; set; }

    [Column("post_pur_pay_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PostPurPayJurId { get; set; }

    [Column("post_pur_exp_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PostPurExpJurId { get; set; }

    [Column("pos_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PosJurId { get; set; }

    [Column("pos_acc_salse", TypeName = "decimal(18, 0)")]
    public decimal? PosAccSalse { get; set; }

    [Column("pos_acc_cash", TypeName = "decimal(18, 0)")]
    public decimal? PosAccCash { get; set; }

    [Column("pos_acc_key", TypeName = "decimal(18, 0)")]
    public decimal? PosAccKey { get; set; }

    [Column("pos_acc_visa", TypeName = "decimal(18, 0)")]
    public decimal? PosAccVisa { get; set; }

    [Column("pos_acc_master", TypeName = "decimal(18, 0)")]
    public decimal? PosAccMaster { get; set; }

    [Column("pos_acc_atm", TypeName = "decimal(18, 0)")]
    public decimal? PosAccAtm { get; set; }

    [Column("pos_acc_other", TypeName = "decimal(18, 0)")]
    public decimal? PosAccOther { get; set; }

    [Column("pos_acc_discount", TypeName = "decimal(18, 0)")]
    public decimal? PosAccDiscount { get; set; }

    [Column("pos_acc_Commission", TypeName = "decimal(18, 0)")]
    public decimal? PosAccCommission { get; set; }

    [Column("acc_cumulative_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCumulativeId { get; set; }

    [Column("Inv_cost_display")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvCostDisplay { get; set; }

    [Column("cur_date", TypeName = "datetime")]
    public DateTime? CurDate { get; set; }

    [Column("exp_acc_db_from")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpAccDbFrom { get; set; }

    [Column("exp_post_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpPostType { get; set; }

    [Column("preview_print")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PreviewPrint { get; set; }

    [Column("cheque_book")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ChequeBook { get; set; }

    [Column("comp_share", TypeName = "decimal(18, 5)")]
    public decimal? CompShare { get; set; }

    [Column("emp_share", TypeName = "decimal(18, 5)")]
    public decimal? EmpShare { get; set; }

    [Column("max_limit_indemnity", TypeName = "decimal(18, 3)")]
    public decimal? MaxLimitIndemnity { get; set; }

    [Column("item_barcode")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemBarcode { get; set; }

    [Column("acc_cost_disp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccCostDisp { get; set; }

    [Column("acc_exp_disp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccExpDisp { get; set; }

    [Column("acc_analysis_disp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccAnalysisDisp { get; set; }

    [Column("post_exp_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PostExpJurId { get; set; }

    [Column("post_exp_pay_jur_id", TypeName = "decimal(18, 0)")]
    public decimal? PostExpPayJurId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("acc_prepay_id", TypeName = "decimal(18, 0)")]
    public decimal? AccPrepayId { get; set; }

    [Column("acc_debit_id", TypeName = "decimal(18, 0)")]
    public decimal? AccDebitId { get; set; }

    [Column("sal_invo_whs")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalInvoWhs { get; set; }

    [Column("dddw_retrieve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DddwRetrieve { get; set; }

    [Column("post_ast_journal_id", TypeName = "decimal(18, 0)")]
    public decimal? PostAstJournalId { get; set; }

    [Column("sec_data")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecData { get; set; }

    [Column("reg_exp_link")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RegExpLink { get; set; }

    [Column("pos_key_Commission", TypeName = "decimal(18, 5)")]
    public decimal? PosKeyCommission { get; set; }

    [Column("pos_visa_Commission", TypeName = "decimal(18, 5)")]
    public decimal? PosVisaCommission { get; set; }

    [Column("pos_master_Commission", TypeName = "decimal(18, 5)")]
    public decimal? PosMasterCommission { get; set; }

    [Column("pos_atm_Commission", TypeName = "decimal(18, 5)")]
    public decimal? PosAtmCommission { get; set; }

    [Column("pos_other_Commission", TypeName = "decimal(18, 5)")]
    public decimal? PosOtherCommission { get; set; }

    [Column("pos_acc_Commission_db", TypeName = "decimal(18, 0)")]
    public decimal? PosAccCommissionDb { get; set; }

    [Column("pos_acc_Commission_cr", TypeName = "decimal(18, 0)")]
    public decimal? PosAccCommissionCr { get; set; }

    [Column("acc_multi_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccMultiCode { get; set; }

    [Column("pur_one_serial")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PurOneSerial { get; set; }

    [Column("acc_id_book", TypeName = "decimal(18, 0)")]
    public decimal? AccIdBook { get; set; }

    [Column("acc_id_open", TypeName = "decimal(18, 0)")]
    public decimal? AccIdOpen { get; set; }

    [Column("acc_id_bus", TypeName = "decimal(18, 0)")]
    public decimal? AccIdBus { get; set; }

    [Column("acc_id_uniform", TypeName = "decimal(18, 0)")]
    public decimal? AccIdUniform { get; set; }

    [Column("tax_activation")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TaxActivation { get; set; }

    [Column("transcript_gread_1", TypeName = "decimal(18, 0)")]
    public decimal? TranscriptGread1 { get; set; }

    [Column("transcript_gread_2", TypeName = "decimal(18, 0)")]
    public decimal? TranscriptGread2 { get; set; }

    [Column("transcript_gread_3", TypeName = "decimal(18, 0)")]
    public decimal? TranscriptGread3 { get; set; }

    [Column("transcript_gread_4", TypeName = "decimal(18, 0)")]
    public decimal? TranscriptGread4 { get; set; }

    [Column("inv_for_whs_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvForWhsItem { get; set; }

    [Column("pur_doubl_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PurDoublItem { get; set; }

    [Column("pos_return_no", TypeName = "decimal(18, 0)")]
    public decimal? PosReturnNo { get; set; }

    [Column("inv_auto_display")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvAutoDisplay { get; set; }

    [Column("epay_treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? EpayTreasuryId { get; set; }

    [Column("exp_lode_all_stu")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpLodeAllStu { get; set; }

    [Column("sal_item_price")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalItemPrice { get; set; }

    [Column("sec_acc_account")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecAccAccount { get; set; }

    [Column("sec_acc_cost")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecAccCost { get; set; }

    [Column("sec_acc_exp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecAccExp { get; set; }

    [Column("sec_acc_analysis")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecAccAnalysis { get; set; }

    [Column("sec_acc_journal")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecAccJournal { get; set; }

    [Column("sec_pur_branch")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecPurBranch { get; set; }

    [Column("sec_pur_vendor")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecPurVendor { get; set; }

    [Column("sec_pur_treasury")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecPurTreasury { get; set; }

    [Column("sec_sal_branch")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecSalBranch { get; set; }

    [Column("sec_sal_customer")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecSalCustomer { get; set; }

    [Column("sec_sal_treasury")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecSalTreasury { get; set; }

    [Column("sec_inv_items")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecInvItems { get; set; }

    [Column("sec_inv_warehouse")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecInvWarehouse { get; set; }

    [Column("sec_inv_org")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecInvOrg { get; set; }

    [Column("sec_posr_customer")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecPosrCustomer { get; set; }

    [Column("sec_posr_branch")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecPosrBranch { get; set; }

    [Column("sec_posr_shift")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecPosrShift { get; set; }
}
