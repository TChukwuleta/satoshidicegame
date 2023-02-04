﻿using MediatR;
using SatoshiDice.Application.Common.Interfaces;
using SatoshiDice.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatoshiDice.Application.TestEndpoints.LightningCommands
{
    public class PayInvoiceCommand : IRequest<Result>
    {
        public string PaymentRequest { get; set; }
    }

    public class PayInvoiceCommandHandler : IRequestHandler<PayInvoiceCommand, Result>
    {
        private readonly ILightningClient _lightningClient;
        public PayInvoiceCommandHandler(ILightningClient lightningClient)
        {
            _lightningClient = lightningClient;
        }

        public async Task<Result> Handle(PayInvoiceCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _lightningClient.SendLightning(request.PaymentRequest);
                return Result.Success("Invoice paid successfully");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
