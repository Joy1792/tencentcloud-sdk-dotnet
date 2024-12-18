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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskByStatusReportRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 时间类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 聚合单元，H小时
        /// </summary>
        [JsonProperty("AggregationUnit")]
        public string AggregationUnit{ get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("CycleUnit")]
        public string CycleUnit{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 项目ID列表，用于多项目实例趋势筛选，当指定了 ProjectIds 的时候，ProjectId 将只用来鉴权，不做筛选
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AggregationUnit", this.AggregationUnit);
            this.SetParamSimple(map, prefix + "CycleUnit", this.CycleUnit);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
        }
    }
}

