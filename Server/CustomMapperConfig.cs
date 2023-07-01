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
            .Map(dest => dest.ResEmp, src => src.ResEmp == "1").TwoWays();

        // TypeAdapterConfig<AdmissionModel, AcpStudent>
        //            .NewConfig()
        //            .Map(dest => dest.AcpDirect, src => src.AcpDirect ? "1" : "0")
        //            .Map(dest => dest.AcpApprove, src => src.AcpApprove ? "1" : "0")
        //            .Map(dest => dest.AcpRecommend, src => src.AcpRecommend ? "1" : "0")
        //            .Map(dest => dest.AcpTransferCertificate, src => src.AcpTransferCertificate ? "1" : "0")
        //            .Map(dest => dest.BrotherAcp, src => src.BrotherAcp ? "1" : "0")
        //            .Map(dest => dest.AcpEquivalencyCertificate, src => src.AcpEquivalencyCertificate ? "1" : "0")
        //            .Map(dest => dest.BrotherReg, src => src.BrotherReg ? "1" : "0")
        //            .Map(dest => dest.AcpClearance, src => src.AcpClearance ? "1" : "0")
        //            .Map(dest => dest.AcpHealthFile, src => src.AcpHealthFile ? "1" : "0")
        //            .Map(dest => dest.HealthStatus, src => src.HealthStatus ? "1" : "0")
        //            .Map(dest => dest.ResEmp, src => src.ResEmp ? "1" : "0");

    }
}