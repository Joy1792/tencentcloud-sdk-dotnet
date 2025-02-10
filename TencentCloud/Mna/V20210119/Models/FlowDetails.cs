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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowDetails : AbstractModel
    {
        
        /// <summary>
        /// 流量数据点
        /// </summary>
        [JsonProperty("NetDetails")]
        public NetDetails[] NetDetails{ get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 流量最大值（单位：bytes）
        /// </summary>
        [JsonProperty("MaxValue")]
        public float? MaxValue{ get; set; }

        /// <summary>
        /// 流量平均值（单位：bytes）
        /// </summary>
        [JsonProperty("AvgValue")]
        public float? AvgValue{ get; set; }

        /// <summary>
        /// 流量总值（单位：bytes）
        /// </summary>
        [JsonProperty("TotalValue")]
        public float? TotalValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NetDetails.", this.NetDetails);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "AvgValue", this.AvgValue);
            this.SetParamSimple(map, prefix + "TotalValue", this.TotalValue);
        }
    }
}

