using Business.Abstract;
using Business.Abstract.Items;
using Business.Concrete;
using Business.Concrete.Items;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<EmployeeFamilyManager>().As<IEmployeeFamilyService>().SingleInstance();
            builder.RegisterType<EfEmployeeFamilyDal>().As<IEmployeeFamilyDal>().SingleInstance();


            builder.RegisterType<EmployeeEducationManager>().As<IEmployeeEducationService>().SingleInstance();
            builder.RegisterType<EfEmployeeEducationDal>().As<IEmployeeEducationDal>().SingleInstance();


            builder.RegisterType<EmployeeLanguageManager>().As<IEmployeeLanguageService>().SingleInstance();
            builder.RegisterType<EfEmployeeLanguageDal>().As<IEmployeeLanguageDal>().SingleInstance();

            builder.RegisterType<EmployeeDebitManager>().As<IEmployeeDebitService>().SingleInstance();
            builder.RegisterType<EfEmployeeDebitDal>().As<IEmployeeDebitDal>().SingleInstance();


            builder.RegisterType<EmployeeVacationManager>().As<IEmployeeVacationService>().SingleInstance();
            builder.RegisterType<EfEmployeeVacationDal>().As<IEmployeeVacationDal>().SingleInstance();


            builder.RegisterType<EmployeeComputerInformationManager>().As<IEmployeeComputerInformationService>().SingleInstance();
            builder.RegisterType<EfEmployeeComputerInformationDal>().As<IEmployeeComputerInformationDal>().SingleInstance();


            builder.RegisterType<EmployeeEmergencyInformationManager>().As<IEmployeeEmergencyInformationService>().SingleInstance();
            builder.RegisterType<EfEmployeeEmergencyInformationDal>().As<IEmployeeEmergencyInformationDal>().SingleInstance();

            builder.RegisterType<EmployeeContactInformationManager>().As<IEmployeeContactInformationService>().SingleInstance();
            builder.RegisterType<EfEmployeeContactInformationDal>().As<IEmployeeContactInformationDal>().SingleInstance();

            builder.RegisterType<EmployeePastWorkExperienceManager>().As<IEmployeePastWorkExperienceService>().SingleInstance();
            builder.RegisterType<EfEmployeePastWorkExperienceDal>().As<IEmployeePastWorkExperienceDal>().SingleInstance();


            builder.RegisterType<EmployeeAwardInformationManager>().As<IEmployeeAwardInformationService>().SingleInstance();
            builder.RegisterType<EfEmployeeAwardInformationDal>().As<IEmployeeAwardInformationDal>().SingleInstance();

            builder.RegisterType<AllowanceTypeManager>().As<IAllowanceTypeService>().SingleInstance();
            builder.RegisterType<EfAllowanceTypeDal>().As<IAllowanceTypeDal>().SingleInstance();


            builder.RegisterType<DebitTypeManager>().As<IDebitTypeService>().SingleInstance();
            builder.RegisterType<EfDebitTypeDal>().As<IDebitTypeDal>().SingleInstance();


            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<CountyManager>().As<ICountyService>().SingleInstance();
            builder.RegisterType<EfCountyDal>().As<ICountyDal>().SingleInstance();

            builder.RegisterType<EducationaLevelManager>().As<IEducationaLevelService>().SingleInstance();
            builder.RegisterType<EfEducationaLevelDal>().As<IEducationaLevelDal>().SingleInstance();


            builder.RegisterType<FamilyMemberManager>().As<IFamilyMemberService>().SingleInstance();
            builder.RegisterType<EfFamilyMemberDal>().As<IFamilyMemberDal>().SingleInstance();


            builder.RegisterType<LanguageManager>().As<ILanguageService>().SingleInstance();
            builder.RegisterType<EfLanguageDal>().As<ILanguageDal>().SingleInstance();


            builder.RegisterType<NationalityManager>().As<INationalityService>().SingleInstance();
            builder.RegisterType<EfNationalityDal>().As<INationalityDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
