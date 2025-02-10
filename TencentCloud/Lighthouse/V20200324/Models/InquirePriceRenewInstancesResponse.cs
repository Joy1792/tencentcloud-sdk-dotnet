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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceRenewInstancesResponse : AbstractModel
    {
        
        /// <summary>
        /// 询价信息。默认为列表中第一个实例的价格信息。
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }

        /// <summary>
        /// 数据盘价格信息列表。
        /// </summary>
        [JsonProperty("DataDiskPriceSet")]
        public DataDiskPrice[] DataDiskPriceSet{ get; set; }

        /// <summary>
        /// 待续费实例价格列表。
        /// </summary>
        [JsonProperty("InstancePriceDetailSet")]
        public InstancePriceDetail[] InstancePriceDetailSet{ get; set; }

        /// <summary>
        /// 总计价格。
        /// </summary>
        [JsonProperty("TotalPrice")]
        public TotalPrice TotalPrice{ get; set; }

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
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamArrayObj(map, prefix + "DataDiskPriceSet.", this.DataDiskPriceSet);
            this.SetParamArrayObj(map, prefix + "InstancePriceDetailSet.", this.InstancePriceDetailSet);
            this.SetParamObj(map, prefix + "TotalPrice.", this.TotalPrice);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

