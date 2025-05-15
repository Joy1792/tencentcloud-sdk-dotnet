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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterExtraArgs : AbstractModel
    {
        
        /// <summary>
        /// etcd自定义参数，只支持独立集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Etcd")]
        public string[] Etcd{ get; set; }

        /// <summary>
        /// kube-apiserver自定义参数，参数格式为["k1=v1", "k1=v2"]， 例如["max-requests-inflight=500","feature-gates=PodShareProcessNamespace=true,DynamicKubeletConfig=true"]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KubeAPIServer")]
        public string[] KubeAPIServer{ get; set; }

        /// <summary>
        /// kube-controller-manager自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KubeControllerManager")]
        public string[] KubeControllerManager{ get; set; }

        /// <summary>
        /// kube-scheduler自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KubeScheduler")]
        public string[] KubeScheduler{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Etcd.", this.Etcd);
            this.SetParamArraySimple(map, prefix + "KubeAPIServer.", this.KubeAPIServer);
            this.SetParamArraySimple(map, prefix + "KubeControllerManager.", this.KubeControllerManager);
            this.SetParamArraySimple(map, prefix + "KubeScheduler.", this.KubeScheduler);
        }
    }
}

