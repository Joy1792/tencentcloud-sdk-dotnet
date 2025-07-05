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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadConfig : AbstractModel
    {
        
        /// <summary>
        /// 工作副本数
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 资源配置
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceRequirements Resources{ get; set; }

        /// <summary>
        /// HPA策略
        /// </summary>
        [JsonProperty("HorizontalPodAutoscaler")]
        public HorizontalPodAutoscalerSpec HorizontalPodAutoscaler{ get; set; }

        /// <summary>
        /// 部署到指定节点
        /// </summary>
        [JsonProperty("SelectedNodeList")]
        public string[] SelectedNodeList{ get; set; }

        /// <summary>
        /// 组件的部署模式，取值说明：
        /// IN_GENERAL_NODE：常规节点
        /// IN_EKLET：eklet 节点
        /// IN_SHARED_NODE_POOL：共享节电池
        /// IN_EXCLUSIVE_NODE_POOL：独占节点池
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamArraySimple(map, prefix + "SelectedNodeList.", this.SelectedNodeList);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
        }
    }
}

