﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Autodesk.Forge.Core
{
    /// <summary>
    /// API Response
    /// </summary>
    public class ApiResponse : IDisposable
    {
        public HttpResponseMessage HttpResponse { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="response">Http response message.</param>
        public ApiResponse(HttpResponseMessage response)
        {
            this.HttpResponse = response;
        }

        public void Dispose()
        {
            HttpResponse?.Dispose();
        }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public class ApiResponse<T> : ApiResponse
    {
        /// <summary>
        /// Gets content (parsed HTTP body)
        /// </summary>
        /// <value>The data.</value>
        public T Content { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="response">Http response message.</param>
        /// <param name="data">content (parsed HTTP body)</param>
        public ApiResponse(HttpResponseMessage response, T content)
            : base(response)
        {
            this.Content = content;
        }

    }
}