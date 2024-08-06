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

    public class CreateOpsMakePlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 补录计划名称
        /// </summary>
        [JsonProperty("MakeName")]
        public string MakeName{ get; set; }

        /// <summary>
        /// 补录任务集合
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 补录计划日期范围
        /// </summary>
        [JsonProperty("MakeDatetimeList")]
        public CreateMakeDatetimeInfo[] MakeDatetimeList{ get; set; }

        /// <summary>
        /// 项目标识
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// 补录是否检查父任务状态，默认不检查。不推荐使用，后续会废弃，推荐使用 CheckParentType。
        /// </summary>
        [JsonProperty("CheckParent")]
        public bool? CheckParent{ get; set; }

        /// <summary>
        /// 补录检查父任务类型。取值范围：
        /// <li> NONE: 全部不检查 </li>
        /// <li> ALL: 检查全部上游父任务 </li>
        /// <li> MAKE_SCOPE: 只在（当前补录计划）选中任务中检查 </li>
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 已弃用。任务自依赖类型：parallel（并行），serial（无序串行），orderly（有序串行）
        /// </summary>
        [JsonProperty("SelfDependence")]
        public string SelfDependence{ get; set; }

        /// <summary>
        /// 并行度
        /// </summary>
        [JsonProperty("ParallelNum")]
        public long? ParallelNum{ get; set; }

        /// <summary>
        /// 补录实例生成周期是否和原周期相同，默认为true
        /// </summary>
        [JsonProperty("SameCycle")]
        public bool? SameCycle{ get; set; }

        /// <summary>
        /// 补录实例目标周期类型
        /// </summary>
        [JsonProperty("TargetTaskCycle")]
        public string TargetTaskCycle{ get; set; }

        /// <summary>
        /// 补录实例目标周期类型指定时间
        /// </summary>
        [JsonProperty("TargetTaskAction")]
        public long? TargetTaskAction{ get; set; }

        /// <summary>
        /// 补录实例自定义参数
        /// </summary>
        [JsonProperty("MapParamList")]
        public StrToStrMap[] MapParamList{ get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 补录计划说明
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否使用任务原有自依赖配置，默认为true
        /// </summary>
        [JsonProperty("SameSelfDependType")]
        public bool? SameSelfDependType{ get; set; }

        /// <summary>
        /// 补录实例原始周期类型
        /// </summary>
        [JsonProperty("SourceTaskCycle")]
        public string SourceTaskCycle{ get; set; }

        /// <summary>
        /// 补录指定的调度资源组（ID） 为空则表示使用任务原有调度执行资源组
        /// </summary>
        [JsonProperty("SchedulerResourceGroup")]
        public string SchedulerResourceGroup{ get; set; }

        /// <summary>
        /// 补录指定的集成资源组（ID） 为空则表示使用任务原有集成执行资源组
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }

        /// <summary>
        /// 补录指定的调度资源组名称 为空则表示使用任务原有调度执行资源组
        /// </summary>
        [JsonProperty("SchedulerResourceGroupName")]
        public string SchedulerResourceGroupName{ get; set; }

        /// <summary>
        /// 补录指定的集成资源组名称 为空则表示使用任务原有集成执行资源组
        /// </summary>
        [JsonProperty("IntegrationResourceGroupName")]
        public string IntegrationResourceGroupName{ get; set; }

        /// <summary>
        /// 补录扩展属性
        /// </summary>
        [JsonProperty("MakeExtList")]
        public StrToStrMap[] MakeExtList{ get; set; }

        /// <summary>
        /// 补录扩展属性
        /// </summary>
        [JsonProperty("SameSelfWorkflowDependType")]
        public bool? SameSelfWorkflowDependType{ get; set; }

        /// <summary>
        /// 补录扩展属性
        /// </summary>
        [JsonProperty("SelfWorkflowDependency")]
        public string SelfWorkflowDependency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MakeName", this.MakeName);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArrayObj(map, prefix + "MakeDatetimeList.", this.MakeDatetimeList);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "CheckParent", this.CheckParent);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "SelfDependence", this.SelfDependence);
            this.SetParamSimple(map, prefix + "ParallelNum", this.ParallelNum);
            this.SetParamSimple(map, prefix + "SameCycle", this.SameCycle);
            this.SetParamSimple(map, prefix + "TargetTaskCycle", this.TargetTaskCycle);
            this.SetParamSimple(map, prefix + "TargetTaskAction", this.TargetTaskAction);
            this.SetParamArrayObj(map, prefix + "MapParamList.", this.MapParamList);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SameSelfDependType", this.SameSelfDependType);
            this.SetParamSimple(map, prefix + "SourceTaskCycle", this.SourceTaskCycle);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroup", this.SchedulerResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupName", this.SchedulerResourceGroupName);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupName", this.IntegrationResourceGroupName);
            this.SetParamArrayObj(map, prefix + "MakeExtList.", this.MakeExtList);
            this.SetParamSimple(map, prefix + "SameSelfWorkflowDependType", this.SameSelfWorkflowDependType);
            this.SetParamSimple(map, prefix + "SelfWorkflowDependency", this.SelfWorkflowDependency);
        }
    }
}

