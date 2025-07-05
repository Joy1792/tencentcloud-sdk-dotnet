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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页Limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页Offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 演练名称
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// 标签键
        /// </summary>
        [JsonProperty("TaskTag")]
        public string[] TaskTag{ get; set; }

        /// <summary>
        /// 任务状态(1001 -- 未开始 1002 -- 进行中 1003 -- 暂停中 1004 -- 任务结束)
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 开始时间，固定格式%Y-%m-%d %H:%M:%S
        /// </summary>
        [JsonProperty("TaskStartTime")]
        public string TaskStartTime{ get; set; }

        /// <summary>
        /// 结束时间，固定格式%Y-%m-%d %H:%M:%S
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// 更新时间，固定格式%Y-%m-%d %H:%M:%S
        /// </summary>
        [JsonProperty("TaskUpdateTime")]
        public string TaskUpdateTime{ get; set; }

        /// <summary>
        /// 标签对
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }

        /// <summary>
        /// 筛选条件
        /// </summary>
        [JsonProperty("Filters")]
        public ActionFilter[] Filters{ get; set; }

        /// <summary>
        /// 演练ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong?[] TaskId{ get; set; }

        /// <summary>
        /// 关联应用ID筛选
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string[] ApplicationId{ get; set; }

        /// <summary>
        /// 关联应用筛选
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string[] ApplicationName{ get; set; }

        /// <summary>
        /// 任务状态筛选--支持多选 任务状态(1001 -- 未开始 1002 -- 进行中 1003 -- 暂停中 1004 -- 任务结束)
        /// </summary>
        [JsonProperty("TaskStatusList")]
        public ulong?[] TaskStatusList{ get; set; }

        /// <summary>
        /// 架构ID
        /// </summary>
        [JsonProperty("ArchId")]
        public string ArchId{ get; set; }

        /// <summary>
        /// 架构名称
        /// </summary>
        [JsonProperty("ArchName")]
        public string ArchName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamArraySimple(map, prefix + "TaskTag.", this.TaskTag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskStartTime", this.TaskStartTime);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "TaskUpdateTime", this.TaskUpdateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "TaskId.", this.TaskId);
            this.SetParamArraySimple(map, prefix + "ApplicationId.", this.ApplicationId);
            this.SetParamArraySimple(map, prefix + "ApplicationName.", this.ApplicationName);
            this.SetParamArraySimple(map, prefix + "TaskStatusList.", this.TaskStatusList);
            this.SetParamSimple(map, prefix + "ArchId", this.ArchId);
            this.SetParamSimple(map, prefix + "ArchName", this.ArchName);
        }
    }
}

