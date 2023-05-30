using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly Checkout checkout;

        public CheckoutController()
        {
            checkout = new Checkout();
        }

        [HttpGet]
        public IActionResult CalculateTotalCost(string skus)
        {
            try
            {
                int totalPrice = checkout.CalculateTotalCost(skus);
                return Ok(new { TotalPrice = totalPrice });
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
