﻿//===================================================================================
// Microsoft Developer & Platform Evangelism
//=================================================================================== 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// Copyright (c) Microsoft Corporation.  All Rights Reserved.
// This code is released under the terms of the MS-LPL license, 
// http://microsoftnlayerapp.codeplex.com/license
//===================================================================================
using System.Runtime.Serialization;

namespace Microsoft.Samples.NLayerApp.DistributedServices.Core.ErrorHandlers
{
    /// <summary>
    /// Default ServiceError
    /// </summary>
    [DataContract(Name = "ServiceError", Namespace = "Microsoft.Samples.DistributedServices.Core")]
    public class ServiceError
    {
        /// <summary>
        /// Error message that flow to client services
        /// </summary>
        [DataMember(Name="ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}
