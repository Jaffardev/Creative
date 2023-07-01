using Mapster;
using Creative.Shared.Models;
using Creative.Data.Models;

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
            .Map(dest => dest.ResEmp, src => src.ResEmp == "1").TwoWays();
    }
}