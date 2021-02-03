using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Stripe;

namespace Infrastructure.Services
{
 public class PaymentService : IPaymentService
 {
  private readonly IBasketRepository _basketRepository;
  private readonly IUnitOfWork _unitOfWork;
  private readonly IConfiguration _config;
  public PaymentService(IBasketRepository basketRepository, IUnitOfWork unitOfWork, IConfiguration config)
  {
   _config = config;
   _unitOfWork = unitOfWork;
   _basketRepository = basketRepository;

  }
  public Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId)
  {
      StripeConfiguration.ApiKey = _config["StripeSettings:SecretKey"];
  }
 }
}