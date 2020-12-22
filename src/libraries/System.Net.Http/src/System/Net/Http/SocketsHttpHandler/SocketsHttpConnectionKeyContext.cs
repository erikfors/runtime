// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Http
{
    /// <summary>
    /// Represents the context passed to the ConnectCallback for a SocketsHttpHandler instance.
    /// </summary>
    public sealed class SocketsHttpConnectionKeyContext
    {
        private readonly DnsEndPoint _dnsEndPoint;
        private readonly HttpRequestMessage _initialRequestMessage;
        private readonly Uri? _proxyUri;
        private readonly bool _isProxyConnect;

        internal SocketsHttpConnectionKeyContext(DnsEndPoint dnsEndPoint, HttpRequestMessage initialRequestMessage, Uri? proxyUri, bool isProxyConnect)
        {
            _dnsEndPoint = dnsEndPoint;
            _initialRequestMessage = initialRequestMessage;
            _proxyUri = proxyUri;
            _isProxyConnect = isProxyConnect;
        }

        /// <summary>
        /// The DnsEndPoint to be used by the ConnectCallback to establish the connection.
        /// </summary>
        public DnsEndPoint DnsEndPoint => _dnsEndPoint;

        /// <summary>
        /// The initial HttpRequestMessage that is causing the connection to be created.
        /// </summary>
        public HttpRequestMessage InitialRequestMessage => _initialRequestMessage;

        public Uri? ProxyUri => _proxyUri;

        public bool IsProxyConnect => _isProxyConnect;
    }
}
