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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetInstanceMaintenanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定实例ID。例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 维护时间窗开始时间。取值范围为"00:00-23:00"的任意整点或半点，如00:00或00:30。
        /// </summary>
        [JsonProperty("MaintenanceStart")]
        public string MaintenanceStart{ get; set; }

        /// <summary>
        /// 维护时间窗结束时间。
        /// - 取值范围为"00:00-23:00"的任意整点或半点，维护时间持续时长最小为30分钟，最大为3小时。
        /// - 结束时间务必是基于开始时间向后的时间。
        /// </summary>
        [JsonProperty("MaintenanceEnd")]
        public string MaintenanceEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MaintenanceStart", this.MaintenanceStart);
            this.SetParamSimple(map, prefix + "MaintenanceEnd", this.MaintenanceEnd);
        }
    }
}

