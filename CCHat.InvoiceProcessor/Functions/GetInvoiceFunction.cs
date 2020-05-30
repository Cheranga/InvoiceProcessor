using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace CCHat.InvoiceProcessor.Functions
{
    public class GetInvoiceFunction
    {
        private readonly ILogger<GetInvoiceFunction> _logger;

        public GetInvoiceFunction(ILogger<GetInvoiceFunction> logger)
        {
            _logger = logger;
        }

        [FunctionName(nameof(GetInvoiceFunction))]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "invoices/{invoiceId}")]
            HttpRequest request,
            string invoiceId)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            return new OkObjectResult(invoiceId);
        }
    }
}
