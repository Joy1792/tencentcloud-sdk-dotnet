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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// 编排唯一标识。
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// 编排名称。
        /// </summary>
        [JsonProperty("ScheduleName")]
        public string ScheduleName{ get; set; }

        /// <summary>
        /// 编排绑定的触发规则。
        /// </summary>
        [JsonProperty("Trigger")]
        public WorkflowTrigger Trigger{ get; set; }

        /// <summary>
        /// 编排任务列表。
        /// 注意：内部不允许部分更新，如果需要更新需全量提交编排任务列表。
        /// </summary>
        [JsonProperty("Activities")]
        public Activity[] Activities{ get; set; }

        /// <summary>
        /// 媒体处理的文件输出存储位置。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 媒体处理生成的文件输出的目标目录，必选以 / 开头和结尾。
        /// 注意：如果设置为空，则表示取消老配置的OutputDir值。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 任务的事件通知配置。
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// 资源ID，需要保证对应资源是开启状态。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "ScheduleName", this.ScheduleName);
            this.SetParamObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamArrayObj(map, prefix + "Activities.", this.Activities);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

