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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IngressGatewayStatus : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例状态
        /// </summary>
        [JsonProperty("LoadBalancer")]
        public LoadBalancerStatus LoadBalancer{ get; set; }

        /// <summary>
        /// ingress gateway 当前的版本
        /// </summary>
        [JsonProperty("CurrentVersion")]
        public string CurrentVersion{ get; set; }

        /// <summary>
        /// ingress gateway 目标的版本
        /// </summary>
        [JsonProperty("DesiredVersion")]
        public string DesiredVersion{ get; set; }

        /// <summary>
        /// ingress gateway的状态，取值running, upgrading, rollbacking
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LoadBalancer.", this.LoadBalancer);
            this.SetParamSimple(map, prefix + "CurrentVersion", this.CurrentVersion);
            this.SetParamSimple(map, prefix + "DesiredVersion", this.DesiredVersion);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

