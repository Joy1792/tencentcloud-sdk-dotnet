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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBPOfflineAttachmentRequest : AbstractModel
    {
        
        /// <summary>
        /// 营业执照
        /// </summary>
        [JsonProperty("LicenseName")]
        public string LicenseName{ get; set; }

        /// <summary>
        /// 授权书
        /// </summary>
        [JsonProperty("AuthorizationName")]
        public string AuthorizationName{ get; set; }

        /// <summary>
        /// 商标名称
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 商标证明
        /// </summary>
        [JsonProperty("BrandCertificateName")]
        public string BrandCertificateName{ get; set; }

        /// <summary>
        /// 商标转让证明
        /// </summary>
        [JsonProperty("TransferName")]
        public string TransferName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseName", this.LicenseName);
            this.SetParamSimple(map, prefix + "AuthorizationName", this.AuthorizationName);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "BrandCertificateName", this.BrandCertificateName);
            this.SetParamSimple(map, prefix + "TransferName", this.TransferName);
        }
    }
}

