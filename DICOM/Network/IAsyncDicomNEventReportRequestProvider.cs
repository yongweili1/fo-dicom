﻿// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using System.Threading.Tasks;

namespace Dicom.Network
{
    /// <summary>
    /// Interface representing event handler for synchronous storage commitment handling
    /// </summary>
    public interface IAsyncDicomDicomNEventReportRequestProvider
    {
        /// <summary>
        /// Provide the server implementer a facility to send synchronous N-EVENT-REPORT.
        /// It requires N-ACTION as the context
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task OnSendNEventReportRequestAsync(DicomNActionRequest request);
    }
}
