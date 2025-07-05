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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LivePackageInfo : AbstractModel
    {
        
        /// <summary>
        /// 包 ID。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 总量。
        /// 注意：当为流量包时单位为字节。
        /// 当为转码包时单位为分钟。
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 使用量。
        /// 注意：当为流量包时单位为字节。
        /// 当为转码包时单位为分钟。
        /// 当为连麦包时单位为小时。
        /// </summary>
        [JsonProperty("Used")]
        public long? Used{ get; set; }

        /// <summary>
        /// 剩余量。
        /// 注意：当为流量包时单位为字节。
        /// 当为转码包时单位为分钟。
        /// 当为连麦包时单位为小时。
        /// </summary>
        [JsonProperty("Left")]
        public long? Left{ get; set; }

        /// <summary>
        /// 购买时间。
        /// 注：此字段为北京时间（UTC+8时区）。
        /// </summary>
        [JsonProperty("BuyTime")]
        public string BuyTime{ get; set; }

        /// <summary>
        /// 过期时间。
        /// 注：此字段为北京时间（UTC+8时区）。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 包类型，可选值:
        /// 0: 流量包。
        /// 1: 普通转码包。
        /// 2: 极速高清包。
        /// 3: 连麦包。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 包状态，可选值:
        /// 0: 未使用。
        /// 1: 使用中。
        /// 2: 已过期。
        /// 3: 已冻结。
        /// 4: 已耗尽。
        /// 5: 已退款
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否自动续购。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WillRenew")]
        public long? WillRenew{ get; set; }

        /// <summary>
        /// 续购状态。
        /// 1 ：续购成功。
        /// 0 ：尚未续购。
        /// <0  : 续购失败。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewalResult")]
        public long? RenewalResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "Left", this.Left);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "WillRenew", this.WillRenew);
            this.SetParamSimple(map, prefix + "RenewalResult", this.RenewalResult);
        }
    }
}

