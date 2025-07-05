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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountQuota : AbstractModel
    {
        
        /// <summary>
        /// 后付费配额列表
        /// </summary>
        [JsonProperty("PostPaidQuotaSet")]
        public PostPaidQuota[] PostPaidQuotaSet{ get; set; }

        /// <summary>
        /// 预付费配额列表
        /// </summary>
        [JsonProperty("PrePaidQuotaSet")]
        public PrePaidQuota[] PrePaidQuotaSet{ get; set; }

        /// <summary>
        /// spot配额列表
        /// </summary>
        [JsonProperty("SpotPaidQuotaSet")]
        public SpotPaidQuota[] SpotPaidQuotaSet{ get; set; }

        /// <summary>
        /// 镜像配额列表
        /// </summary>
        [JsonProperty("ImageQuotaSet")]
        public ImageQuota[] ImageQuotaSet{ get; set; }

        /// <summary>
        /// 置放群组配额列表
        /// </summary>
        [JsonProperty("DisasterRecoverGroupQuotaSet")]
        public DisasterRecoverGroupQuota[] DisasterRecoverGroupQuotaSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "PostPaidQuotaSet.", this.PostPaidQuotaSet);
            this.SetParamArrayObj(map, prefix + "PrePaidQuotaSet.", this.PrePaidQuotaSet);
            this.SetParamArrayObj(map, prefix + "SpotPaidQuotaSet.", this.SpotPaidQuotaSet);
            this.SetParamArrayObj(map, prefix + "ImageQuotaSet.", this.ImageQuotaSet);
            this.SetParamArrayObj(map, prefix + "DisasterRecoverGroupQuotaSet.", this.DisasterRecoverGroupQuotaSet);
        }
    }
}

