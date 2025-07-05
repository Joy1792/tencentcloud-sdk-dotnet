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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFilter : AbstractModel
    {
        
        /// <summary>
        /// 媒资文件类型
        /// </summary>
        [JsonProperty("MediaTypeSet")]
        public long?[] MediaTypeSet{ get; set; }

        /// <summary>
        /// 待筛选的任务状态列表
        /// </summary>
        [JsonProperty("TaskStatusSet")]
        public long?[] TaskStatusSet{ get; set; }

        /// <summary>
        /// 待筛选的任务名称数组
        /// </summary>
        [JsonProperty("TaskNameSet")]
        public string[] TaskNameSet{ get; set; }

        /// <summary>
        /// TaskId数组
        /// </summary>
        [JsonProperty("TaskIdSet")]
        public string[] TaskIdSet{ get; set; }

        /// <summary>
        /// 媒资文件名数组
        /// </summary>
        [JsonProperty("MediaNameSet")]
        public string[] MediaNameSet{ get; set; }

        /// <summary>
        /// 媒资语言类型
        /// </summary>
        [JsonProperty("MediaLangSet")]
        public long?[] MediaLangSet{ get; set; }

        /// <summary>
        /// 媒资素材一级类型
        /// </summary>
        [JsonProperty("MediaLabelSet")]
        public long?[] MediaLabelSet{ get; set; }

        /// <summary>
        /// 媒资自定义标签数组
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MediaTypeSet.", this.MediaTypeSet);
            this.SetParamArraySimple(map, prefix + "TaskStatusSet.", this.TaskStatusSet);
            this.SetParamArraySimple(map, prefix + "TaskNameSet.", this.TaskNameSet);
            this.SetParamArraySimple(map, prefix + "TaskIdSet.", this.TaskIdSet);
            this.SetParamArraySimple(map, prefix + "MediaNameSet.", this.MediaNameSet);
            this.SetParamArraySimple(map, prefix + "MediaLangSet.", this.MediaLangSet);
            this.SetParamArraySimple(map, prefix + "MediaLabelSet.", this.MediaLabelSet);
            this.SetParamArraySimple(map, prefix + "LabelSet.", this.LabelSet);
        }
    }
}

