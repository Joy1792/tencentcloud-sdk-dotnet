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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePriceRequest : AbstractModel
    {
        
        /// <summary>
        /// 欲新购实例的可用区ID。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例节点个数，可以通过 DescribeDBInstanceSpecs
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 内存大小，单位：GB，可以通过 DescribeDBInstanceSpecs
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 存储空间大小，单位：GB，可以通过 DescribeDBInstanceSpecs
        ///  查询实例规格获得不同内存大小对应的磁盘规格下限和上限。
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 欲购买的时长，单位：月。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 欲购买的数量，默认查询购买1个实例的价格。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 付费类型。postpaid：按量付费   prepaid：预付费
        /// </summary>
        [JsonProperty("Paymode")]
        public string Paymode{ get; set; }

        /// <summary>
        /// 价格金额单位，不传默认单位为分，取值：  
        /// * pent：分
        /// * microPent：微分
        /// </summary>
        [JsonProperty("AmountUnit")]
        public string AmountUnit{ get; set; }

        /// <summary>
        /// Cpu类型，如：英特尔：Intel/AMD，海光：Hygon，默认Intel/AMD
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Paymode", this.Paymode);
            this.SetParamSimple(map, prefix + "AmountUnit", this.AmountUnit);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
        }
    }
}

