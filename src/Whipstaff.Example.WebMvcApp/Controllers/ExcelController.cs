﻿// Copyright (c) 2019 DHGMS Solutions and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Dhgms.AspNetCoreContrib.Abstractions;
using Dhgms.AspNetCoreContrib.App.Features.Excel;
using Dhgms.AspNetCoreContrib.App.Features.FileTransfer;
using Dhgms.AspNetCoreContrib.App.Features.MediaTypeHeaders;
using Dhgms.AspNetCoreContrib.Controllers;
using Dhgms.AspNetCoreContrib.Controllers.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace Dhgms.AspNetCoreContrib.Example.WebSite.Controllers
{
    /// <summary>
    /// Sample web controller for an XLSX download.
    /// </summary>
    public sealed class ExcelController : BaseFileDownloadController<int, DownloadSpreadsheetRequestDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelController"/> class.
        /// </summary>
        /// <param name="authorizationService">Instance of the authorization service for use in requests.</param>
        /// <param name="logger">Instance of logging framework.</param>
        /// <param name="mediator">Instance of the CQRS mediator.</param>
        public ExcelController(
            IAuthorizationService authorizationService,
            ILogger<ExcelController> logger,
            IMediator mediator)
            : base(authorizationService, logger, mediator)
        {
        }

        /// <inheritdoc/>
        protected override EventId GetViewEventId() => new EventId(1, "View Spreadsheet");

        /// <inheritdoc/>
        protected override string GetViewPolicyName() => "ViewSpreadSheet";

        /// <inheritdoc/>
        protected override Task<DownloadSpreadsheetRequestDto> ViewCommandFactoryAsync(
            int request,
            ClaimsPrincipal claimsPrincipal,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(new DownloadSpreadsheetRequestDto(request, claimsPrincipal));
        }

        /// <inheritdoc/>
        protected override string GetMediaTypeHeaderString() => MediaTypeHeaderStringHelpers.ApplicationVndOpenXmlFormatsOfficeDocumentSpreadsheetMlSheet;
    }
}
