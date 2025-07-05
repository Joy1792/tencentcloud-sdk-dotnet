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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSSLStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// SSL 证书下载地址。
        /// </summary>
        [JsonProperty("CertDownloadUrl")]
        public string CertDownloadUrl{ get; set; }

        /// <summary>
        /// 证书下载链接到期时间。
        /// </summary>
        [JsonProperty("UrlExpiredTime")]
        public string UrlExpiredTime{ get; set; }

        /// <summary>
        /// 标识实例开启 SSL 功能。
        /// - true：开启 。
        /// - false：关闭。
        /// </summary>
        [JsonProperty("SSLConfig")]
        public bool? SSLConfig{ get; set; }

        /// <summary>
        /// 标识实例是否支持 SSL特性。
        /// - true：支持。
        /// - false：不支持。
        /// </summary>
        [JsonProperty("FeatureSupport")]
        public bool? FeatureSupport{ get; set; }

        /// <summary>
        /// 说明配置 SSL 的状态。
        /// - 1: 配置中。
        /// - 2：配置成功。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertDownloadUrl", this.CertDownloadUrl);
            this.SetParamSimple(map, prefix + "UrlExpiredTime", this.UrlExpiredTime);
            this.SetParamSimple(map, prefix + "SSLConfig", this.SSLConfig);
            this.SetParamSimple(map, prefix + "FeatureSupport", this.FeatureSupport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

