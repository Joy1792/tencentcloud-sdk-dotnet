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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrajectoryDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 集团ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 总人数
        /// </summary>
        [JsonProperty("TotalPerson")]
        public long? TotalPerson{ get; set; }

        /// <summary>
        /// 总动迹数目
        /// </summary>
        [JsonProperty("TotalTrajectory")]
        public long? TotalTrajectory{ get; set; }

        /// <summary>
        /// 返回动迹中的总人数
        /// </summary>
        [JsonProperty("Person")]
        public long? Person{ get; set; }

        /// <summary>
        /// 返回动迹的数目
        /// </summary>
        [JsonProperty("Trajectory")]
        public long? Trajectory{ get; set; }

        /// <summary>
        /// 返回动迹的具体信息
        /// </summary>
        [JsonProperty("Data")]
        public TrajectorySunData[] Data{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "TotalPerson", this.TotalPerson);
            this.SetParamSimple(map, prefix + "TotalTrajectory", this.TotalTrajectory);
            this.SetParamSimple(map, prefix + "Person", this.Person);
            this.SetParamSimple(map, prefix + "Trajectory", this.Trajectory);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

