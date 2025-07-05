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

namespace TencentCloud.Asw.V20200722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyFlowServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 状态机资源名
        /// </summary>
        [JsonProperty("FlowServiceResource")]
        public string FlowServiceResource{ get; set; }

        /// <summary>
        /// 定义JSON
        /// </summary>
        [JsonProperty("Definition")]
        public string Definition{ get; set; }

        /// <summary>
        /// 状态机所属服务名
        /// </summary>
        [JsonProperty("FlowServiceName")]
        public string FlowServiceName{ get; set; }

        /// <summary>
        /// 状态机所属服务中文名
        /// </summary>
        [JsonProperty("FlowServiceChineseName")]
        public string FlowServiceChineseName{ get; set; }

        /// <summary>
        /// 是否是新角色
        /// </summary>
        [JsonProperty("IsNewRole")]
        public bool? IsNewRole{ get; set; }

        /// <summary>
        /// 状态机类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 角色资源名
        /// </summary>
        [JsonProperty("RoleResource")]
        public string RoleResource{ get; set; }

        /// <summary>
        /// 状态机备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否允许日志投递
        /// </summary>
        [JsonProperty("EnableCLS")]
        public bool? EnableCLS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowServiceResource", this.FlowServiceResource);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "FlowServiceName", this.FlowServiceName);
            this.SetParamSimple(map, prefix + "FlowServiceChineseName", this.FlowServiceChineseName);
            this.SetParamSimple(map, prefix + "IsNewRole", this.IsNewRole);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RoleResource", this.RoleResource);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnableCLS", this.EnableCLS);
        }
    }
}

