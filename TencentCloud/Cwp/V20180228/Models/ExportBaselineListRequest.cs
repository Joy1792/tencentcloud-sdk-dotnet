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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportBaselineListRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件：
        /// <li>StrategyId- Uint64 - 基线策略id</li>
        /// <li>Status - Uint64 - 事件状态：0-未通过，1-忽略，3-通过，5-检测中</li>
        /// <li>BaselineName  - String - 基线名称</li>
        /// <li>AliasName- String - 服务器名称/服务器ip</li>
        /// <li>Uuid- String - 主机uuid</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("IfDetail")]
        public ulong? IfDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IfDetail", this.IfDetail);
        }
    }
}

