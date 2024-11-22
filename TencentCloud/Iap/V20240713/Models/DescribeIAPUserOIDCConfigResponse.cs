/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Iap.V20240713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIAPUserOIDCConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 身份提供商类型。 13：IAP用户OIDC身份提供商
        /// </summary>
        [JsonProperty("ProviderType")]
        public ulong? ProviderType{ get; set; }

        /// <summary>
        /// 身份提供商URL
        /// </summary>
        [JsonProperty("IdentityUrl")]
        public string IdentityUrl{ get; set; }

        /// <summary>
        /// 签名公钥
        /// </summary>
        [JsonProperty("IdentityKey")]
        public string IdentityKey{ get; set; }

        /// <summary>
        /// 客户端id
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 状态：0:未设置，11:已开启，2:已禁用
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// HTTPS CA证书的验证指纹，允许英文字母和数字，每个指纹长度为40个字符，最多5个指纹。
        /// </summary>
        [JsonProperty("Fingerprints")]
        public string[] Fingerprints{ get; set; }

        /// <summary>
        /// 是否需要开启自动使用OIDC签名公钥，1:需要，2:不需要，默认不需要
        /// </summary>
        [JsonProperty("EnableAutoPublicKey")]
        public ulong? EnableAutoPublicKey{ get; set; }

        /// <summary>
        /// 授权请求Endpoint
        /// </summary>
        [JsonProperty("AuthorizationEndpoint")]
        public string AuthorizationEndpoint{ get; set; }

        /// <summary>
        /// 授权请求Scope
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// 授权请求Response type
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 授权请求Response mode
        /// </summary>
        [JsonProperty("ResponseMode")]
        public string ResponseMode{ get; set; }

        /// <summary>
        /// 映射字段名称
        /// </summary>
        [JsonProperty("MappingFiled")]
        public string MappingFiled{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "IdentityUrl", this.IdentityUrl);
            this.SetParamSimple(map, prefix + "IdentityKey", this.IdentityKey);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Fingerprints.", this.Fingerprints);
            this.SetParamSimple(map, prefix + "EnableAutoPublicKey", this.EnableAutoPublicKey);
            this.SetParamSimple(map, prefix + "AuthorizationEndpoint", this.AuthorizationEndpoint);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseMode", this.ResponseMode);
            this.SetParamSimple(map, prefix + "MappingFiled", this.MappingFiled);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

