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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScheduledActionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个定时任务ID查询。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 获取定时任务 ID。每次请求的实例的上限为100。参数不支持同时指定ScheduledActionIds和Filters。
        /// </summary>
        [JsonProperty("ScheduledActionIds")]
        public string[] ScheduledActionIds{ get; set; }

        /// <summary>
        /// 过滤条件。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 获取定时任务 ID，定时任务名称，伸缩组 ID。
        /// <li> scheduled-action-id - String - 是否必填：否 -（过滤条件）按照定时任务ID过滤。</li>
        /// <li> scheduled-action-name - String - 是否必填：否 - （过滤条件） 按照定时任务名称过滤。</li>
        /// <li> auto-scaling-group-id - String - 是否必填：否 - （过滤条件） 按照伸缩组ID过滤。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ScheduledActionIds.", this.ScheduledActionIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

