using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Creative.Shared.Models;

public class ParentRegistrationModel
{
    [Required]
    public decimal Id { get; set; }

    [Required]
    public string? Code { get; set; }
    public string? Name11 { get; set; }
    public string? Name12 { get; set; }
    public string? Name13 { get; set; }
    public string? Name14 { get; set; }
    public string? Name21 { get; set; }
    public string? Name22 { get; set; }
    public string? Name23 { get; set; }
    public string? Name24 { get; set; }

    public string? Name2 { get; set; }
    public string? Name1 { get; set; }
    public string? Notes { get; set; }

    #region Communication
    [Required]
    public string? Tel1 { get; set; }
    public string? Tel2 { get; set; }
    public string? EmergencyTel { get; set; }
    public int? GovermentId { get; set; }

    public int AreaId { get; set; }

    public int PartId { get; set; }

    public string? HomeAddress { get; set; }

    public string? WorkAddress { get; set; }

    public string? Email { get; set; }
    public string? FinancialNotes { get; set; }


    #endregion

    #region Data

    /// <summary>
    /// national_id
    /// </summary>
    public decimal? NationalId { get; set; }
    public decimal? JobId { get; set; }

    public int? IdTypeId { get; set; }

    [Required]
    public string? IdNo { get; set; }

    [Required]
    public DateTime? IdEndDate { get; set; }
    [Required]
    public DateTime? BirthDate { get; set; }


    public int? ResedenceNo { get; set; }
    public DateTime? ResedenceEndDate { get; set; }

    public int? PassportType { get; set; }
    public string? PassportNumber { get; set; }


    /// <summary>
    /// passport_date
    /// </summary>
    public DateTime? PassportIssuanceDate { get; set; }
    public DateTime? PassportEndDate { get; set; }

    #region Account
    /// <summary>
    /// acc_id
    /// </summary>
    public int? AccountId { get; set; }

    /// <summary>
    /// acc_analyst_id
    /// </summary>
    public int? AnalystAccount { get; set; }

    /// <summary>
    /// //acc_prepay_id
    /// </summary>
    public int? AdvanceAccount { get; set; }

    /// <summary>
    /// //acc_cost_id
    /// </summary>
    public int? CostCenterAccount { get; set; }

    /// <summary>
    /// //acc_debit_id
    /// </summary>
    public int? OldDebitAccount { get; set; }

    /// <summary>
    /// acc_exp_id
    /// </summary>
    public int? ExpensisAccount { get; set; }

    /// <summary>
    /// //acc_id_book
    /// </summary>
    public int? BookAccount { get; set; }

    /// <summary>
    /// acc_id_bus
    /// </summary>
    public int? BusAccount { get; set; }


    /// <summary>
    /// acc_id_uniform
    /// </summary>
    public int? UniformAccount { get; set; }








    #endregion Account

    #endregion Daa

    [Required]
    public string? Address1 { get; set; }

    public IEnumerable<StudentModel>? Students { get; set; }

    [JsonIgnore]
    public bool Modified { get; set; }

    public bool IsChanged(string? code)
    {
        return this.Code != code || Modified;
    }

}

 


