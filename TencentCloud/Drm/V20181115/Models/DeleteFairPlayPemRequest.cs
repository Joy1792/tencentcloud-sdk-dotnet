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

namespace TencentCloud.Drm.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteFairPlayPemRequest : AbstractModel
    {
        
        /// <summary>
        /// 委托者Id,适用于托管自身证书的客户。普通客户无需填该字段。
        /// </summary>
        [JsonProperty("BailorId")]
        public ulong? BailorId{ get; set; }

        /// <summary>
        /// 要删除的pem id。
        /// 当未传入该值时，将删除所有的私钥。
        /// </summary>
        [JsonProperty("FairPlayPemId")]
        public ulong? FairPlayPemId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BailorId", this.BailorId);
            this.SetParamSimple(map, prefix + "FairPlayPemId", this.FairPlayPemId);
        }
    }
}

