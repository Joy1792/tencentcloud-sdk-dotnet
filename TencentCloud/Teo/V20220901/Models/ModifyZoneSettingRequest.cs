/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyZoneSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 待变更的站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 缓存过期时间配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("CacheConfig")]
        public CacheConfig CacheConfig{ get; set; }

        /// <summary>
        /// 节点缓存键配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// 浏览器缓存配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// 离线缓存配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// Quic 访问配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// Post 请求传输配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSize PostMaxSize{ get; set; }

        /// <summary>
        /// 智能压缩配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// Http2 回源配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("UpstreamHttp2")]
        public UpstreamHttp2 UpstreamHttp2{ get; set; }

        /// <summary>
        /// 访问协议强制 Https 跳转配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Https 加速配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// 源站配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// 智能加速配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRouting SmartRouting{ get; set; }

        /// <summary>
        /// WebSocket 配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocket WebSocket{ get; set; }

        /// <summary>
        /// 客户端 IP 回源请求头配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("ClientIpHeader")]
        public ClientIpHeader ClientIpHeader{ get; set; }

        /// <summary>
        /// 缓存预刷新配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefresh CachePrefresh{ get; set; }

        /// <summary>
        /// Ipv6 访问配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// 回源时是否携带客户端 IP 所属地域信息的配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("ClientIpCountry")]
        public ClientIpCountry ClientIpCountry{ get; set; }

        /// <summary>
        /// Grpc 协议支持配置。
        /// 不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("Grpc")]
        public Grpc Grpc{ get; set; }

        /// <summary>
        /// 图片优化配置。
        /// 不填写表示关闭。
        /// </summary>
        [JsonProperty("ImageOptimize")]
        public ImageOptimize ImageOptimize{ get; set; }

        /// <summary>
        /// 标准 Debug 配置。
        /// </summary>
        [JsonProperty("StandardDebug")]
        public StandardDebug StandardDebug{ get; set; }

        /// <summary>
        /// 视频即时处理配置。不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("JITVideoProcess")]
        public JITVideoProcess JITVideoProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "CacheConfig.", this.CacheConfig);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "UpstreamHttp2.", this.UpstreamHttp2);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "ClientIpHeader.", this.ClientIpHeader);
            this.SetParamObj(map, prefix + "CachePrefresh.", this.CachePrefresh);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "ClientIpCountry.", this.ClientIpCountry);
            this.SetParamObj(map, prefix + "Grpc.", this.Grpc);
            this.SetParamObj(map, prefix + "ImageOptimize.", this.ImageOptimize);
            this.SetParamObj(map, prefix + "StandardDebug.", this.StandardDebug);
            this.SetParamObj(map, prefix + "JITVideoProcess.", this.JITVideoProcess);
        }
    }
}

