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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作流名称
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 触发方式
        /// </summary>
        [JsonProperty("TriggerRule")]
        public TaskRule TriggerRule{ get; set; }

        /// <summary>
        /// 工作流任务节点列表
        /// </summary>
        [JsonProperty("FlowEdges")]
        public TaskFlowEdge[] FlowEdges{ get; set; }

        /// <summary>
        /// 工作流执行超时时间
        /// </summary>
        [JsonProperty("TimeOut")]
        public ulong? TimeOut{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamObj(map, prefix + "TriggerRule.", this.TriggerRule);
            this.SetParamArrayObj(map, prefix + "FlowEdges.", this.FlowEdges);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
        }
    }
}

