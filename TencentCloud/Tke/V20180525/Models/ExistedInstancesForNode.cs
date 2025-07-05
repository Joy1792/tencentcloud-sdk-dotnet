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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExistedInstancesForNode : AbstractModel
    {
        
        /// <summary>
        /// 节点角色，取值:MASTER_ETCD, WORKER。MASTER_ETCD只有在创建 INDEPENDENT_CLUSTER 独立集群时需要指定。MASTER_ETCD节点数量为3～7，建议为奇数。MASTER_ETCD最小配置为4C8G。
        /// </summary>
        [JsonProperty("NodeRole")]
        public string NodeRole{ get; set; }

        /// <summary>
        /// 已存在实例的重装参数
        /// </summary>
        [JsonProperty("ExistedInstancesPara")]
        public ExistedInstancesPara ExistedInstancesPara{ get; set; }

        /// <summary>
        /// 节点高级设置，会覆盖集群级别设置的InstanceAdvancedSettings（当前只对节点自定义参数ExtraArgs生效）
        /// </summary>
        [JsonProperty("InstanceAdvancedSettingsOverride")]
        public InstanceAdvancedSettings InstanceAdvancedSettingsOverride{ get; set; }

        /// <summary>
        /// 自定义模式集群，可指定每个节点的pod数量
        /// </summary>
        [JsonProperty("DesiredPodNumbers")]
        public long?[] DesiredPodNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeRole", this.NodeRole);
            this.SetParamObj(map, prefix + "ExistedInstancesPara.", this.ExistedInstancesPara);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettingsOverride.", this.InstanceAdvancedSettingsOverride);
            this.SetParamArraySimple(map, prefix + "DesiredPodNumbers.", this.DesiredPodNumbers);
        }
    }
}

