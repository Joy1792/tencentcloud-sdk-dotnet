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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBaselineHostDetectListRequest : AbstractModel
    {
        
        /// <summary>
        /// <li>PolicyId - int64 - 是否必填：否 - 策略Id</li>
        /// <li>HostName - string - 是否必填：否 - 主机名称</li>
        /// <li>HostIp - string - 是否必填：否 - 主机Ip</li>
        /// <li>ItemId - int64 - 是否必填：否 - 项Id</li>
        /// <li>RuleId - int64 - 是否必填：否 - 规则Id</li>
        /// <li>DetectStatus - int - 是否必填：否 - 检测状态</li>
        /// <li>Level - int - 是否必填：否 - 风险等级</li>
        /// <li>StartTime - string - 是否必填：否 - 开时时间</li>
        /// <li>EndTime - string - 是否必填：否 - 结束时间</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 限制条数,默认10,最大100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量,默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序方式: [ASC:升序|DESC:降序]
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 可选排序列: [LastTime|ItemCount|PassedItemCount|NotPassedItemCount|FirstTime]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

