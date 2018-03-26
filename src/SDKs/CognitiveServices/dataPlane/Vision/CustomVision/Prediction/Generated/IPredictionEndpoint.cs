// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IPredictionEndpoint : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// </summary>
        string ApiKey { get; set; }


        /// <summary>
        /// Predict an image url and saves the result
        /// </summary>
        /// <param name='projectId'>
        /// The project id
        /// </param>
        /// <param name='imageUrl'>
        /// An {Iris.Web.Api.Models.ImageUrl} that contains the url of the
        /// image to be evaluated
        /// </param>
        /// <param name='iterationId'>
        /// Optional. Specifies the id of a particular iteration to evaluate
        /// against.
        /// The default iteration for the project will be used when not
        /// specified
        /// </param>
        /// <param name='application'>
        /// Optional. Specifies the name of application using the endpoint
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ImagePredictionResultModel>> PredictImageUrlWithHttpMessagesAsync(System.Guid projectId, ImageUrl imageUrl, System.Guid? iterationId = default(System.Guid?), string application = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Predict an image and saves the result
        /// </summary>
        /// <param name='projectId'>
        /// The project id
        /// </param>
        /// <param name='imageData'>
        /// </param>
        /// <param name='iterationId'>
        /// Optional. Specifies the id of a particular iteration to evaluate
        /// against.
        /// The default iteration for the project will be used when not
        /// specified
        /// </param>
        /// <param name='application'>
        /// Optional. Specifies the name of application using the endpoint
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ImagePredictionResultModel>> PredictImageWithHttpMessagesAsync(System.Guid projectId, Stream imageData, System.Guid? iterationId = default(System.Guid?), string application = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Predict an image url without saving the result
        /// </summary>
        /// <param name='projectId'>
        /// The project id
        /// </param>
        /// <param name='imageUrl'>
        /// An {Iris.Web.Api.Models.ImageUrl} that contains the url of the
        /// image to be evaluated
        /// </param>
        /// <param name='iterationId'>
        /// Optional. Specifies the id of a particular iteration to evaluate
        /// against.
        /// The default iteration for the project will be used when not
        /// specified
        /// </param>
        /// <param name='application'>
        /// Optional. Specifies the name of application using the endpoint
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ImagePredictionResultModel>> PredictImageUrlWithNoStoreWithHttpMessagesAsync(System.Guid projectId, ImageUrl imageUrl, System.Guid? iterationId = default(System.Guid?), string application = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Predict an image without saving the result
        /// </summary>
        /// <param name='projectId'>
        /// The project id
        /// </param>
        /// <param name='imageData'>
        /// </param>
        /// <param name='iterationId'>
        /// Optional. Specifies the id of a particular iteration to evaluate
        /// against.
        /// The default iteration for the project will be used when not
        /// specified
        /// </param>
        /// <param name='application'>
        /// Optional. Specifies the name of application using the endpoint
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ImagePredictionResultModel>> PredictImageWithNoStoreWithHttpMessagesAsync(System.Guid projectId, Stream imageData, System.Guid? iterationId = default(System.Guid?), string application = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
