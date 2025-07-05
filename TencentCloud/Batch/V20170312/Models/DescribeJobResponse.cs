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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 作业ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 可用区信息
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 作业优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 作业状态
        /// </summary>
        [JsonProperty("JobState")]
        public string JobState{ get; set; }

        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并且使用UTC时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 结束时间。按照ISO8601标准表示，并且使用UTC时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务视图信息
        /// </summary>
        [JsonProperty("TaskSet")]
        public TaskView[] TaskSet{ get; set; }

        /// <summary>
        /// 任务间依赖信息
        /// </summary>
        [JsonProperty("DependenceSet")]
        public Dependence[] DependenceSet{ get; set; }

        /// <summary>
        /// 任务统计指标
        /// </summary>
        [JsonProperty("TaskMetrics")]
        public TaskMetrics TaskMetrics{ get; set; }

        /// <summary>
        /// 任务实例统计指标
        /// </summary>
        [JsonProperty("TaskInstanceMetrics")]
        public TaskInstanceMetrics TaskInstanceMetrics{ get; set; }

        /// <summary>
        /// 作业失败原因
        /// </summary>
        [JsonProperty("StateReason")]
        public string StateReason{ get; set; }

        /// <summary>
        /// 作业绑定的标签列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 下一步动作
        /// </summary>
        [JsonProperty("NextAction")]
        public string NextAction{ get; set; }

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
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "JobState", this.JobState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "TaskSet.", this.TaskSet);
            this.SetParamArrayObj(map, prefix + "DependenceSet.", this.DependenceSet);
            this.SetParamObj(map, prefix + "TaskMetrics.", this.TaskMetrics);
            this.SetParamObj(map, prefix + "TaskInstanceMetrics.", this.TaskInstanceMetrics);
            this.SetParamSimple(map, prefix + "StateReason", this.StateReason);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NextAction", this.NextAction);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

