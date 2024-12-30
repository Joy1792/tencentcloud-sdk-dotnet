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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterActivity : AbstractModel
    {
        
        /// <summary>
        /// 集群ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// 集群活动类型。取值范围：<br><li>CreateAndAddNodes：创建实例并添加进集群</li><br><li>RemoveNodesFromCluster：从集群移除实例</li><br><li>TerminateNodes：销毁实例</li><br><li>MountStorageOption：增加挂载选项并进行挂载</li><br><li>UmountStorageOption：删除集群挂载存储选项并解挂载</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 集群活动状态。取值范围：<br><li>PENDING：等待运行</li><br><li>RUNNING：运行中</li><br><li>SUCCESSFUL：活动成功</li><br><li>PARTIALLY_SUCCESSFUL：活动部分成功</li><br><li>FAILED：活动失败</li>
        /// </summary>
        [JsonProperty("ActivityStatus")]
        public string ActivityStatus{ get; set; }

        /// <summary>
        /// 集群活动状态码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityStatusCode")]
        public string ActivityStatusCode{ get; set; }

        /// <summary>
        /// 集群活动结果详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultDetail")]
        public string ResultDetail{ get; set; }

        /// <summary>
        /// 集群活动起因。
        /// </summary>
        [JsonProperty("Cause")]
        public string Cause{ get; set; }

        /// <summary>
        /// 集群活动描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 集群活动相关节点活动集合。
        /// </summary>
        [JsonProperty("RelatedNodeActivitySet")]
        public NodeActivity[] RelatedNodeActivitySet{ get; set; }

        /// <summary>
        /// 集群活动开始时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 集群活动结束时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "ActivityStatus", this.ActivityStatus);
            this.SetParamSimple(map, prefix + "ActivityStatusCode", this.ActivityStatusCode);
            this.SetParamSimple(map, prefix + "ResultDetail", this.ResultDetail);
            this.SetParamSimple(map, prefix + "Cause", this.Cause);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "RelatedNodeActivitySet.", this.RelatedNodeActivitySet);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

