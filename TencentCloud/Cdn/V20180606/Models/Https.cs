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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Https : AbstractModel
    {
        
        /// <summary>
        /// https 配置开关，取值有：
        /// on：开启
        /// off：关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// http2 配置开关
        /// on：开启
        /// off：关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Http2")]
        public string Http2{ get; set; }

        /// <summary>
        /// OCSP 配置开关
        /// on：开启
        /// off：关闭
        /// 默认为关闭状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcspStapling")]
        public string OcspStapling{ get; set; }

        /// <summary>
        /// 客户端证书校验功能
        /// on：开启
        /// off：关闭
        /// 默认为关闭状态，开启时需要上传客户端证书信息，该配置项目前在灰度中，尚未全量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyClient")]
        public string VerifyClient{ get; set; }

        /// <summary>
        /// 服务端证书配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCert CertInfo{ get; set; }

        /// <summary>
        /// 客户端证书配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public ClientCert ClientCertInfo{ get; set; }

        /// <summary>
        /// Spdy 配置开关
        /// on：开启
        /// off：关闭
        /// 默认为关闭状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Spdy")]
        public string Spdy{ get; set; }

        /// <summary>
        /// https 证书部署状态
        /// closed：已关闭
        /// deploying：部署中
        /// deployed：部署成功
        /// failed：部署失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SslStatus")]
        public string SslStatus{ get; set; }

        /// <summary>
        /// Hsts配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hsts")]
        public Hsts Hsts{ get; set; }

        /// <summary>
        /// Tls版本设置，仅支持部分Advance域名，支持设置 TLSv1, TLSv1.1, TLSv1.2, TLSv1.3，修改时必须开启连续的版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TlsVersion")]
        public string[] TlsVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "OcspStapling", this.OcspStapling);
            this.SetParamSimple(map, prefix + "VerifyClient", this.VerifyClient);
            this.SetParamObj(map, prefix + "CertInfo.", this.CertInfo);
            this.SetParamObj(map, prefix + "ClientCertInfo.", this.ClientCertInfo);
            this.SetParamSimple(map, prefix + "Spdy", this.Spdy);
            this.SetParamSimple(map, prefix + "SslStatus", this.SslStatus);
            this.SetParamObj(map, prefix + "Hsts.", this.Hsts);
            this.SetParamArraySimple(map, prefix + "TlsVersion.", this.TlsVersion);
        }
    }
}

