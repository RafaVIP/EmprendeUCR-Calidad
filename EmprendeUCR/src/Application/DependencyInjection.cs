using EmprendeUCR.Application.PaymentMethods;
using EmprendeUCR.Application.PaymentMethods.Implementations;
using EmprendeUCR.Application.PaymentInfos;
using EmprendeUCR.Application.PaymentInfos.Implementations;
using Microsoft.Extensions.DependencyInjection;
using EmprendeUCR.Application.LoginContext;
using EmprendeUCR.Application.LoginContext.Implementations;
using EmprendeUCR.Application.Entrepreneurs;
using EmprendeUCR.Application.Entrepreneurs.Implementations;

namespace EmprendeUCR.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<ISinpeMovilPaymentMethodService, SinpeMovilPaymentMethodService>();
            services.AddTransient<ISinpeIbanPaymentMethodService, SinpeIbanPaymentMethodService>();
            services.AddTransient<ICardPaymentMethodService, CardPaymentMethodService>();
            services.AddTransient<IHasPaymentInfoService , HasPaymentInfoService>();
            services.AddTransient<ISinpeMovilPaymentInfoService, SinpeMovilPaymentInfoService>();
            services.AddTransient<ISinpeIbanPaymentInfoService, SinpeIbanPaymentInfoService>();
            services.AddTransient<ICardPaymentInfoService, CardPaymentInfoService>();
            services.AddTransient<IPaymentInfoService, PaymentInfoService>();
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductServiceService, ProductServiceService>();
            return services;
        }
    }
}