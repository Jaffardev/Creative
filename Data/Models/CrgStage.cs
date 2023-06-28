using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_stage")]
public partial class CrgStage
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("shipment_id", TypeName = "decimal(18, 0)")]
    public decimal? ShipmentId { get; set; }

    [Column("dispatch_id", TypeName = "decimal(18, 0)")]
    public decimal? DispatchId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("doc_rcv_date", TypeName = "datetime")]
    public DateTime? DocRcvDate { get; set; }

    [Column("cargo_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CargoType { get; set; }

    [Column("cargo_country")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CargoCountry { get; set; }

    [Column("invoice_amount", TypeName = "decimal(18, 3)")]
    public decimal? InvoiceAmount { get; set; }

    [Column("currancy_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrancyId { get; set; }

    [Column("change_rate", TypeName = "decimal(18, 3)")]
    public decimal? ChangeRate { get; set; }

    [Column("coo_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CooStatus { get; set; }

    [Column("height", TypeName = "decimal(18, 0)")]
    public decimal? Height { get; set; }

    [Column("width", TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column("length", TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column("load_date", TypeName = "datetime")]
    public DateTime? LoadDate { get; set; }

    [Column("get_pass_date", TypeName = "datetime")]
    public DateTime? GetPassDate { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("vessel_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VesselName { get; set; }

    [Column("vessel_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? VesselType { get; set; }

    [Column("load_port_id", TypeName = "decimal(18, 0)")]
    public decimal? LoadPortId { get; set; }

    [Column("discharge_port_id", TypeName = "decimal(18, 0)")]
    public decimal? DischargePortId { get; set; }

    [Column("leave_date", TypeName = "datetime")]
    public DateTime? LeaveDate { get; set; }

    [Column("arrive_date", TypeName = "datetime")]
    public DateTime? ArriveDate { get; set; }

    [Column("rcv_inv_date", TypeName = "datetime")]
    public DateTime? RcvInvDate { get; set; }

    [Column("rcv_bill_date", TypeName = "datetime")]
    public DateTime? RcvBillDate { get; set; }

    [Column("rcv_doc_date", TypeName = "datetime")]
    public DateTime? RcvDocDate { get; set; }

    [Column("clearance_start_date", TypeName = "datetime")]
    public DateTime? ClearanceStartDate { get; set; }

    [Column("clearance_end_date", TypeName = "datetime")]
    public DateTime? ClearanceEndDate { get; set; }

    [Column("trucks_no", TypeName = "decimal(18, 3)")]
    public decimal? TrucksNo { get; set; }

    [Column("trucks_description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? TrucksDescription { get; set; }

    [Column("notify_party")]
    [StringLength(100)]
    [Unicode(false)]
    public string? NotifyParty { get; set; }

    [Column("booking_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BookingNo { get; set; }

    [Column("import_doc_start_date", TypeName = "datetime")]
    public DateTime? ImportDocStartDate { get; set; }

    [Column("import_doc_end_date", TypeName = "datetime")]
    public DateTime? ImportDocEndDate { get; set; }

    [Column("rcv_coo_date", TypeName = "datetime")]
    public DateTime? RcvCooDate { get; set; }

    [Column("soc_start_date", TypeName = "datetime")]
    public DateTime? SocStartDate { get; set; }

    [Column("soc_end_date", TypeName = "datetime")]
    public DateTime? SocEndDate { get; set; }

    [Column("dox_rcv_date", TypeName = "datetime")]
    public DateTime? DoxRcvDate { get; set; }

    [Column("shipment_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ShipmentStatus { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("shipment_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ShipmentNo { get; set; }

    [Column("bill_lading")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BillLading { get; set; }

    [Column("bill_lading_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? BillLadingNote { get; set; }

    [Column("bill_lading_date", TypeName = "datetime")]
    public DateTime? BillLadingDate { get; set; }

    [Column("comr_invo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ComrInvo { get; set; }

    [Column("comr_invo_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ComrInvoNote { get; set; }

    [Column("comr_invo_date", TypeName = "datetime")]
    public DateTime? ComrInvoDate { get; set; }

    [Column("pack_list")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PackList { get; set; }

    [Column("pack_list_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PackListNote { get; set; }

    [Column("pack_list_date", TypeName = "datetime")]
    public DateTime? PackListDate { get; set; }

    [Column("cert_org")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CertOrg { get; set; }

    [Column("cert_org_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CertOrgNote { get; set; }

    [Column("cert_org_date", TypeName = "datetime")]
    public DateTime? CertOrgDate { get; set; }

    [Column("cert_conf")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CertConf { get; set; }

    [Column("cert_conf_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CertConfNote { get; set; }

    [Column("cert_conf_date", TypeName = "datetime")]
    public DateTime? CertConfDate { get; set; }

    [Column("deliv_order")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DelivOrder { get; set; }

    [Column("deliv_order_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? DelivOrderNote { get; set; }

    [Column("deliv_order_date", TypeName = "datetime")]
    public DateTime? DelivOrderDate { get; set; }

    [Column("wtdo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Wtdo { get; set; }

    [Column("wtdo_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? WtdoNote { get; set; }

    [Column("wtdo_date", TypeName = "datetime")]
    public DateTime? WtdoDate { get; set; }

    [Column("auth_letter")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AuthLetter { get; set; }

    [Column("auth_letter_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? AuthLetterNote { get; set; }

    [Column("auth_letter_date", TypeName = "datetime")]
    public DateTime? AuthLetterDate { get; set; }

    [Column("under_letter")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UnderLetter { get; set; }

    [Column("under_letter_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? UnderLetterNote { get; set; }

    [Column("under_letter_date", TypeName = "datetime")]
    public DateTime? UnderLetterDate { get; set; }

    [Column("declaration")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Declaration { get; set; }

    [Column("declaration_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? DeclarationNote { get; set; }

    [Column("declaration_date", TypeName = "datetime")]
    public DateTime? DeclarationDate { get; set; }

    [Column("appr_levy")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ApprLevy { get; set; }

    [Column("appr_levy_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ApprLevyNote { get; set; }

    [Column("appr_levy_date", TypeName = "datetime")]
    public DateTime? ApprLevyDate { get; set; }

    [Column("import_license")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ImportLicense { get; set; }

    [Column("import_license_note")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ImportLicenseNote { get; set; }

    [Column("import_license_date", TypeName = "datetime")]
    public DateTime? ImportLicenseDate { get; set; }
}
