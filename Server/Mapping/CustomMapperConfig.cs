using Creative.Data.Models;
using Creative.Shared.Models;
using Mapster;

public static class CustomMapperConfig
{
    public static void RegisterMapsterConfiguration(this IServiceCollection services)
    {


        TypeAdapterConfig<AcpStudent, AdmissionModel>
            .NewConfig()
            .Map(dest => dest.AcpDirect, src => src.AcpDirect == "1")
            .Map(dest => dest.AcpApprove, src => src.AcpApprove == "1")
            .Map(dest => dest.AcpRecommend, src => src.AcpRecommend == "1")
            .Map(dest => dest.AcpTransferCertificate, src => src.AcpTransferCertificate == "1")
            .Map(dest => dest.BrotherAcp, src => src.BrotherAcp == "1")
            .Map(dest => dest.AcpEquivalencyCertificate, src => src.AcpEquivalencyCertificate == "1")
            .Map(dest => dest.BrotherReg, src => src.BrotherReg == "1")
            .Map(dest => dest.AcpClearance, src => src.AcpClearance == "1")
            .Map(dest => dest.AcpHealthFile, src => src.AcpHealthFile == "1")
            .Map(dest => dest.HealthStatus, src => src.HealthStatus == "1")
            .Map(dest => dest.Accepted, src => src.Accepted)
            .Map(dest => dest.AcceptPrepaid, src => src.AcceptPrepaid == "1")
            .Map(dest => dest.AcceptFees, src => src.AcceptFees == "1")
            .Map(dest => dest.AcceptDebt, src => src.AcceptDebt == "1")
            .Map(dest => dest.Result, src => Convert.ToInt32(src.StuResult ?? "0"))
            .Map(dest => dest.StudentType, src => Convert.ToInt32(src.StuType ?? "0"))
            .Map(dest => dest.CurGradeId, src => Convert.ToInt32(src.CurGreadId ?? 0))
            .Map(dest => dest.IdNumber, src => src.IdNo)
            .Map(dest => dest.StuPayBy, src => src.StuPayBy)
            .Map(dest => dest.ResEmp, src => src.ResEmp == "1");


        TypeAdapterConfig<AdmissionModel, AcpStudent>
           .NewConfig()
           .Map(dest => dest.AcpDirect, src => src.AcpDirect ? "1" : "0")
           .Map(dest => dest.AcpApprove, src => src.AcpApprove ? "1" : "0")
           .Map(dest => dest.AcpRecommend, src => src.AcpRecommend ? "1" : "0")
           .Map(dest => dest.AcpTransferCertificate, src => src.AcpTransferCertificate ? "1" : "0")
           .Map(dest => dest.BrotherAcp, src => src.BrotherAcp ? "1" : "0")
           .Map(dest => dest.AcpEquivalencyCertificate, src => src.AcpEquivalencyCertificate ? "1" : "0")
           .Map(dest => dest.BrotherReg, src => src.BrotherReg ? "1" : "0")
           .Map(dest => dest.AcpClearance, src => src.AcpClearance ? "1" : "0")
           .Map(dest => dest.AcpHealthFile, src => src.AcpHealthFile ? "1" : "0")
           .Map(dest => dest.HealthStatus, src => src.HealthStatus ? "1" : "0")
           .Map(dest => dest.Accepted, src => src.Accepted)
           .Map(dest => dest.AcceptPrepaid, src => (src.AcceptPrepaid ?? false) ? "1" : "0")
           .Map(dest => dest.AcceptFees, src => (src.AcceptFees ?? false) ? "1" : "0")
           .Map(dest => dest.AcceptDebt, src => (src.AcceptDebt ?? false) ? "1" : "0")
           .Map(dest => dest.StuResult, src => src.Result)
           .Map(dest => dest.StuType, src => src.StudentType)
           .Map(dest => dest.CurGreadId, src => src.CurGradeId)
           .Map(dest => dest.IdNo, src => src.IdNumber)
           .Map(dest => dest.StuPayBy, src => src.StuPayBy)
           .Map(dest => dest.Name1, src => $"{src.Name11} {src.Name12} {src.Name13} {src.Name14} {src.Name15}")
           .Map(dest => dest.Name2, src => $"{src.Name21} {src.Name22} {src.Name23} {src.Name24} {src.Name25}")
           .Map(dest => dest.ResEmp, src => src.ResEmp ? "1" : "0");
    }
}